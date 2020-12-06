using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class DifferentialBackupStrategy : BackupStrategy
    {

        public readonly Backup FullBackup;
        public String SavedDirectory { get => FullBackup.DestinationDirectory; }

        public DifferentialBackupStrategy(Backup fullBackup) : base("Differential")
        {
            FullBackup = fullBackup;
        }
        protected override void Execute()
        {
            String[] sourceFiles = Directory.GetFiles(SourceDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true });

            // Saving new and edited files
            List<String> fileToCopy = new List<String>();
            foreach (String sourceFile in sourceFiles)
            {
                String filePathFromBase = Path.GetRelativePath(SourceDirectory, sourceFile);
                String savedFile = Path.Join(SavedDirectory, filePathFromBase);
                if (!File.Exists(savedFile) || new FileInfo(savedFile).LastWriteTimeUtc.CompareTo(new FileInfo(sourceFile).LastWriteTimeUtc) < 0)
                    fileToCopy.Add(sourceFile);
            }
            CopyFiles(fileToCopy.ToArray(),SourceDirectory,DestinationDirectory);

            // Saving Deleted files
            List<String> deletedFileContent = new List<string>();
            foreach (String savedFile in Directory.EnumerateFiles(SavedDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(SavedDirectory, savedFile);
                String srcFile = Path.Join(SourceDirectory, filePathFromBase);
                if (!File.Exists(srcFile))
                    deletedFileContent.Add(filePathFromBase);
            }
            File.WriteAllLines(Path.Join(DestinationDirectory, "./.easysave"), deletedFileContent);
        }

        protected override void Restore()
        {
            FullBackup.Restore();
            Directory.CreateDirectory(DestinationDirectory);


            // Creating new and edited files
            List<String> fileToCopy = new List<String>();
            foreach (String destFile in Directory.EnumerateFiles(DestinationDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(DestinationDirectory, destFile);
                if (!filePathFromBase.Equals(".easysave"))
                    fileToCopy.Add(destFile);
            }
            CopyFiles(fileToCopy.ToArray(), DestinationDirectory, SourceDirectory);

            // Deleting deleted files
            if (File.Exists(Path.Join(DestinationDirectory, "./.easysave")))
            {
                foreach (String filePathFromBase in File.ReadAllLines(Path.Join(DestinationDirectory, "./.easysave")))
                    File.Delete(Path.Join(SourceDirectory, filePathFromBase));
            }
        }


    }
}
