using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public interface IModel : IReadOnlyModel
    {
        public void Start();
        public void Stop();
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment);
        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment);
        public void RunBackup(Backup backup);
        public void RestoreBackup(Backup backup);
        public void setCryptedExtentions(String[] extentions);
    }
}
