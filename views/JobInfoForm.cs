using DevExpress.Xpo.Exceptions;
using Newtonsoft.Json;
using opc_ua_reader_test.configs;
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
                    configs.configs.opcIP,
                    "ns=2;s=History",
                    "ns=2;s=History.GetJobInfo",
                    new Guid(txtJobGuid.Text)
                );
            var jobInfos = JsonConvert.DeserializeObject<List<JobInfoModel>>(objs[0].ToString());

            foreach (var item in jobInfos)
            {
                if (!jobInfo.Any(t => t.JobGuid == item.JobGuid))
                    jobInfo.Add(item);
            }
            fillDataGrid();
        }


        public void fillDataGrid()
        {
            var bindingList = new BindingList<JobInfoModel>(jobInfo);

            var binds = new BindingSource(bindingList, null);

            grdJobGuid.DataSource = binds;
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            rederJobınfo();
        }
    }
}
