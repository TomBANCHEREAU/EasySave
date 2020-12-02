using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public abstract class BackupStrategy
    {
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
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                    File.Copy(Path.Join(srcBasePath, filePathFromBase), Path.Join(destBasePath, filePathFromBase), true);
                }
                catch (Exception ex)
                {
                    msbefore = -1;
                }
                Logger.Log(backup.BackupEnvironment.Name, Path.Join(srcBasePath, filePathFromBase), Path.Join(destBasePath, filePathFromBase), new FileInfo(Path.Join(srcBasePath, filePathFromBase)).Length,
                    msbefore == -1 ? -1 : DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore);

            }
        }
    }
}
