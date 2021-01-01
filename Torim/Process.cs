using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public class Process : IProcess
    {
        public string id { get; set; }
        public string initializerType { get; set; }
        public string initializerId { get; set; }
        public string type { get; set; }
        public string action { get; set; }


        enum processResult
        {
            Unknown,
            Success,
            Failure
        }

        processResult result = processResult.Unknown;


        public Process(string processId, string processInitializerType, string processInitializerId, string processType, string processAction)
        {
            id = processId;
            initializerType = processInitializerType;
            initializerId = processInitializerId;
            type = processType;
            action = processAction;
            Log();
        }

        public void Log()
        {
            Console.WriteLine("Process ID: " + id + ", Initialyzer: " + initializerType + " " + initializerId + ", process of type: " + type + " to perform action: " + action + " with result: " + result);
        }

        public void SetSuccess()
        {
            result = processResult.Success;
        }

        public void SetFailure()
        {
            result = processResult.Failure;
        }
    }
}
