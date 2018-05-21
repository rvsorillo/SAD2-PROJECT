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
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            Sales_PrintReport ob = new Sales_PrintReport();
            ob.SetParameterValue("fromdate", Sales_Report_Choose_Date.from);
            ob.SetParameterValue("todate", Sales_Report_Choose_Date.to);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
