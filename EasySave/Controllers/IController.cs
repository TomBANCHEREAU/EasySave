﻿using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasySave.Controllers
{
    public interface IController
    {
        public void Start();
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment);
        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment);
        public Task<Backup> RunBackup(BackupEnvironment backupEnvironment,BackupType type);
        public void RestoreBackup(Backup backup);
        public void PauseBackup(Backup backup);
        public void ResumeBackup(Backup backup);
        public void CancelBackup(Backup backup);
        public void SetCryptedExtensions(String[] extensions);
        public void SetBlockingProcesses(String[] processes);
        public void SetHighPriorityExtensions(String[] extensions);
        public void SetKoLimit(long kolimit);
    }
}
