using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class DifferentialBackup : Backup
    {

        public readonly Backup FullBackup;
        public String SavedDirectory { get => FullBackup.DestinationDirectory; }

        public DifferentialBackup(BackupEnvironment backupEnvironment,Backup fullBackup) : base(backupEnvironment, BackupType.DIFFERENTIAL)
        {
            FullBackup = fullBackup;
        }


        internal DifferentialBackup(BackupEnvironment backupEnvironment, String destinationDirectory, DateTime dateTime, Backup fullBackup) : base(backupEnvironment, BackupType.DIFFERENTIAL, destinationDirectory, dateTime)
        {
            FullBackup = fullBackup;
        }

        protected override void RunExecute()
        {
            Directory.CreateDirectory(DestinationDirectory);
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
            List<String> deletedFileContent = new List<String>();
            foreach (String savedFile in Directory.EnumerateFiles(SavedDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(SavedDirectory, savedFile);
                String srcFile = Path.Join(SourceDirectory, filePathFromBase);
                if (!File.Exists(srcFile))
                    deletedFileContent.Add(filePathFromBase);
            }
            File.WriteAllLines(Path.Join(DestinationDirectory, "./.easysave"), deletedFileContent);
        }

        protected override void RunRestore()
        {
            //FullBackup.Restore();
            Directory.CreateDirectory(DestinationDirectory);
            Directory.CreateDirectory(FullBackup.DestinationDirectory);


            List<String> AllPathFormBase = new List<String>();

            foreach (String FullSavedFile in Directory.EnumerateFiles(FullBackup.DestinationDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(FullBackup.DestinationDirectory, FullSavedFile);
                if (!AllPathFormBase.Contains(filePathFromBase))
                    AllPathFormBase.Add(filePathFromBase);
            }

            foreach (String DiffSavedFile in Directory.EnumerateFiles(DestinationDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true }))
            {
                String filePathFromBase = Path.GetRelativePath(DestinationDirectory, DiffSavedFile);
                if (!AllPathFormBase.Contains(filePathFromBase))
                    AllPathFormBase.Add(filePathFromBase);
            }

            if (File.Exists(Path.Join(DestinationDirectory, "./.easysave")))
            {
                foreach (String filePathFromBase in File.ReadAllLines(Path.Join(DestinationDirectory, "./.easysave")))
                    AllPathFormBase.Remove(filePathFromBase);
            }

            foreach (String filePathFromBase in AllPathFormBase)
            {
                String FullSavedFile = Path.Join(FullBackup.DestinationDirectory, filePathFromBase);
                String DiffSavedFile = Path.Join(DestinationDirectory,filePathFromBase);
                String DestFile = Path.Join(SourceDirectory, filePathFromBase);
                if (File.Exists(DiffSavedFile))
                    AddFileTranfer(new FileTransferEvent(this,new FileInfo(DiffSavedFile),new FileInfo(DestFile)));
                else
                    AddFileTranfer(new FileTransferEvent(this, new FileInfo(FullSavedFile), new FileInfo(DestFile)));
            }

        }


    }
}
