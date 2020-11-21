using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Controllers
{
    interface IController
    {
        public void Start();
        public Boolean AddBackupEnvironment();
        public Boolean DeleteBackupEnvironment();
        public Boolean RunBackup();
        public Boolean RestoreBackup();
    }
}
