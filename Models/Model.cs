using System;
using System.Collections.Generic;
using System.IO;
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
            saveBackupEnvironments();
        }

        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            Boolean b = BackupEnvironments.Remove(backupEnvironment);
            saveBackupEnvironments();
            return b;
        }

        public IReadOnlyList<BackupEnvironment> GetBackupEnvironments()
        {
            return BackupEnvironments.AsReadOnly();
        }
        #endregion



        public void RestoreBackup(Backup backup)
        {
            if (!this.BackupEnvironments.Contains(backup.BackupEnvironment))
                throw new ArgumentException("The backup environment need to be registered before running a backup");
            backup.BackupEnvironment.Restore(backup);

        }

        public void RunBackup(Backup backup)
        {
            if (!this.BackupEnvironments.Contains(backup.BackupEnvironment))
                throw new ArgumentException("The backup environment need to be registered before running a backup");
            backup.BackupEnvironment.AddBackup(backup);
            backup.BackupEnvironment.Execute(backup);
        }

        public void Start()
        {
            if (this.backupEnvironments == null)
            {
                this.backupEnvironments = new List<BackupEnvironment>();
                if (File.Exists("./environment.dat"))
                {
                    /*try
                    {*/
                        foreach (String Line in File.ReadAllLines("./environment.dat"))
                        {
                            String[] data = Line.Split('|');
                            BackupEnvironment n = new BackupEnvironment(data[0], data[1], data[2]);
                            n.LoadFromFile();
                            backupEnvironments.Add(n);
                        }
                    /*}
                    catch (Exception ex)
                    {
                        throw new Exception("An Error has occured during the loading of the environments");
                    }*/
                }
            }
            else
                throw new InvalidOperationException();
        }

        private void saveBackupEnvironments()
        {
            if (this.backupEnvironments != null)
            {
                try
                {
                    File.WriteAllText("./environment.dat", "");
                    foreach (BackupEnvironment backupEnvironment in backupEnvironments)
                    {
                        File.AppendAllLines("./environment.dat", new String[1] { backupEnvironment.Name+"|"+ backupEnvironment.SourceDirectory+"|"+ backupEnvironment.DestinationDirectory});
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
