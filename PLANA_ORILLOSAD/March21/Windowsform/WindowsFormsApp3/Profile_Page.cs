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
    public partial class Profile_Page : Form
    {
        public Profile_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void back_button_Click_1(object sender, EventArgs e)
        {

            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }

        private void Customer_Link_Click(object sender, EventArgs e)
        {
            Profile_Customer g = new Profile_Customer();
            g.Show();
            this.Hide();
        }

        private void Vehicle_Link_Click(object sender, EventArgs e)
        {
            Profile_Vehicle g = new Profile_Vehicle();
            g.Show();
            this.Hide();
        }

        private void Employee_Link_Click(object sender, EventArgs e)
        {
            Profile_Employee g = new Profile_Employee();
            g.Show();
            this.Hide();
        }

        private void Services_Link_Click(object sender, EventArgs e)
        {
            Profile_Service g = new Profile_Service();
            g.Show();
            this.Hide();
        }

        private void Supplier_Link_Click(object sender, EventArgs e)
        {
            Profile_Supplier g = new Profile_Supplier();
            g.Show();
            this.Hide();
        }

        private void Items_Link_Click(object sender, EventArgs e)
        {
            Profile_Item g = new Profile_Item();
            g.Show();
            this.Hide();
        }
    }
}
