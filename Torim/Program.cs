using System;

namespace Process_vault101
{
    class Program
    {
        
        static void Main(string[] args)
        {

            GuardFactory guardFactory = new GuardFactory();
            Guard guard1 = guardFactory.CreateGuard();
            Guard guard2 = guardFactory.CreateGuard();

            WandererFactory wandererFactory = new WandererFactory();
            Wanderer wanderer1 = wandererFactory.CreateWanderer();
            Wanderer wanderer2 = wandererFactory.CreateWanderer();

            guard1.OpenDoor();
            guard2.OpenDoor();
            guard2.CloseDoor();
            guard2.OpenDoor();
            wanderer1.CloseDoor();
            wanderer2.CloseDoor();
        }
    }
}
