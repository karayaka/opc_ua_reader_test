using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Models
{
    public class PlateOperatingDataModel
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public Guid PlateGuid { get; set; }

        public int PlateState { get; set; }

        public double CuttingTime { get; set; }

        public double SystemWaitTime { get; set; }
        public double StopTime { get; set; }

        public bool OperateEvents { get; set; }

        public bool OperateStops { get; set; }

        public bool SystemEvents { get; set; }

        public bool SystemStops { get; set; }

        public bool BreakOffs { get; set; }
    }
}
