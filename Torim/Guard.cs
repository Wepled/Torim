using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class Guard : IPerson
    {
        public readonly string type = "Guard";

        public string id;

        private ProcessFactory processFactory;

        public Guard(string guardId, ProcessFactory pf)
        {
            id = guardId;
            processFactory = pf;
        }

        ProcessTypeManager processTypeManager = ProcessTypeManager.GetInstance();
        

        //ProcessTypeManager processTypeManager = new ProcessTypeManager();
        public void OpenDoor()
        {
            Process process = processFactory.CreateProcess(type, id, "DoorProcess", "Open");
            processTypeManager.InitProcessByType(process).Log();
        }

        public void CloseDoor()
        {
            Process process = processFactory.CreateProcess(type, id, "DoorProcess", "Close");
            processTypeManager.InitProcessByType(process).Log();
        }

        public void Lock() 
        {
            Process process = processFactory.CreateProcess(type, id, "DoorProcess", "Lock");
            processTypeManager.InitProcessByType(process).Log();
        }

        public void Unlock()
        {
            Process process = processFactory.CreateProcess(type, id, "DoorProcess", "Unlock");
            processTypeManager.InitProcessByType(process).Log();
        }

    }
}
