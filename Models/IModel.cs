using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    interface IModel : IReadOnlyModel
    {
        public void Start();
        public void Stop();
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment);
        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment);
        public void RunBackup();
        public void RestoreBackup();
    }
}
