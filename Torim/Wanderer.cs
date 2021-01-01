using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class Wanderer : IPerson
    {

        public readonly string type = "Wanderer";

        public string id;

        private ProcessFactory processFactory;

        public Wanderer(string wandererId, ProcessFactory pf)
        {
            id = wandererId;
            processFactory = pf;
        }


        ProcessTypeManager processTypeManager = ProcessTypeManager.GetInstance();

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
