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
    public partial class Job_Order_Report : Form
    {
        public Job_Order_Report()
        {
            InitializeComponent();
        }

        private void Job_Order_Report_Load(object sender, EventArgs e)
        {
            Job_Order_PrintReport ob = new Job_Order_PrintReport();
            ob.SetParameterValue("fromdate", Job_Order_ChooseDate.datey);
            ob.SetParameterValue("todate", Job_Order_ChooseDate.datez);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
