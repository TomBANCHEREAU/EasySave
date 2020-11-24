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
        private static List<StateStatus> stateObject;
        private State()
        {
            if (File.Exists(stateFilePath))
            {
                stateObject = JsonConvert.DeserializeObject<List<StateStatus>>(File.ReadAllText(stateFilePath));
            }
            else
            {
                stateObject = new List<StateStatus>();
            }
        }
        private static State getInstance()
        {
            if (state == null)
            {
                state = new State();
            }
            return state;
        }

        public static void SetState(StateStatus stateStatus)
        {
            getInstance().setState(stateStatus);
        }
        private void setState(StateStatus stateStatus)
        {
            int index = stateObject.FindIndex(state=>state.Name == stateStatus.Name);
            if (index == -1)
                stateObject.Add(stateStatus);
            else
                stateObject[index] = stateStatus;
            File.WriteAllText(stateFilePath, JsonConvert.SerializeObject(stateObject, Formatting.Indented));
        }

        internal static void RemoveState(string name)
        {
            getInstance().removeState(name);
        }

        private void removeState(string name)
        {
            stateObject.Remove(stateObject.Find(state => state.Name == name));
            File.WriteAllText(stateFilePath, JsonConvert.SerializeObject(stateObject, Formatting.Indented));

        }

        public class StateStatus
        {
            public DateTime Date = DateTime.Now;
            public String Name;
            public Boolean Running;
            public Status Status;
        }
        public class Status
        {
            public long FileNumber;
            public long FileSize;
            public float Progression;
            public long FileLeft;
            public long SizeLeft;
            public String CurrentSourceFile;
            public String DestinationFile;
        }
    }
}
