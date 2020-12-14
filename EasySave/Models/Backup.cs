using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace EasySave.Models
{
    public abstract class Backup
    {
        #region public
        public enum Status
        {
            IDLE,
            RUNNING,
            PAUSED,
            BLOCKED,
        }

        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => {};
        public DateTime ExecutionDate { get => executionDate; }
        public String DestinationDirectory { get => destinationDir; }
        public readonly BackupEnvironment BackupEnvironment;
        public String SourceDirectory { get => BackupEnvironment.SourceDirectory; }
        public readonly BackupType Type;

        #endregion



        #region PrivateAndInternal

        private delegate int OnHighPriorityEnd();

        private static OnHighPriorityEnd onHighPriorityEnd = () => 0;
        private static int highPriorityRunning = 0;
        private static Object highPriorityLock = new Object();

        private DateTime executionDate;
        private String destinationDir;
        private Boolean highPriorityDone = false;
        private Semaphore pause = new Semaphore(1, 1);
        private Status status = Status.IDLE;
        private List<FileTransferEvent> transfers = new List<FileTransferEvent>();

        internal Backup(BackupEnvironment backupEnvironment, BackupType type)
        {
            this.BackupEnvironment = backupEnvironment;
            this.Type = type;
        }
        internal Backup(BackupEnvironment backupEnvironment, BackupType type, string destinationDirectory, DateTime dateTime) : this(backupEnvironment, type)
        {
            this.destinationDir = destinationDirectory;
            this.executionDate = dateTime;
        }


        protected abstract void RunExecute();
        protected abstract void RunRestore();



        internal void Execute()
        {
            lock (this)
            {
                if (this.destinationDir != null)
                    throw new Exception();
                this.executionDate = DateTime.Now;
                this.destinationDir = Path.Join(this.BackupEnvironment.DestinationDirectory, this.ExecutionDate.ToString().Replace('/', '-').Replace(':', '-') + "-" + this.executionDate.Millisecond);
                if (status != Status.IDLE)
                    throw new Exception();
                status = Status.RUNNING;
                RunExecute();
                ExecuteTransfers();
            }
        }
        internal void Restore()
        {
            lock (this)
            {
                if (status != Status.IDLE)
                    throw new Exception();
                status = Status.RUNNING;
                RunRestore();
                ExecuteTransfers();
            }
        }




        internal void Pause()
        {
            lock (this)
            {
                if (status != Status.RUNNING)
                    throw new Exception();
                Thread pauseThread = new Thread(() => { pause.WaitOne(); });
                pauseThread.Start();
                pauseThread.Join();
                if (!highPriorityDone)
                    highPriorityRunning--;
                status = Status.PAUSED;
            }
        }
        internal void Resume()
        {
            lock (this)
            {
                if (status != Status.PAUSED)
                    throw new Exception();
                if (!highPriorityDone)
                    highPriorityRunning++;
                Thread pauseThread = new Thread(() => { pause.Release(); });
                pauseThread.Start();
                pauseThread.Join();

                status = Status.RUNNING;
            }
        }




        private void ExecuteTransfers()
        {

            long TotalCount = transfers.Count;
            long TotalSize = 0;
            long currentSize = 0;
            foreach (FileTransferEvent transfer in transfers)
                TotalSize += transfer.SourceFileInfo.Length;

            highPriorityDone = false;
            highPriorityRunning++;
            transfers.Sort((FileTransferEvent a, FileTransferEvent b) =>
            {
                if (a == null)
                    return 1;
                if (b == null)
                    return -1;
                if (a.HighPriority && !b.HighPriority)
                    return -1;
                if (!a.HighPriority && b.HighPriority)
                    return 1;
                return 0;
            });
            for (int i = 0; transfers.Count > 0; i++)
            {
                FileTransferEvent transfer = transfers[0];
                transfers.RemoveAt(0);
                pause.WaitOne();
                if (!highPriorityDone && !transfer.HighPriority)
                    endHighPriority();
                pause.Release();
                if (!transfer.HighPriority)
                    waitForHighPriorityEnd();
                waitForBlockingProcessEnd();
                status = Status.RUNNING;
                State.SetState(new State.StateStatus()
                {
                    Name = BackupEnvironment.Name,
                    Running = true,
                    Status = new State.Status()
                    {
                        FileNumber = transfers.Count,
                        FileSize = transfer.FileSize,
                        Progression = (float)((float)i / TotalCount * 100.0),
                        FileLeft = TotalCount - i,
                        SizeLeft = TotalSize - currentSize,
                        CurrentSourceFile = transfer.SourceFile,
                        DestinationFile = transfer.DestinationFile
                    }
                });
                transfer.ExecuteTransfer();

                currentSize += transfer.FileSize;

                new Thread(() => { OnFileTransfer(this, transfer); }).Start();
            }
            //transfers.Clear();
            status = Status.IDLE;
        }

        private void waitForBlockingProcessEnd()
        {
            while (true)
            {
                foreach (String processName in BackupEnvironment.Model.BlockingProcesses)
                {
                    if (Process.GetProcessesByName(processName).Length != 0)
                    {
                        if (status == Status.RUNNING)
                            status = Status.BLOCKED;
                        foreach (Process item in Process.GetProcessesByName(processName))
                            item.WaitForExit();
                        continue;
                    }
                }
                return;
            }
        }

        private void endHighPriority()
        {
            highPriorityDone = true;
            highPriorityRunning--;
            if (highPriorityRunning == 0)
            {
                lock (highPriorityLock)
                {
                    onHighPriorityEnd();
                }
            }
        }

        private void waitForHighPriorityEnd()
        {
            lock (highPriorityLock)
            {
                if (highPriorityRunning > 0)
                {
                    Semaphore highPriority = new Semaphore(1, 1);
                    onHighPriorityEnd += highPriority.Release;
                    highPriority.WaitOne();
                    onHighPriorityEnd -= highPriority.Release;
                }
            }
        }


        #region AddTransfer
        protected void CopyFiles(String[] sourceFiles, String srcBasePath, String destBasePath)
        {
            foreach (String file in sourceFiles)
            {
                String filePathFromBase = Path.GetRelativePath(srcBasePath, file);
                transfers.Add(new FileTransferEvent(this, new FileInfo(file), new FileInfo(Path.Join(destBasePath, filePathFromBase))));
            }
        }
        protected void AddFileTranfer(FileTransferEvent fileTransfer)
        {
            transfers.Add(fileTransfer);
        }
        protected void TransferFile(String from, String to)
        {
            transfers.Add(new FileTransferEvent(this, new FileInfo(from), new FileInfo(to)));
        }

        #endregion
        #endregion
        internal class BackupData
        {
            public BackupType BackupType;
            public String ExecutionDate;
            public String DestinationDirectory;
            public String FullBackupDirectory;
        }
    }
}
