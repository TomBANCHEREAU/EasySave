using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class Model : IModel
    {

        public event EventHandler<FileTransferEvent> OnFileTransfer;
        private void onFileTransfer(Object a, FileTransferEvent f) => OnFileTransfer?.Invoke(this, f);

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
            BackupEnvironments.Add(backupEnvironment);
            backupEnvironment.OnFileTransfer += onFileTransfer;
            State.SetState(new State.StateStatus() { Name = backupEnvironment.Name, Running = false });
            saveBackupEnvironments();
        }

        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            backupEnvironment.OnFileTransfer -= onFileTransfer;
            Boolean b = BackupEnvironments.Remove(backupEnvironment);
            saveBackupEnvironments();
            State.RemoveState(backupEnvironment.Name);
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
                this.OnFileTransfer += Logger.getInstance().OnFileTransfert;
                this.backupEnvironments = new List<BackupEnvironment>();
                if (File.Exists("./environment.json"))
                {
                    List<BackupEnvironment.BackupEnvironmentData> backupEnvironmentDatas = JsonConvert.DeserializeObject<List<BackupEnvironment.BackupEnvironmentData>>(File.ReadAllText("./environment.json"));
                    foreach (BackupEnvironment.BackupEnvironmentData backupEnvironmentData in backupEnvironmentDatas)
                    {
                        try
                        {
                            BackupEnvironment backupEnvironment = new BackupEnvironment(backupEnvironmentData.Name,backupEnvironmentData.SourceDirectory,backupEnvironmentData.DestinationDirectory);
                            AddBackupEnvironment(backupEnvironment);
                            backupEnvironment.LoadFromFile();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadLine();
                        }
                    }
                }
            }
            else
                throw new InvalidOperationException("Model has already been started");
        }

        private void saveBackupEnvironments()
        {
            if (this.backupEnvironments != null)
            {
                List<BackupEnvironment.BackupEnvironmentData> backupEnvironmentDatas = new List<BackupEnvironment.BackupEnvironmentData>();
                foreach (BackupEnvironment backupEnvironment in backupEnvironments)
                {
                    BackupEnvironment.BackupEnvironmentData env = new BackupEnvironment.BackupEnvironmentData();
                    env.Name = backupEnvironment.Name;
                    env.SourceDirectory = backupEnvironment.SourceDirectory;
                    env.DestinationDirectory = backupEnvironment.DestinationDirectory;
                    backupEnvironmentDatas.Add(env);
                }
                File.WriteAllText("./environment.json", JsonConvert.SerializeObject(backupEnvironmentDatas, Formatting.Indented));
            }
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
