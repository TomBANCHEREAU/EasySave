using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class DifferentialBackupStrategy : IBackupStrategy
    {
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

        public string Name => "Differential";

        public DifferentialBackupStrategy(Backup fullBackup)
        {
            FullBackup = fullBackup;
        }
        public void Execute(Backup backup)
        {
            Directory.CreateDirectory(backup.DestinationDirectory);
            copyContent(backup.BackupEnvironment.SourceDirectory, backup.DestinationDirectory, fullBackup.DestinationDirectory);
        }

        public void Restore(Backup backup)
        {
            throw new NotImplementedException();
        }
        private void copyContent(String srcBasePath, String destBasePath,String fullBackupBasePath)
        {

            // Saving new and edited files
            foreach (String srcFile in Directory.EnumerateFiles(srcBasePath, "*",new EnumerationOptions(){ RecurseSubdirectories=true }))
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

            // Saving Deleted files
            foreach (String savedFile in Directory.EnumerateFiles(fullBackupBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(fullBackupBasePath, savedFile);
                String srcFile = Path.Join(srcBasePath, filePathFromBase);

                if (!File.Exists(srcFile))
                {
                    File.AppendAllLines(Path.Join(destBasePath, "./.easysave"),new String[1]{ filePathFromBase });
                }
            }
        }
    }
}
