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
    public partial class Reports_Page : Form
    {
        public Reports_Page()
        {
            InitializeComponent();
        }


        private void Sales_Report_Click(object sender, EventArgs e)
        {
            Sales_Report_Choose_Date g = new Sales_Report_Choose_Date();
            g.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }

        private void Reports_Page_Load(object sender, EventArgs e)
        {

        }

        private void JobOrderReport_Click(object sender, EventArgs e)
        {
            Job_Order_ChooseDate g = new Job_Order_ChooseDate();
            g.Show();
            this.Hide();
        }

        private void StockInReport_Click(object sender, EventArgs e)
        {
            Stock_In_Choose_Date g = new Stock_In_Choose_Date();
            g.Show();
            this.Hide();
        }

        private void StockOutReport_Click(object sender, EventArgs e)
        {
            Stock_Out_Choose_Date g = new Stock_Out_Choose_Date();
            g.Show();
            this.Hide();
        }
    }
}
