using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp3
{
    public partial class Sales_Receipt : Form
    {
        
        public Sales_Receipt(string p)
        {
            InitializeComponent();
        }

        private void Sales_Receipt_Load(object sender, EventArgs e)
        {
            Sales_Create g = new Sales_Create();
            g.Hide();
            SalesReceiptPrint ob = new SalesReceiptPrint();
            ob.SetParameterValue("stock_order_id", Sales_Create.salid);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();        
            
        }
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void Sales_Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sales_Page g = new Sales_Page();
            g.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Sales_Page g = new Sales_Page();
            g.Show();
            this.Hide();
        }
    }
}
