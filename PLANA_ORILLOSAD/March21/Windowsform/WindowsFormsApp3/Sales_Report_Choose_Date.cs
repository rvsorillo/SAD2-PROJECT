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
    public partial class Sales_Report_Choose_Date : Form
    {
        public Sales_Report_Choose_Date()
        {
            InitializeComponent();
        }
        public static DateTime from, to;
        private void generate_Click(object sender, EventArgs e)
        {
            from = fromd.Value;
            to = tod.Value;
            new Sales_Report().ShowDialog();
        }

        

        private void back_button_Click(object sender, EventArgs e)
        {
            Reports_Page g = new Reports_Page();
            g.Show();
            this.Hide();
        }

        private void Sales_Report_Choose_Month_Load(object sender, EventArgs e)
        {
           
        }
    }
}
