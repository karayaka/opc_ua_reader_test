using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Models
{
    public class MachineState
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public bool Error { get; set; }

        public bool DncMode { get; set; }

        public bool ManualMode { get; set; }

        public bool ProcessActive { get; set; }

        public bool StartWork { get; set; }

        public bool WaitContAbort { get; set; }

        public bool WaitMaterialLoaded { get; set; }

        public bool WaitMaterialRemoved { get; set; }

        public bool WaitMaterialUnloaded { get; set; }

        public bool WaitPartsSorted { get; set; }

        public bool WaitOther { get; set; }
    }
}
