using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class DifferentialBackupStrategy : IBackupStrategy
    {
        public string Name => "Differential";

        private Backup fullBackup;

        public Backup FullBackup
        {
            get { return fullBackup; }
            set {
                if (!(value.BackupStrategy is FullBackupStrategy))
                    throw new ArgumentException("The Differential backup strategy need a full backup");
                fullBackup = value; 
            }
        }


        public DifferentialBackupStrategy(Backup fullBackup)
        {
            FullBackup = fullBackup;
        }
        public void Execute(Backup backup)
        {
            Directory.CreateDirectory(backup.DestinationDirectory);

            String srcBasePath = backup.BackupEnvironment.SourceDirectory;
            String destBasePath = backup.DestinationDirectory;
            String fullBackupBasePath = fullBackup.DestinationDirectory;

            // Saving new and edited files
            foreach (String srcFile in Directory.EnumerateFiles(srcBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(srcBasePath, srcFile);
                Console.WriteLine(filePathFromBase);
                String savedFile = Path.Join(fullBackupBasePath, filePathFromBase);
                if (!File.Exists(savedFile) || new FileInfo(savedFile).LastWriteTimeUtc.CompareTo(new FileInfo(srcFile).LastWriteTimeUtc) < 0)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                    File.Copy(srcFile, Path.Join(destBasePath, filePathFromBase), true);
                }
            }

            List<String> fileContent = new List<string>();
            // Saving Deleted files
            foreach (String savedFile in Directory.EnumerateFiles(fullBackupBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(fullBackupBasePath, savedFile);
                String srcFile = Path.Join(srcBasePath, filePathFromBase);
                if (!File.Exists(srcFile))
                {
                    fileContent.Add(filePathFromBase);
                }
            }
            File.WriteAllLines(Path.Join(destBasePath, "./.easysave"),fileContent);

        }

        public void Restore(Backup backup)
        {
            this.fullBackup.Restore();

            Directory.CreateDirectory(backup.DestinationDirectory);

            String srcBasePath = backup.BackupEnvironment.SourceDirectory;
            String destBasePath = backup.DestinationDirectory;

            // Creating new and edited files
            foreach (String destFile in Directory.EnumerateFiles(destBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(destBasePath, destFile);
                Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(srcBasePath, filePathFromBase)));
                File.Copy(destFile, Path.Join(srcBasePath, filePathFromBase), true);
            }

            // Deleting deleted files
            if (File.Exists(Path.Join(destBasePath, "./.easysave")))
            {
                foreach (String filePathFromBase in File.ReadAllLines(Path.Join(destBasePath, "./.easysave")))
                {
                    File.Delete(Path.Join(srcBasePath, filePathFromBase));
                }
            }
        }
    }
}
