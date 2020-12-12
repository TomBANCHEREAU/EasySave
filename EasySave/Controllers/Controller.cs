using EasySave.Models;
using EasySave.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Controllers
{
    public class Controller : IController
    {
        private IModel model;
        private IView view;

        public Controller(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void Start()
        {
            this.model.Start();
            this.view.Start(model,this);
        }

        public void AddBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            this.model.AddBackupEnvironment(backupEnvironment);
        }

        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            return this.model.DeleteBackupEnvironment(backupEnvironment);
        }

        public void RestoreBackup(Backup backup)
        {
            this.model.RestoreBackup(backup);
        }

        public void RunBackup(Backup backup)
        {
            this.model.RunBackup(backup);
        }

        public void SetCryptedExtensions(String[] extensions)
        {
            this.model.SetCryptedExtensions(extensions);
        }

        public void RunMultipleBackup(List<Backup> backups)
        {
            this.model.RunMultipleBackup(backups);
        }

        public void SetBlockingProcesses(String[] processes)
        {
            this.model.SetBlockingProcesses(processes);
        }

        public void SetHighPriorityExtensions(String[] extensions)
        {
            this.model.SetHighPriorityExtensions(extensions);
        }
    }
}
