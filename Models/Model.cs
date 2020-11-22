using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public class Model : IModel
    {


        #region BackupEnvironment
        private List<BackupEnvironment> backupEnvironments;

        List<BackupEnvironment> BackupEnvironments
        {
            get
            {
                if (backupEnvironments != null)
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

        public IReadOnlyList<BackupEnvironment> GetBackupEnvironments()
        {
            return BackupEnvironments.AsReadOnly();
        }
        #endregion



        public void RestoreBackup(Backup backup)
        {
            throw new NotImplementedException();
        }

        public void RunBackup(Backup backup)
        {
            if (!this.BackupEnvironments.Contains(backup.BackupEnvironment))
                throw new ArgumentException("The backup environment need to be registered before running a backup");
            backup.BackupEnvironment.AddBackup(backup);
            backup.Execute();
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
