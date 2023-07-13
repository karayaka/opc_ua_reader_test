using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Models
{
    public class PlanInfoModel
    {
        public int ID { get; set; }
        public Guid PlanGuid { get; set; }

        public Guid JobGuid { get; set; }

        public string Name { get; set; }

        public string MaterialName { get; set; }

        public string Description { get; set; }

        //public string ArticleInfo { get; set; }

        public string ChargeInfo { get; set; }

        //public string MaterialInfo1 { get; set; }

        //public string MaterialInfo2 { get; set; }

        //public string MaterialInfo3 { get; set; }

        //public string SpacerPlateInfo { get; set; }

        //public string ParameterFile { get; set; }

        public double MaterialSizeX { get; set; }

        public double MaterialSizeY { get; set; }

        public double MaterialThickness { get; set; }

        public double Weight { get; set; }

        public double Waste { get; set; }

        public int TubeProfileType { get; set; }

        public double SizeX { get; set; }

        public double SizeY { get; set; }

        //public double ProfileDimA { get; set; }

        //public double ProfileDimB { get; set; }

        public double ProfileDimC { get; set; }

        public int TotalRuns { get; set; }

        public int TotalParts { get; set; }

        public int PlanState { get; set; }

        public double EstimatedCutTime { get; set; }

        public int MaterialFormatType { get; set; }
    }
}
