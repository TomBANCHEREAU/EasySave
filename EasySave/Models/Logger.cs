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
        internal void OnFileTransfert(object sender, FileTransferEvent transfertEvent)
        {
            lock(logger)
            {
                logs.Add(new { 
                    TransfertDate = transfertEvent.TransfertDate,
                    EnvironmentName = transfertEvent.BackupEnvironment.Name,
                    SourceFile = transfertEvent.SourceFile,
                    DestinationFile = transfertEvent.DestinationFile,
                    FileSize = transfertEvent.FileSize,
                    TransferTime = transfertEvent.TransferTime,
                    EncryptionTime = transfertEvent.EncryptionTime
                });
                File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
            }
        }
    }
}
