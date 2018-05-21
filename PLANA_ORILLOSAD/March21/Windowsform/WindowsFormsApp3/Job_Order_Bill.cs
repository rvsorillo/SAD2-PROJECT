using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Job_Order_Bill : Form
    {
        public Job_Order_Bill(int p)
        {
            InitializeComponent();
        }

        private void Job_Order_Bill_Load(object sender, EventArgs e)
        {
            Job_Order_Labor g = new Job_Order_Labor();
            g.Hide();
            Job_Order_Print_Bill ob = new Job_Order_Print_Bill();
            ob.SetParameterValue("joborderid", Job_Order_Details.jobid);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
