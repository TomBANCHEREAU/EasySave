using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Models
{
    class State
    {
        private const String stateFilePath = "./backupState.json";
        private static State state;
        private static Object lockObject = new Object();
        private State()
        {
        }
        internal static State getInstance()
        {
            lock(lockObject){
                if (state == null)
                    state = new State();
                return state;
            }
        }

        internal void OnEnvironmentStateChange(Object a, IReadOnlyList<BackupEnvironment.BackupEnvironmentState> f)
        {
            lock (lockObject)
            {
                File.WriteAllText(stateFilePath, JsonConvert.SerializeObject(f, Formatting.Indented));
            }
        }
    }
}
