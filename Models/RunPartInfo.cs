using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Models
{
    public class RunPartInfo
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public Guid JobGuid { get; set; }

        public Guid PlanGuid { get; set; }

        public Guid RunGuid { get; set; }

        public double ActualCutTime { get; set; }

        public double ActualStopTime { get; set; }

        public double ActualWaitTime { get; set; }

        public int PartId { get; set; }

        public int PartRefId { get; set; }

        public int PartNumber { get; set; }

        public int CutState { get; set; }

        public DateTime CutStartTime { get; set; }

        public DateTime CutEndTime { get; set; }

        public int SortState { get; set; }

        public DateTime SortStartTime { get; set; }

        public DateTime SortEndTime { get; set; }

        public int StackAreaType { get; set; }
    }
}
