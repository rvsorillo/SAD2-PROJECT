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
    public partial class Stock_In_Report : Form
    {
        public Stock_In_Report()
        {
            InitializeComponent();
        }

        private void Stock_In_Report_Load(object sender, EventArgs e)
        {
            Stock_In_PrintReport ob = new Stock_In_PrintReport();
            ob.SetParameterValue("fromdate", Stock_In_Choose_Date.datey);
            ob.SetParameterValue("todate", Stock_In_Choose_Date.datez);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
