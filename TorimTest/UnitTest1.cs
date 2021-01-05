using Microsoft.VisualStudio.TestTools.UnitTesting;
using Process_vault101;

namespace TorimTest
{
    [TestClass]
    public class UnitTest1
    {
        private VaultDoor VaultDoor = new VaultDoor();
        GuardFactory guardFactory = new GuardFactory();
        WandererFactory wandererFactory = new WandererFactory();
        private ProcessFactory processFactory = new ProcessFactory();

        [TestMethod]
        public void GuardID_Test()
        {
            Guard guard1 = guardFactory.CreateGuard();
            Guard guard2 = guardFactory.CreateGuard();
            Assert.AreEqual("Guard_1", guard1.id);
            Assert.AreEqual("Guard_2", guard2.id);
        }
        
        [TestMethod]
        public void WandererID_Test()
        {
            Wanderer wanderer1 = wandererFactory.CreateWanderer();
            Wanderer wanderer2 = wandererFactory.CreateWanderer();
            Assert.AreEqual("Wanderer_1", wanderer1.id);
            Assert.AreEqual("Wanderer_2", wanderer2.id);
        }

        [TestMethod]
        public void VaultDoor_Open_Test()
        {
            Assert.IsTrue(VaultDoor.Open());
        }
        [TestMethod]
        public void VaultDoor_Close_Test()
        {
            VaultDoor.Open();
            Assert.IsTrue(VaultDoor.Close());
        }
        [TestMethod]
        public void VaultDoor_Lock_Test()
        {
            Assert.IsTrue(VaultDoor.Lock());
        }
        [TestMethod]
        public void VaultDoor_Unlock_Test()
        {
            VaultDoor.Lock();
            Assert.IsTrue(VaultDoor.Unlock());
        }
        [TestMethod]
        public void VaultDoor_Open_Double_Test()
        {
            VaultDoor.Open();
            Assert.IsFalse(VaultDoor.Open());
        }
        [TestMethod]
        public void VaultDoor_Close_Double_Test()
        {
            VaultDoor.Open();
            VaultDoor.Close();
            Assert.IsFalse(VaultDoor.Close());
        }
        [TestMethod]
        public void VaultDoor_Lock_Double_Test()
        {
            VaultDoor.Lock();
            Assert.IsFalse(VaultDoor.Lock());
        }
        [TestMethod]
        public void VaultDoor_Unlock_Double_Test()
        {
            VaultDoor.Lock();
            VaultDoor.Unlock();
            Assert.IsFalse(VaultDoor.Unlock());
        }
        [TestMethod]
        public void Process_Create_Test()
        {
            Process process = processFactory.CreateProcess("PrInTest", "PrInIdTestovich", "PrTyTest", "PrATest");
            Process testProcess =
                new Process("PrTyTest_PrInTest_1", "PrInTest", "PrInIdTestovich", "PrTyTest", "PrATest");
            
            Assert.AreEqual(process.ToString(),
                testProcess.ToString());
        }
    }
}
