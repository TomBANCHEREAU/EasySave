using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class FullBackupStrategy : BackupStrategy
    {
        public FullBackupStrategy() : base("Full")
        {

        }

        protected override void Execute()
        {
            Directory.CreateDirectory(DestinationDirectory);
            String[] sourceFiles = Directory.GetFiles(SourceDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            this.CopyFiles(sourceFiles, SourceDirectory, DestinationDirectory);
        }

        protected override void Restore()
        {
            String[] sourceFiles = Directory.GetFiles(DestinationDirectory, "*", new EnumerationOptions() { RecurseSubdirectories = true });
            this.CopyFiles(sourceFiles, DestinationDirectory, SourceDirectory);
        }
    }
}
