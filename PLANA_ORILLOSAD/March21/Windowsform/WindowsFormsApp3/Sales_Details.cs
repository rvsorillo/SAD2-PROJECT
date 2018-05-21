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
    public partial class Sales_Details : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        Sales_List g;

        public Sales_Details()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        private void Sales_Details_Load(object sender, EventArgs e)
        {
            sales_id.Text = Sales_List.sid;
            fillsalesdetails();
            fillcustbox();
            filltime();
            //total
            foreach (DataGridViewRow row in selected_sales_item_view.Rows)
            {
                if (row.IsNewRow) continue;

                int sum = 0;
                for (int i = 0; i < selected_sales_item_view.Rows.Count; i++)
                {

                    sum += Convert.ToInt32(selected_sales_item_view.Rows[i].Cells[6].Value);

                }
                total_text.Text = Convert.ToString(sum);

            }
        }
        public void fillsalesdetails()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct sd.stock_order_details_id, i.item_name, i.item_brand, i.item_measurement, i.item_selling_price, sd.stock_order_item_quantity, total_stock_order_details from stock_order_details sd, item i, stock_order so where so.stock_order_id=sd.stock_order_id_fk and i.item_id=sd.item_id_stock_order_fk and so.stock_order_id='" + Sales_List.sid + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            selected_sales_item_view.DataSource = dt;
            Conn.Close();
            selected_sales_item_view.Columns[0].HeaderText = "Sales Details ID";
            selected_sales_item_view.Columns[0].Visible = false;
            selected_sales_item_view.Columns[1].HeaderText = "Item Name";
            selected_sales_item_view.Columns[2].HeaderText = "Brand";
            selected_sales_item_view.Columns[3].HeaderText = "Measurement";
            selected_sales_item_view.Columns[4].HeaderText = "Price";
            selected_sales_item_view.Columns[5].HeaderText = "Quantity";
            selected_sales_item_view.Columns[6].HeaderText = "Subtotal";

            Conn.Close();
        }
        public void fillcustbox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select c.cust_id, c.cust_fname, c.cust_lname from customer c, stock_order s where s.cust_id_stock_order_fk=c.cust_id and s.stock_order_id='" + Sales_List.sid + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cust_name_input.Text = sdr.GetString("cust_fname") + " " + sdr.GetString("cust_lname");
                cust_id.Text = sdr.GetString("cust_id");
            }

            Conn.Close();
        }
        public void filltime()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select stock_order_date from stock_order where stock_order_id='" + Sales_List.sid + "'";
            DataTable dt = new DataTable();
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                date_input.Value = sdr.GetDateTime("stock_order_date");
            }
            Conn.Close();
        }


        private void back_button_Click_1(object sender, EventArgs e)
        {
            Sales_List g = new Sales_List();
            g.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
