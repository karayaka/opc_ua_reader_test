﻿using System;
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
    public partial class RunPartHistoryForm : Form
    {
        public RunPartHistoryForm()
        {
            InitializeComponent();
        }
        bool satrtData=false;
        private void btnReadData_Click(object sender, EventArgs e)
        {
            var date = startDate.Value;
        }

        public void readData()
        {

        }
    }
}
