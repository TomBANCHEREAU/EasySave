using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Models
{
    public interface IReadOnlyModel
    {
        public event EventHandler<FileTransferEvent> OnFileTransfert;
        public IReadOnlyList<BackupEnvironment> GetBackupEnvironments();
    }
}
