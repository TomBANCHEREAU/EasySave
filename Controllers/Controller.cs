using EasySave.Languages;
using EasySave.Models;
using EasySave.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Controllers
{
    class Controller : IController
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
            try
            {
                Language.LoadLanguage(File.ReadAllText("./lang")) ;
            }
            catch
            {
                Language.LoadLanguage("en");
            }
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
    }
}
