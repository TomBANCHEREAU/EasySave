using EasySave.Models;
using EasySave.Views;
using System;
using System.Collections.Generic;
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
            this.model.Start();
            this.view.SetModel(model);
            this.view.Start();
        }

        public bool AddBackupEnvironment()
        {
            return this.model.AddBackupEnvironment();
        }

        public bool DeleteBackupEnvironment()
        {
            return this.model.DeleteBackupEnvironment();
        }

        public bool RestoreBackup()
        {
            return this.model.RestoreBackup();
        }

        public bool RunBackup()
        {
            return this.model.RunBackup();
        }
    }
}
