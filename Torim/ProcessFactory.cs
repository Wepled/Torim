using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class ProcessFactory
    {
        private int _sequenceNumber = 0;


        public Process CreateProcess(string processInitializerType, string processInitializerId, string processType, string processAction)
        {
            _sequenceNumber++;
            string processId = processType + "_" + processInitializerType + "_" + _sequenceNumber;
            return new Process(processId, processInitializerType, processInitializerId, processType, processAction);
        }
    }
}
