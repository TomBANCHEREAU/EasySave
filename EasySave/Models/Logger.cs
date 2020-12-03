using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class Logger
    {
        private const String logFilePath = "./backup.json";
        private static Logger logger;
        private List<Object> logs;
        private static Logger LoggerInstance
        {
            get
            {
                if (logger == null)
                    logger = new Logger();
                return logger;
            }
        }
        internal static Logger getInstance() => LoggerInstance;
        private Logger()
        {
            if (File.Exists(logFilePath))
                try{ logs = JsonConvert.DeserializeObject<List<Object>>(File.ReadAllText(logFilePath)); }
                catch{}
            if (logs == null)
                logs = new List<object>();
        }
        internal void OnFileTransfert(object sender, FileTransferEvent transferEvent)
        {
            lock(logger)
            {
                logs.Add(new { 
                    TransferDate = transferEvent.TransferDate,
                    EnvironmentName = transferEvent.BackupEnvironment.Name,
                    SourceFile = transferEvent.SourceFile,
                    DestinationFile = transferEvent.DestinationFile,
                    FileSize = transferEvent.FileSize,
                    TransferTime = transferEvent.TransferTime,
                    EncryptionTime = transferEvent.EncryptionTime
                });
                File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
            }
        }
    }
}
