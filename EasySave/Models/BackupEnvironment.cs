﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EasySave.Models
{
    public class BackupEnvironment
    {
        public Backup runningBackup;
        private Task<Backup> runningBackupTask;
        private Boolean _isRunning;
        private Boolean isRunning
        {
            get => _isRunning;
            set
            {
                if (_isRunning!=value)
                {
                    _isRunning = value;
                    if (!_isRunning)
                        currentState.Status = null;
                    OnStateChange(this, currentState.Clone());
                }
            }
        }

        public Boolean IsRunning { get => isRunning; }


        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => {};
        public event EventHandler<BackupEnvironmentState> OnStateChange = (Object s, BackupEnvironmentState b) => { };
        private void onFileTransfer(Object a, FileTransferEvent f) => OnFileTransfer(a, f);
        private void onBackupStateChange(Object a, Backup.BackupState f) {
            currentState.Status = f;
            OnStateChange(this, currentState.Clone()); 
        }
        internal BackupEnvironmentState currentState;
        private Model model;

        public Model Model
        {
            get { return model; }
            internal set {
                if(model!=null)
                    throw new InvalidOperationException("Model has already been set");
                model = value; 
            }
        }


        #region Name
        private String name = "default";
        public String Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentException("Name cannot be empty");
                currentState.Name = value;
                name = value;
            }
        }
        #endregion
        #region SourceDirectory
        private String sourceDirectory = "";
        public String SourceDirectory
        {
            get { return sourceDirectory; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Source path cannot be empty");
                if (!Directory.Exists(value))
                    throw new ArgumentException("Source directory doesn't exist");
                sourceDirectory = new DirectoryInfo(value).FullName;
            }
        }
        #endregion
        #region DestinationDirectory
        private String destinationDirectory = "";
        public String DestinationDirectory
        {
            get { return destinationDirectory; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Destination path cannot be empty");
                if (!Directory.Exists(value))
                    throw new ArgumentException("Destination directory doesn't exist");
                destinationDirectory = new DirectoryInfo(value).FullName;
            }
        }

        #endregion
        #region Backups
        private List<Backup> backups = new List<Backup>();

        public IReadOnlyList<Backup> Backups
        {
            get { return backups.AsReadOnly(); }
        }
        private List<Backup> fullBackups = new List<Backup>();
        public IReadOnlyList<Backup> FullBackups
        {
            get { 
                return fullBackups.AsReadOnly(); 
            }
        }
        #endregion
        public BackupEnvironment()
        {
            currentState = new BackupEnvironmentState(this);
        }
        public BackupEnvironment(String _name,String src,String dest) : this()
        {
            Name = _name;
            SourceDirectory = src;
            DestinationDirectory = dest;
        }
        private void AddBackup(Backup backup)
        {
            backups.Add(backup);
            if (backup.Type == BackupType.FULL)
                this.fullBackups.Add(backup);
            backup.OnFileTransfer += onFileTransfer;
            save();
        }

        internal void LoadFromFile()
        {
            if (File.Exists(Path.Join(this.destinationDirectory, "./backups.json")))
            {
                List<Backup.BackupData> backupDatas = JsonConvert.DeserializeObject<List<Backup.BackupData>>(File.ReadAllText(Path.Join(this.destinationDirectory, "./backups.json")));
                foreach (Backup.BackupData backupData in backupDatas)
                {
                    try
                    {
                        if (backupData.DestinationDirectory != null)
                        {
                            Backup b;
                            switch (backupData.BackupType)
                            {
                                case BackupType.FULL:
                                     b = new FullBackup(this, backupData.DestinationDirectory, DateTime.Parse(backupData.ExecutionDate));
                                    AddBackup(b);
                                    break;
                                case BackupType.DIFFERENTIAL:
                                    Backup fb = fullBackups.Find((backup) => backup.DestinationDirectory == backupData.FullBackupDirectory);
                                    if (fb == null)
                                        throw new Exception("A full backup cant be found");
                                    b = new DifferentialBackup(this, backupData.DestinationDirectory, DateTime.Parse(backupData.ExecutionDate), fb);
                                    AddBackup(b);
                                    break;
                                default: throw new Exception("Unknowned backup type");
                            }
                            b.done = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error during backup loading :"+ex.Message);
                    }
                }
            }
        }
        internal void save()
        {
            List<Backup.BackupData> backupDatas = new List<Backup.BackupData>();
            foreach (Backup backup in backups)
            {
                Backup.BackupData data = new Backup.BackupData();
                data.BackupType = backup.Type;
                data.DestinationDirectory = backup.DestinationDirectory;
                data.ExecutionDate = backup.ExecutionDate.ToString();
                data.FullBackupDirectory = backup.Type == BackupType.DIFFERENTIAL ? ((DifferentialBackup)backup).FullBackup.DestinationDirectory : "";
                backupDatas.Add(data);
            }
            File.WriteAllText(Path.Join(this.destinationDirectory, "./backups.json"), JsonConvert.SerializeObject(backupDatas, Formatting.Indented));
        }
        internal Task<Backup> Restore(Backup backup)
        {
            lock (this)
            {
                if (backups.Contains(backup) && !IsRunning)
                {
                    runningBackup = backup;
                    isRunning = true;
                    backup.OnStateChange += onBackupStateChange;
                    runningBackupTask = Task<Backup>.Run(() => {
                        backup.Restore();
                        lock (this)
                        {
                            save();
                            isRunning = false;
                            runningBackup = null;
                            backup.OnStateChange -= onBackupStateChange;
                            return backup;
                        }
                    });
                    return runningBackupTask;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        internal Task<Backup> RunBackup(BackupType type)
        {
            lock (this)
            {
                if (IsRunning)
                    throw new Exception("A backup is already running on this environment");
                Backup backup;
                switch (type)
                {
                    case BackupType.FULL:
                        backup = new FullBackup(this);
                        fullBackups.Add(backup);
                        break;
                    case BackupType.DIFFERENTIAL:
                        if (fullBackups.Count == 0)
                            throw new Exception("No full backup has been done");
                        Backup lastFull = fullBackups[fullBackups.Count - 1];
                        backup = new DifferentialBackup(this, lastFull);
                        break;
                    default:
                        throw new Exception("");
                }
                AddBackup(backup);
                backup.OnStateChange += onBackupStateChange;
                runningBackup = backup;
                isRunning = true;
                runningBackupTask = Task<Backup>.Run(() => {
                    backup.Execute();
                    lock(this){
                        isRunning = false;
                        runningBackup = null;
                        backup.OnStateChange -= onBackupStateChange;
                        save();
                        runningBackupTask = null;
                        return backup;
                    }
                });
                return runningBackupTask;
            }
        }

        internal void Cancel(Backup backup)
        {
            if (IsRunning && backups.Contains(backup))
            {
                backup.Cancel();
                //runningBackupTask.Wait();
                if (!backup.done)
                {
                    backups.Remove(backup);
                    if (fullBackups.Contains(backup))
                        fullBackups.Remove(backup);
                }
                save();
            }
        }

        public class BackupEnvironmentState
        {
            public DateTime Date = DateTime.Now;
            public String Name;
            public Boolean Running;
            public Backup.BackupState Status;
            private BackupEnvironment backupEnvironment;
            public BackupEnvironmentState()
            {
            }
            public BackupEnvironmentState(BackupEnvironment backupEnvironment)
            {
                this.backupEnvironment = backupEnvironment;
                this.Name = backupEnvironment.Name;
            }
            public BackupEnvironmentState Clone()
            {
                this.Running = backupEnvironment.isRunning;
                this.Date = DateTime.Now;
                return (BackupEnvironmentState)MemberwiseClone();
            }
        }
    }
}
