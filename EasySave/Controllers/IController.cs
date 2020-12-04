using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Controllers
{
    public interface IController
    {
        public void Start();
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment);
        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment);
        public void RunBackup(Backup backup);
        public void RunBackupMultiple(List<Backup> backups);
        public void RestoreBackup(Backup backup);
        public void SetCryptedExtensions(string[] extensions);
        public void SetBlockingProcesses(string[] processes);
    }
}
