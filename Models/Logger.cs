using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class Logger
    {
        private const String logFilePath = "./backup.log";
        private static Logger logger;
        private List<Object> logs;
        private Logger()
        {
            if (File.Exists(logFilePath))
            {
                try
                {
                    logs = JsonConvert.DeserializeObject<List<Object>>(File.ReadAllText(logFilePath));
                }
                catch (Exception)
                {
                }
            }
            if (logs == null)
            {
                logs = new List<object>();
            }
        }

        public static void Log(String name,String src,String dest,long size,long ms)
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            logger.log(name, src, dest, size, ms);
        }
        private void log(String name, String src, String dest, long size, long ms)
        {
            logs.Add(new { TransfertDate = DateTime.Now.ToString() ,EnvironmentName = name, SourceFile = src, DestinationFile = dest, FileSize = size, TeansfertTime = ms+"ms" });
            File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
        }
    }
}
