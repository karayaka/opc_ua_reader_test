using Newtonsoft.Json;
using opc_ua_reader_test.Models;
using opc_ua_reader_test.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opc_ua_reader_test.views
{
    public partial class JobInfoForm : Form
    {
        public JobInfoForm()
        {
            InitializeComponent();
        }
        List<JobInfoModel> jobInfo = new List<JobInfoModel>();
        public void rederJobınfo() {

            var objs = OpcReaderRepository.Instance.CallMethodts(
                    opcUrl,
                    "ns=2;s=History",
                    "ns=2;s=History.GetJobInfo",
                    jobInfoGuid
                );
            jobInfo = JsonConvert.DeserializeObject<List<JobInfoModel>>(objs[0].ToString());

        }


    }
}
