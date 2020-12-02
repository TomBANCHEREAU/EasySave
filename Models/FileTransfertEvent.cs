using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    public class FileTransferEvent
    {
        public readonly DateTime TransfertDate;
        public readonly Backup Backup;
        public readonly FileInfo SourceFileInfo;
        public readonly FileInfo DestinationFileInfo;
        public readonly long TransferTime;
        public readonly long EncryptionTime;
        public BackupEnvironment BackupEnvironment { get => Backup.BackupEnvironment; }
        public String SourceFile { get => SourceFileInfo.FullName; }
        public String DestinationFile { get => DestinationFileInfo.FullName; }
        public long FileSize { get => SourceFileInfo.Length; }
        public String EnvironmentName { get => BackupEnvironment.Name; }
        public FileTransferEvent(Backup Backup, FileInfo SourceFileInfo, FileInfo DestinationFileInfo, long TransferTime, long EncryptionTime)
        {
            this.TransfertDate = DateTime.Now;
            this.Backup = Backup;
            this.SourceFileInfo = SourceFileInfo;
            this.DestinationFileInfo = DestinationFileInfo;
            this.TransferTime = TransferTime;
            this.EncryptionTime = EncryptionTime;
        }
    }
}
