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
    public partial class Purchase_Order_Form : Form
    {
        public Purchase_Order_Form(string p)
        {
            InitializeComponent();
        }

        private void Purchase_Order_Form_Load(object sender, EventArgs e)
        {
            Purchase_Order g = new Purchase_Order();
            g.Hide();
            Purchase_Order_FormPrint ob = new Purchase_Order_FormPrint();
            ob.SetParameterValue("purchorderid", Purchase_Order.purid);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();        
        }
    }
}
