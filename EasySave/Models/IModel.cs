﻿using System;
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
        public Backup RunBackup(BackupEnvironment backupEnvironment,BackupType type);
        public void RestoreBackup(Backup backup);
        public void SetCryptedExtensions(String[] extensions);
        public void SetBlockingProcesses(String[] processes);
        public void SetHighPriorityExtensions(String[] extensions);
    }
}
