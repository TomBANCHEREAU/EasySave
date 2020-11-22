using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Controllers
{
    interface IController
    {
        public void Start();
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment);
        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment);
        public void RunBackup(Backup backup);
        public void RestoreBackup(Backup backup);
    }
}
