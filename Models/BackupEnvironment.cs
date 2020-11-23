using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class BackupEnvironment
    {
        #region Name
        private String name = "default";
        public String Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentException("Name cannot be empty");
                if (value.Contains('|'))
                    throw new ArgumentException("Name cannot contain '|'");
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

        internal void Restore(Backup backup)
        {
            backup.Restore();
            save();
        }

        internal void Execute(Backup backup)
        {
            backup.Execute();
            save();
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
            if (backup.BackupEnvironment != this)
                throw new ArgumentException("A backup cannot be added to another backup environment");
            this.backups.Add(backup);
            if (backup.BackupStrategy is FullBackupStrategy)
                this.fullBackups.Add(backup);
            save();
        }

        internal void LoadFromFile()
        {
            if (File.Exists(Path.Join(this.destinationDirectory, "./backups.easysave")))
            {
                foreach (String l in File.ReadAllLines(Path.Join(this.destinationDirectory, "./backups.easysave")))
                {
                    try
                    {
                        String[] data = l.Split('|');
                        if (data.Length < 3)
                            throw new Exception("Invalid line");
                        IBackupStrategy s;
                        switch (data[0])
                        {
                            case "Full": s = new FullBackupStrategy(); break;
                            case "Diff":
                                Backup fb = fullBackups.Find((backup)=>backup.DestinationDirectory== data[3]);
                                if (fb == null)
                                    throw new Exception("A full backup cant be found");
                                s = new DifferentialBackupStrategy(fb); 
                            break;
                            default: throw new Exception("Unknowned backup type");
                        }
                        Backup b = new Backup(this,s);
                        b.DestinationDirectory = data[1];
                        b.ExecutionDate = DateTime.Parse(data[2]);
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
            /*if (!File.Exists(Path.Join(this.destinationDirectory, "./backups.easysave")))
                File.Create(Path.Join(this.destinationDirectory, "./backups.easysave"));*/
            List<String> fileContent = new List<String>();
            foreach (Backup backup in backups)
            {
                fileContent.Add(backup.BackupStrategy.Name.Substring(0, 4) + "|" +
                    backup.DestinationDirectory + "|" +
                    backup.ExecutionDate.ToString() +
                    (backup.BackupStrategy.Name.Substring(0, 4).Equals("Diff") ? "|" + ((DifferentialBackupStrategy)backup.BackupStrategy).FullBackup.DestinationDirectory : ""));
            }
            File.WriteAllLines(Path.Join(this.destinationDirectory, "./backups.easysave"), fileContent);
        }
    }
}
