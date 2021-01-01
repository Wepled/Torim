using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class DoorProcessManager
    {
        VaultDoor vaultDoor = new VaultDoor();

        
        public Process initProcess(Process process)
        {
            bool result = false;

            if (process.initializerType == "Wanderer")
            {
                if(process.action == "Close")
                {
                    result = vaultDoor.Close();
 
                }
                else
                {
                    Console.WriteLine("Unable to perform action");
                }
            }
            else if (process.initializerType == "Guard")
            {
                if(process.action == "Open")
                {
                    result = vaultDoor.Open();
                    
                }
                if(process.action == "Close")
                {
                    result = vaultDoor.Close();
                   
                }
                if(process.action == "Lock")
                {
                    result = vaultDoor.Lock();
                    
                }
                if(process.action == "Unlock")
                {
                    result = vaultDoor.Unlock();
                   
                }

            }
            if (result == true)
            {
                process.SetSuccess();
            }
            else
            {
                process.SetFailure();
            }
            return process;
        }
    }
}
