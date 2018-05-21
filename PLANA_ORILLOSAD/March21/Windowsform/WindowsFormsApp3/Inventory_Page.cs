using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp3
{
    public partial class Inventory_Page : Form
    {

        Class1 main;
        MySqlConnection Conn;
        public Inventory_Page()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }

        private void Inventory_Link_Click(object sender, EventArgs e)
        {
            Inventory_List g = new Inventory_List();
            g.Show();
            this.Hide();
        }

        private void Stockin_Link_Click(object sender, EventArgs e)
        {
            Stock_in g = new Stock_in();
            g.Show();
            this.Hide();
        }


        private void Purchase_Order_Link_Click(object sender, EventArgs e)
        {
            Purchase_Order_List g = new Purchase_Order_List();
            g.Show();
            this.Hide();
        }

        private void Stockout_Link_Click(object sender, EventArgs e)
        {
            Stock_out g = new Stock_out();
            g.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Page_Load(object sender, EventArgs e)
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT purch_order_id, purch_order_date, supplier_name, purch_status from purchase_order p, supplier s where p.purch_suppid = s.supplier_id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            purchase_order_view.DataSource = dt;
            Conn.Close();
            for (int a = 0; a < purchase_order_view.Rows.Count; a++)
            {
                if (Convert.ToString(purchase_order_view.Rows[a].Cells[3].Value) == "Complete")
                {

                }
                else
                {
                    Conn.Open();
                    string query2 = "SELECT * FROM purchase_order_details where purch_dstatus='Incomplete' and purch_purchid='" + purchase_order_view.Rows[a].Cells[0].Value + "';";
                    DataTable dt2 = new DataTable();
                    dt2 = main.SELECT_Statement(query2);

                    // if found
                    if (dt2.Rows.Count == 0)
                    {
                        MySqlCommand cmd2 = Conn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "Update purchase_order set purch_status='Complete' where purch_order_id ='" + purchase_order_view.Rows[a].Cells[0].Value + "';";
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                       
                    }
                    Conn.Close();
                }
            }
        }


        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }
    }
}
