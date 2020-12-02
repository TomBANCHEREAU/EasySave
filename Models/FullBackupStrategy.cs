﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class FullBackupStrategy : BackupStrategy
    {
        public new string Name => "Full";

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
