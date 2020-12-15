using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public interface IReadOnlyModel
    {
        public event EventHandler<IReadOnlyList<BackupEnvironment.BackupEnvironmentState>> OnEnvironmentStateChange;
        public event EventHandler<FileTransferEvent> OnFileTransfer;
        public String[] CryptedExtensions { get; }
        public String[] BlockingProcesses { get; }
        public String[] HighPriorityExtensions { get; }
        public long KoLimit { get; }
        public IReadOnlyList<BackupEnvironment> GetBackupEnvironments();
    }
}
