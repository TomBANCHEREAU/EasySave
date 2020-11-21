using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    interface IModel : IReadOnlyModel
    {
        public void Start();
        public void Stop();
        public Boolean AddBackupEnvironment();
        public Boolean DeleteBackupEnvironment();
        public Boolean RunBackup();
        public Boolean RestoreBackup();
    }
}
