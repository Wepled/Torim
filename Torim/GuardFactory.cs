using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class GuardFactory
    {
        private int _sequenceNumber = 0;
        ProcessFactory processFactory = new ProcessFactory();


        public Guard CreateGuard()
        {
            _sequenceNumber++;
            return new Guard("Guard_" + _sequenceNumber, processFactory);
        }
    }
}
