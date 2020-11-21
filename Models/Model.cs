using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    class Model : IModel
    {
        public bool AddBackupEnvironment()
        {
            throw new NotImplementedException();
        }

        public bool DeleteBackupEnvironment()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<object> GetBackupEnvironments()
        {
            throw new NotImplementedException();
        }

        public bool RestoreBackup()
        {
            throw new NotImplementedException();
        }

        public bool RunBackup()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            // throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
