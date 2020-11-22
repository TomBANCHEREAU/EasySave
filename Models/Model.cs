using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    class Model : IModel
    {
        private List<BackupEnvironment> backupEnvironments;

        public List<BackupEnvironment> BackupEnvironments
        {
            get {
                if(backupEnvironments!=null)
                    return backupEnvironments;
                else
                    throw new InvalidOperationException("Model need to be started doing anything");
            }
        }

        public void AddBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            if (BackupEnvironments.Count >= 5)
                throw new Exception("No more backup environments can be added");
            else
                BackupEnvironments.Add(backupEnvironment);
        }

        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            return BackupEnvironments.Remove(backupEnvironment);
        }

        public IReadOnlyList<object> GetBackupEnvironments()
        {
            throw new NotImplementedException();
        }

        public void RestoreBackup()
        {
            throw new NotImplementedException();
        }

        public void RunBackup()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (this.backupEnvironments==null)
                this.backupEnvironments = new List<BackupEnvironment>();
            else
                throw new InvalidOperationException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
