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
            String[] sourceFiles = Directory.GetFiles(srcBasePath, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            long size = 0;
            foreach (String srcFile in sourceFiles)
            {
                size += new FileInfo(srcFile).Length;
            }
            long currentSize = 0;
            // Saving new and edited files
            for (int i = 0; i < sourceFiles.Length; i++)
            {
                String srcFile = sourceFiles[i];
                currentSize += new FileInfo(srcFile).Length;
                String filePathFromBase = Path.GetRelativePath(srcBasePath, srcFile);
                String savedFile = Path.Join(fullBackupBasePath, filePathFromBase);
                State.SetState(new State.StateStatus()
                {
                    Name = backup.BackupEnvironment.Name,
                    Running = true,
                    Status = new State.Status()
                    {
                        FileNumber = sourceFiles.Length,
                        FileSize = size,
                        Progression = (float)((float)i / sourceFiles.Length * 100.0),
                        FileLeft = sourceFiles.Length - i,
                        SizeLeft = size - currentSize,
                        CurrentSourceFile = srcFile,
                        DestinationFile = Path.Join(destBasePath, filePathFromBase)
                    }
                });

                if (!File.Exists(savedFile) || new FileInfo(savedFile).LastWriteTimeUtc.CompareTo(new FileInfo(srcFile).LastWriteTimeUtc) < 0)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(destBasePath, filePathFromBase)));
                    long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    File.Copy(srcFile, Path.Join(destBasePath, filePathFromBase), true);
                    Logger.Log(backup.BackupEnvironment.Name, srcFile, Path.Join(destBasePath, filePathFromBase), new FileInfo(srcFile).Length, DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore);

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
                if (!filePathFromBase.Equals(".easysave"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Path.Join(srcBasePath, filePathFromBase)));
                    long msbefore = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    File.Copy(destFile, Path.Join(srcBasePath, filePathFromBase), true);
                    Logger.Log(backup.BackupEnvironment.Name, destFile, Path.Join(srcBasePath, filePathFromBase), new FileInfo(destFile).Length, DateTimeOffset.Now.ToUnixTimeMilliseconds() - msbefore);

                }
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
