﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class Model : IModel
    {
        private String[] cryptedExtentions;

        public String[] CryptedExtentions
        {
            get {
                if (cryptedExtentions == null)
                    return new String[0];
                return cryptedExtentions;

            }
        }

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
            if (!BackupEnvironments.Contains(backupEnvironment))
            {
                BackupEnvironments.Add(backupEnvironment);
                backupEnvironment.Model = this;
                backupEnvironment.OnFileTransfer += onFileTransfer;
                State.SetState(new State.StateStatus() { Name = backupEnvironment.Name, Running = false });
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
                State.RemoveState(backupEnvironment.Name);
                return true;
            }
            return false;
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
                if (File.Exists("./settings.json"))
                {
                    try
                    {
                        SettingsJSON settingsJSON = JsonConvert.DeserializeObject<SettingsJSON>(File.ReadAllText("./settings.json"));

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
                    }catch{}
                }
            }
            else
                throw new InvalidOperationException("Model has already been started");
        }

        private void SaveSettings()
        {
            if (this.backupEnvironments != null)
            {
                SettingsJSON settings = new SettingsJSON();
                settings.CryptedExtentions = CryptedExtentions;
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

        public void setCryptedExtentions(string[] extentions)
        {
            cryptedExtentions = extentions;
            SaveSettings();
        }
        class SettingsJSON
        {
            public String[] CryptedExtentions;
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
