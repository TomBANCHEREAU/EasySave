using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EasySave.Models
{
    public class Model : IModel
    {
        public event EventHandler<FileTransferEvent> OnFileTransfer;
        public event EventHandler<IReadOnlyList<BackupEnvironment.BackupEnvironmentState>> OnEnvironmentStateChange = State.getInstance().OnEnvironmentStateChange;

        public String[] CryptedExtensions { get => (cryptedExtensions == null) ? new String[0] : cryptedExtensions; }
        public String[] BlockingProcesses { get => (blockingProcesses == null) ? new String[0] : blockingProcesses; }
        public String[] HighPriorityExtensions { get => (highPriorityExtensions == null) ? new String[0] : highPriorityExtensions; }
        //public String[] BackupEnvironments { get => (highPriorityExtensions == null) ? new String[0] : highPriorityExtensions; }
        public long KoLimit { get => koLimit; }


        private String[] cryptedExtensions;
        private String[] blockingProcesses;
        private String[] highPriorityExtensions;
        private List<BackupEnvironment> backupEnvironments;
        private long koLimit;

        private void onFileTransfer(Object a, FileTransferEvent f) => OnFileTransfer?.Invoke(this, f);
        private void onEnvironmentStateChange(Object a, BackupEnvironment.BackupEnvironmentState f)
        {
            List<BackupEnvironment.BackupEnvironmentState> states = new List<BackupEnvironment.BackupEnvironmentState>();
            foreach (BackupEnvironment env in backupEnvironments)
                states.Add(env.currentState);
            OnEnvironmentStateChange?.Invoke(this, states);
        } 




        #region BackupEnvironment
        List<BackupEnvironment> BackupEnvironments
        {
            get
            {
                if (backupEnvironments == null)
                    throw new InvalidOperationException("Model need to be started before doing anything");
                return backupEnvironments;
            }
        }
        public void AddBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            if (BackupEnvironments.FindAll((be) => be.Name == backupEnvironment.Name).Count > 0)
                throw new ArgumentException("This environment name is already used");
            if (!BackupEnvironments.Contains(backupEnvironment))
            {
                BackupEnvironments.Add(backupEnvironment);
                backupEnvironment.Model = this;
                backupEnvironment.OnFileTransfer += onFileTransfer;
                backupEnvironment.OnStateChange += onEnvironmentStateChange;
                onEnvironmentStateChange(this,null);
                SaveSettings();
            }
        }

        public Boolean DeleteBackupEnvironment(BackupEnvironment backupEnvironment)
        {
            if (BackupEnvironments.Contains(backupEnvironment))
            {
                backupEnvironment.OnFileTransfer -= onFileTransfer;
                BackupEnvironments.Remove(backupEnvironment);
                SaveSettings();
                backupEnvironment.OnStateChange -= onEnvironmentStateChange;
                onEnvironmentStateChange(this, null);
                return true;
            }
            return false;
        }

        public IReadOnlyList<BackupEnvironment> GetBackupEnvironments()
        {
            return BackupEnvironments.AsReadOnly();
        }
        #endregion

        public Task<Backup> RestoreBackup(Backup backup)
        {
            if (!this.BackupEnvironments.Contains(backup.BackupEnvironment))
                throw new ArgumentException("The backup environment need to be registered before running a backup");
            return backup.BackupEnvironment.Restore(backup);

        }

        public Task<Backup> RunBackup(BackupEnvironment backupEnvironment, BackupType type)
        {
            return backupEnvironment.RunBackup(type);
        }

        public void Start()
        {
            if (this.backupEnvironments == null)
            {
                this.OnFileTransfer += Logger.getInstance().OnFileTransfert;
                this.backupEnvironments = new List<BackupEnvironment>();
                if (File.Exists("./settings.json"))
                {
                    try
                    {
                        SettingsJSON settingsJSON = JsonConvert.DeserializeObject<SettingsJSON>(File.ReadAllText("./settings.json"));

                        cryptedExtensions = settingsJSON.CryptedExtensions;
                        blockingProcesses = settingsJSON.BlockingProcesses;
                        highPriorityExtensions = settingsJSON.HighPriorityExtensions;
                        koLimit = settingsJSON.KoLimit;
                        foreach (SettingsJSON.SettingsEnvironmentJSON backupEnvironments in settingsJSON.Environments)
                        {
                            try
                            {
                                BackupEnvironment backupEnvironment = new BackupEnvironment(
                                    backupEnvironments.Name,
                                    backupEnvironments.SourceDirectory,
                                    backupEnvironments.DestinationDirectory
                                );
                                AddBackupEnvironment(backupEnvironment);
                                backupEnvironment.LoadFromFile();
                            }catch{}
                        }
                    }
                    catch{}
                }
                SaveSettings();
            }
            else
                throw new InvalidOperationException("Model has already been started");
        }

        private void SaveSettings()
        {
            if (this.backupEnvironments != null)
            {
                SettingsJSON settings = new SettingsJSON();
                settings.CryptedExtensions = CryptedExtensions;
                settings.BlockingProcesses = BlockingProcesses;
                settings.HighPriorityExtensions = HighPriorityExtensions;
                settings.KoLimit = KoLimit;
                List<SettingsJSON.SettingsEnvironmentJSON> backupEnvironmentDatas = new List<SettingsJSON.SettingsEnvironmentJSON>();
                foreach (BackupEnvironment backupEnvironment in backupEnvironments)
                {
                    SettingsJSON.SettingsEnvironmentJSON env = new SettingsJSON.SettingsEnvironmentJSON();
                    env.Name = backupEnvironment.Name;
                    env.SourceDirectory = backupEnvironment.SourceDirectory;
                    env.DestinationDirectory = backupEnvironment.DestinationDirectory;
                    backupEnvironmentDatas.Add(env);
                }
                settings.Environments = backupEnvironmentDatas.ToArray();
                File.WriteAllText("./settings.json", JsonConvert.SerializeObject(settings, Formatting.Indented));
            }
        }

        public void Stop()
        {
            SaveSettings();
        }

        public void SetCryptedExtensions(String[] extensions)
        {
            cryptedExtensions = extensions;
            SaveSettings();
        }

        public void SetBlockingProcesses(String[] processes)
        {
            blockingProcesses = processes;
            SaveSettings();
        }

        public void SetHighPriorityExtensions(String[] extensions)
        {
            highPriorityExtensions = extensions;
            SaveSettings();
        }
        public void SetKoLimit(long koLimit)
        {
            this.koLimit = koLimit;
            SaveSettings();
        }

        public void PauseBackup(Backup backup)
        {
            if (backupEnvironments.Contains(backup.BackupEnvironment))
                backup.Pause();
        }

        public void ResumeBackup(Backup backup)
        {
            if (backupEnvironments.Contains(backup.BackupEnvironment))
                backup.Resume();
        }

        public void CancelBackup(Backup backup)
        {
            if (this.BackupEnvironments.Contains(backup.BackupEnvironment))
                backup.BackupEnvironment.Cancel(backup);
        }

        class SettingsJSON
        {
            public String[] CryptedExtensions;
            public String[] BlockingProcesses;
            public String[] HighPriorityExtensions;
            public long KoLimit;
            public SettingsEnvironmentJSON[] Environments;
            public class SettingsEnvironmentJSON
            {
                public String Name;
                public String SourceDirectory;
                public String DestinationDirectory;
            }
        }
    }
}
