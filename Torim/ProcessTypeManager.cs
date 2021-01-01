using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class ProcessTypeManager
    {
        private ProcessTypeManager()
        {

        }

        private static ProcessTypeManager instance;
        public static ProcessTypeManager GetInstance()
        {
            {
                if (instance == null)
                {
                    instance = new ProcessTypeManager();
                }
                return instance;
            }
        }
        DoorProcessManager processManager = new DoorProcessManager();
        public Process InitProcessByType(Process process)
        {
            if (process.type == "DoorProcess")
            {
                processManager.initProcess(process);
            }
            else
            {
                Console.WriteLine("Unknown process type!");
            }
            return process;
        }
    }
}
