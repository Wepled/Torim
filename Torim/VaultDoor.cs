using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class VaultDoor
    {
        enum DoorState
        {
            Opened,
            ClosedUnlocked,
            ClosedLocked
        }

        DoorState State = DoorState.ClosedUnlocked;

        public bool Open()
        {
            if (State != DoorState.ClosedUnlocked)
            {
                Console.WriteLine("Unable to open Vault door");
                return false;
            }
            else
            {
                State = DoorState.Opened;
                Console.WriteLine("Warning! Vault door open!");
                return true;
            }

        }

        public bool Close()
        {
            if (State != DoorState.Opened)
            {
                Console.WriteLine("Vault door already closed");
                return false;
            }
            else
            {
                State = DoorState.ClosedUnlocked;
                Console.WriteLine("Vault door closed");
                return true;
            }
        }

        public bool Lock()
        {
            if (State == DoorState.Opened)
            {
                Console.WriteLine("Cannot lock open door");
                return false;
            }
            else if (State == DoorState.ClosedLocked)
            {
                Console.WriteLine("Vault door already locked");
                return false;
            }
            else
            {
                Console.WriteLine("Vault door successfully locked");
                State = DoorState.ClosedLocked;
                return true;
            }
        }

        public bool Unlock()
        {
            if (State != DoorState.ClosedLocked)
            {
                Console.WriteLine("Vault door already unlocked");
                return false;
            }
            else
            {
                Console.WriteLine("Vault door unlocked");
                State = DoorState.ClosedUnlocked;
                return true;
            }

        }
    }
}
