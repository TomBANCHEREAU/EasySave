using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class FullBackup : Backup
    {
        internal FullBackup(BackupEnvironment backupEnvironment) : base(backupEnvironment,BackupType.FULL)
        {

        }
        internal FullBackup(BackupEnvironment backupEnvironment, String destinationDirectory, DateTime dateTime) : base(backupEnvironment, BackupType.FULL, destinationDirectory, dateTime)
        {

        }
        protected override void RunExecute()
        {
            Directory.CreateDirectory(DestinationDirectory);
            String[] sourceFiles = Directory.GetFiles(SourceDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            this.CopyFiles(sourceFiles, SourceDirectory, DestinationDirectory);
        }

        protected override void RunRestore()
        {
            String[] sourceFiles = Directory.GetFiles(DestinationDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            this.CopyFiles(sourceFiles, DestinationDirectory, SourceDirectory);
        }
    }
}
