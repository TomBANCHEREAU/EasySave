using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class Backup
    {
        #region public
        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => {};
        public DateTime ExecutionDate { get => executionDate; }
        public String DestinationDirectory { get => destinationDir; }
        public BackupEnvironment BackupEnvironment { get => backupEnvironment; }
        public BackupStrategy BackupStrategy { get => backupStrategy; }


        internal Backup(BackupEnvironment backupEnvironment,BackupStrategy backupStrategy)
        {
            this.backupEnvironment = backupEnvironment;
            this.backupStrategy = backupStrategy;
            backupStrategy.Backup = this;
            backupStrategy.OnFileTransfer += onFileTransfer;
        }
        #endregion



        #region PrivateAndInternal

        private void onFileTransfer(Object a, FileTransferEvent f) => OnFileTransfer?.Invoke(this, f);
        private DateTime executionDate;
        private String destinationDir;
        private BackupEnvironment backupEnvironment;
        private BackupStrategy backupStrategy;

        internal Backup(BackupEnvironment backupEnvironment, BackupStrategy backupStrategy, string destinationDirectory, DateTime dateTime) : this(backupEnvironment, backupStrategy)
        {
            this.destinationDir = destinationDirectory;
            this.executionDate = dateTime;
        }

        internal void Execute()
        {
            if (this.destinationDir != null)
                throw new Exception();
            this.executionDate = DateTime.Now;
            this.destinationDir = Path.Join(this.BackupEnvironment.DestinationDirectory,this.ExecutionDate.ToString().Replace('/','-').Replace(':','-') + "-" + this.executionDate.Millisecond);
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
        #endregion
    }
}
