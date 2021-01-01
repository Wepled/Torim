using System;
using System.Collections.Generic;
using System.Text;

namespace Process_vault101
{
    public interface IProcess
    {
        public string id { get; set; }
        public string initializerType { get; set; }
        public string initializerId { get; set; }
        public string type { get; set; }
        public string action { get; set; }
    }
}
