using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class Backup
    {
        private DateTime executionDate;

        public DateTime ExecutionDate
        {
            get { return executionDate; }
        }
        private String destinationDir;

        public String DestinationDirectory
        {
            get { return destinationDir; }
        }

        private BackupEnvironment backupEnvironment;

        public BackupEnvironment BackupEnvironment
        {
            get { return backupEnvironment; }
        }
        private IBackupStrategy backupStrategy;

        public IBackupStrategy BackupStrategy
        {
            get { return backupStrategy; }
        }

        public Backup(BackupEnvironment backupEnvironment,IBackupStrategy backupStrategy)
        {
            this.backupEnvironment = backupEnvironment;
            this.backupStrategy = backupStrategy;
        }
        public void Execute()
        {
            if (this.destinationDir != null)
                throw new Exception();
            this.executionDate = DateTime.Now;
            this.destinationDir = Path.Join(this.BackupEnvironment.DestinationDirectory,this.ExecutionDate.ToString().Replace('/','-').Replace(':','-'));
            backupStrategy.Execute(this);
        }
        public void Restore()
        {
            backupStrategy.Restore(this);
        }
    }
}
