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
    public partial class Stock_Out_Choose_Date : Form
    {
        public static DateTime datey, datez;
        public Stock_Out_Choose_Date()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Reports_Page g = new Reports_Page();
            g.Show();
            this.Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            datey = fromd.Value;
            datez = tod.Value;
            new Stock_In_Report().ShowDialog();
        }
    }
}
