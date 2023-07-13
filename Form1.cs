using opc_ua_reader_test.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opc_ua_reader_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJobInfoForm_Click(object sender, EventArgs e)
        {
            var form = new JobInfoForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form=new RunPartHistoryForm();
            form.Show();
        }
    }
}
