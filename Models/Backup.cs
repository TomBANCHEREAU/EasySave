using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public class Backup
    {
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
            backupStrategy.Execute(this);
        }
        public void Restore()
        {
            backupStrategy.Restore(this);
        }
    }
}
