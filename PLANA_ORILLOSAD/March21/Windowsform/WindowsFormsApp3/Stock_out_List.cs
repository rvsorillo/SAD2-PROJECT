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
    public partial class Stock_out_List : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string sid;
        public Stock_out_List()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }

        public void disp_data()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select i.item_name, sd.stock_out_quantity, s.stock_out_date, sd.stock_out_type from stock_out_details sd, stock_out s, item i  where sd.stock_out_id_fk=s.stock_out_id and sd.item_id_stock_out_fk=i.item_id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            stock_out_view.DataSource = dt;
            Conn.Close();
            stock_out_view.Columns[0].HeaderText = "Item Name";
            stock_out_view.Columns[0].HeaderText = "Quantity";
            stock_out_view.Columns[1].HeaderText = "Stock out Date";
            stock_out_view.Columns[1].HeaderText = "Stock out Type";

        }

        private void Stock_out_List_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }
    }
}
