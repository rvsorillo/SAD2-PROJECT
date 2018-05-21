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
    public partial class Stock_Out_Report : Form
    {
        public Stock_Out_Report()
        {
            InitializeComponent();
        }

        private void Stock_Out_Report_Load(object sender, EventArgs e)
        {
            
            Stock_Out_PrintReport ob = new Stock_Out_PrintReport();
            ob.SetParameterValue("fromdate", Stock_Out_Choose_Date.datey);
            ob.SetParameterValue("todate", Stock_Out_Choose_Date.datez);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
