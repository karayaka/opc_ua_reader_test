using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Models
{
    public class RunInfoModel
    {
        public int ID { get; set; }
        public Guid JobGuid { get; set; }

        public int PartId { get; set; }
        public int PartReferenceId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrderInfo { get; set; }
        public string UserInfo1 { get; set; }
        public string UserInfo2 { get; set; }
        public string UserInfo3 { get; set; }
    }
}
