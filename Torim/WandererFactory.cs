using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class WandererFactory
    {
        private int _sequenceNumber = 0;
        ProcessFactory processFactory = new ProcessFactory();

        public Wanderer CreateWanderer()
        {
            _sequenceNumber++;
            return new Wanderer("Wanderer_" + _sequenceNumber, processFactory);
        }
    }
}
