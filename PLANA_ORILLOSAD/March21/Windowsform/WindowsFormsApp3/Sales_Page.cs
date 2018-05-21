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
    public partial class Sales_Page : Form
    {
        public Sales_Page()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }

        private void Create_Link_Click(object sender, EventArgs e)
        {
            Sales_Create g=new Sales_Create();
            g.Show();
            this.Hide();
        }

        private void View_All_Click(object sender, EventArgs e)
        {
            Sales_List g = new Sales_List();
            g.Show();
            this.Hide();
        }
    }
}
