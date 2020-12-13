using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace EasySave.Models
{
    public abstract class BackupStrategy
    {
        #region public
        public enum Status
        {
            IDLE,
            RUNNING,
            PAUSED,
            BLOCKED,
        }
        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => { };

        public String DestinationDirectory { get => this.Backup.DestinationDirectory; }
        public String SourceDirectory { get => this.Backup.BackupEnvironment.SourceDirectory; }
        public String Name { get=> typeName; }

        public BackupStrategy(String typeName)
        {
            this.typeName = typeName;
        }

        public Backup Backup
        {
            get
            {
                if (backup == null)
                    throw new InvalidOperationException("");
                return backup;
            }
            internal set
            {
                if (backup != null)
                    throw new InvalidOperationException("");
                backup = value;
            }
        }
        #endregion

        private delegate int OnHighPriorityEnd();

        private static OnHighPriorityEnd onHighPriorityEnd = () => 0;
        private static int highPriorityRunning = 0;
        private static Object highPriorityLock = new Object();
        private Boolean highPriorityDone = false;


        private Semaphore pause = new Semaphore(1,1);
        private Status status = Status.IDLE;
        private List<FileTransferEvent> transfers = new List<FileTransferEvent>();
        private Backup backup;
        private String typeName;



        internal void RunExecute()
        {
            lock(this){
                if (status != Status.IDLE)
                    throw new Exception();
                status = Status.RUNNING;
                Execute();
                ExecuteTransfers();
            }
        }
        internal void RunRestore()
        {
            lock (this){
                if (status != Status.IDLE)
                    throw new Exception();
                status = Status.RUNNING;
                Restore();
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
                if(!highPriorityDone)
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


        protected abstract void Execute();
        protected abstract void Restore();


        private void ExecuteTransfers()
        {

            long TotalCount = transfers.Count;
            long TotalSize = 0;
            long currentSize = 0;
            foreach (FileTransferEvent transfer in transfers)
                TotalSize += transfer.SourceFileInfo.Length;

            highPriorityDone = false;
            highPriorityRunning++;
            transfers.Sort((FileTransferEvent a, FileTransferEvent b) => a.HighPriority ? 1 : -1);
            for (int i = 0; transfers.Count>0; i++)
            {
                FileTransferEvent transfer = transfers[0];
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
                    Name = backup.BackupEnvironment.Name,
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
            transfers.Clear();
            status = Status.IDLE;
        }

        private void waitForBlockingProcessEnd()
        {
            while (true)
            {
                foreach (String processName in Backup.BackupEnvironment.Model.BlockingProcesses)
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
            lock(highPriorityLock)
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
                transfers.Add(new FileTransferEvent(Backup,new FileInfo(file), new FileInfo(Path.Join(destBasePath, filePathFromBase))));
            }
        }
        protected void AddFileTranfer(FileTransferEvent fileTransfer)
        {
            transfers.Add(fileTransfer);
        }
        protected void TransferFile(String from,String to)
        {
            transfers.Add(new FileTransferEvent(Backup,new FileInfo(from),new FileInfo(to)));
        }
        #endregion
    }
}
