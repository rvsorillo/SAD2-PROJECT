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
    public partial class Stock_in_List : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string sid;
        public Stock_in_List()
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
            cmd.CommandText = "select item_name, stock_in_quantity, stock_in_date, delivery_date from stock_in_details sd, stock_in s, item i where sd.stock_in_id_fk=s.stock_in_id and sd.item_id_stock_in_fk=i.item_id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            stock_in_view.DataSource = dt;
            Conn.Close();
            stock_in_view.Columns[0].HeaderText = "Item Name";
            stock_in_view.Columns[1].HeaderText = "Quantity";
            stock_in_view.Columns[2].HeaderText = "Stock in Date";
            stock_in_view.Columns[3].HeaderText = "Delivery Date";
        }
        private void Stock_in_List_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void stock_in_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Stock_in g = new Stock_in();
            g.Show();
            this.Hide();
        }
    }
}
