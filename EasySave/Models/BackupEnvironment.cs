﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class BackupEnvironment
    {
        private Boolean isRunning;

        public Boolean IsRunning { get => isRunning; }


        public event EventHandler<FileTransferEvent> OnFileTransfer = (Object s, FileTransferEvent b) => {};
        private void onFileTransfer(Object a, FileTransferEvent f)=>OnFileTransfer(a, f);
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

        }
        public BackupEnvironment(String _name,String src,String dest)
        {
            Name = _name;
            SourceDirectory = src;
            DestinationDirectory = dest;
        }
        internal void AddBackup(Backup backup)
        {
            if (!backups.Contains(backup)) {
                backups.Add(backup);
                if (backup.BackupStrategy is FullBackupStrategy)
                    this.fullBackups.Add(backup);
                backup.OnFileTransfer += onFileTransfer;
                save();
            }
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
                        BackupStrategy s;
                        switch (backupData.BackupType)
                        {
                            case "Full": s = new FullBackupStrategy(); break;
                            case "Differential":
                                Backup fb = fullBackups.Find((backup)=>backup.DestinationDirectory== backupData.FullBackupDirectory);
                                if (fb == null)
                                    throw new Exception("A full backup cant be found");
                                s = new DifferentialBackupStrategy(fb); 
                            break;
                            default: throw new Exception("Unknowned backup type");
                        }
                        Backup b = new Backup(this,s, backupData.DestinationDirectory, DateTime.Parse(backupData.ExecutionDate));
                        AddBackup(b);
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
                data.BackupType = backup.BackupStrategy.Name;
                data.DestinationDirectory = backup.DestinationDirectory;
                data.ExecutionDate = backup.ExecutionDate.ToString();
                data.FullBackupDirectory = backup.BackupStrategy is DifferentialBackupStrategy ? ((DifferentialBackupStrategy)backup.BackupStrategy).FullBackup.DestinationDirectory : "";
                backupDatas.Add(data);
            }
            File.WriteAllText(Path.Join(this.destinationDirectory, "./backups.json"), JsonConvert.SerializeObject(backupDatas, Formatting.Indented));
        }
        internal void Restore(Backup backup)
        {
            lock (this)
            {
                if (backups.Contains(backup) && !IsRunning)
                {
                    isRunning = true;
                    backup.Restore();
                    State.SetState(new State.StateStatus() { Name = Name, Running = false });
                    save();
                    isRunning = false;
                }
            }
        }

        internal Backup RunBackup(BackupType type)
        {
            lock (this)
            {
                if (IsRunning)
                    throw new Exception("A backup is already running on this environment");
                foreach (String processName in model.BlockingProcesses)
                {
                    if (Process.GetProcessesByName(processName).Length != 0)
                        throw new Exception();
                }
                Backup backup;
                switch (type)
                {
                    case BackupType.FULL:
                        backup = new Backup(this,new FullBackupStrategy());
                        fullBackups.Add(backup);
                        break;
                    case BackupType.DIFFERENTIAL:
                        if (fullBackups.Count == 0)
                            throw new Exception("No full backup has been done");
                        Backup lastFull = fullBackups[fullBackups.Count - 1];
                        backup = new Backup(this, new DifferentialBackupStrategy(lastFull));
                        break;
                    default:
                        throw new Exception("");
                }
                AddBackup(backup);
                if (backups.Contains(backup) && !IsRunning)
                {
                    isRunning = true;
                    backup.Execute();
                    State.SetState(new State.StateStatus() { Name = Name, Running = false });
                    save();
                    isRunning = false;
                }
                return backup;
            }
        }
    }
}
