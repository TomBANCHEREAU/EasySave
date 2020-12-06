using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class Backup
    {
        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => {};
        private void onFileTransfer(Object a, FileTransferEvent f) => OnFileTransfer?.Invoke(this, f);
        private DateTime executionDate;

        public DateTime ExecutionDate
        {
            get { return executionDate; }
            internal set => executionDate = value;
        }
        private String destinationDir;

        public String DestinationDirectory
        {
            get { return destinationDir; }
            internal set => destinationDir = value;
        }

        private BackupEnvironment backupEnvironment;

        public BackupEnvironment BackupEnvironment
        {
            get { return backupEnvironment; }
        }
        private BackupStrategy backupStrategy;

        public BackupStrategy BackupStrategy
        {
            get { return backupStrategy; }
        }

        public Backup(BackupEnvironment backupEnvironment,BackupStrategy backupStrategy)
        {
            this.backupEnvironment = backupEnvironment;
            this.backupStrategy = backupStrategy;
            backupStrategy.Backup = this;
            backupStrategy.OnFileTransfer += onFileTransfer;
        }
        internal void Execute()
        {
            if (this.destinationDir != null)
                throw new Exception();
            this.executionDate = DateTime.Now;
            this.destinationDir = Path.Join(this.BackupEnvironment.DestinationDirectory,this.ExecutionDate.ToString().Replace('/','-').Replace(':','-'));
            backupStrategy.RunExecute();
        }
        internal void Restore()
        {
            backupStrategy.RunRestore();
        }
        internal class BackupData
        {
            public String BackupType;
            public String ExecutionDate;
            public String DestinationDirectory;
            public String FullBackupDirectory;
        }
    }
}
