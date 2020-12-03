using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public abstract class BackupStrategy
    {
        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => { };
        //private delegate void ExecuteDelegate(BackupStrategy backup);

        private Backup backup;

        public String Name
        {
            get;
        }
        public Backup Backup
        {
            get {
                if(backup==null)
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
        public String DestinationDirectory { get => this.Backup.DestinationDirectory;}
        public String SourceDirectory { get => this.Backup.BackupEnvironment.SourceDirectory;}

        internal void RunExecute()
        {
            Directory.CreateDirectory(DestinationDirectory);
            try
            {
                this.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        internal void RunRestore()
        {
            this.Restore();
        }


        protected abstract void Execute();
        protected abstract void Restore();

        protected void CopyFiles(String[] sourceFiles, String srcBasePath, String destBasePath)
        {
            long size = 0;
            foreach (String srcFile in sourceFiles)
            {
                size += new FileInfo(srcFile).Length;
            }
            long currentSize = 0;
            for (int i = 0; i < sourceFiles.Length; i++)
            {
                String srcFile = sourceFiles[i];

                currentSize += new FileInfo(srcFile).Length;
                String filePathFromBase = Path.GetRelativePath(srcBasePath, srcFile);


                State.SetState(new State.StateStatus()
                {
                    Name = backup.BackupEnvironment.Name,
                    Running = true,
                    Status = new State.Status()
                    {
                        FileNumber = sourceFiles.Length,
                        FileSize = size,
                        Progression = (float)((float)i / sourceFiles.Length * 100.0),
                        FileLeft = sourceFiles.Length - i,
                        SizeLeft = size - currentSize,
                        CurrentSourceFile = srcFile,
                        DestinationFile = Path.Join(destBasePath, filePathFromBase)
                    }
                });

                long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                int encryptionTime = 0;
                if ((new List<String>() { ".txt" }).Contains(new FileInfo(srcFile).Extension))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                    ProcessStartInfo cryptoSoftInfo = new ProcessStartInfo("CryptoSoft.exe");
                    cryptoSoftInfo.UseShellExecute = true;
                    cryptoSoftInfo.ArgumentList.Add(new FileInfo(srcFile).FullName);
                    cryptoSoftInfo.ArgumentList.Add(new FileInfo(Path.Join(destBasePath, filePathFromBase)).FullName);
                    Process cryptoSoft = Process.Start(cryptoSoftInfo);
                    cryptoSoft.WaitForExit();
                    encryptionTime = cryptoSoft.ExitCode;
                    //Process  = Process.Start();
                }
                else
                {
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                        File.Copy(Path.Join(srcBasePath, filePathFromBase), Path.Join(destBasePath, filePathFromBase), true);
                    }
                    catch {msbefore = -1;}
                }

                long TransferTime = msbefore == -1 ? -1 : DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore;

                OnFileTransfer?.Invoke(this, new FileTransferEvent(Backup,new FileInfo(srcFile), new FileInfo(Path.Join(destBasePath, filePathFromBase)), TransferTime, encryptionTime));
            }
        }
    }
}
