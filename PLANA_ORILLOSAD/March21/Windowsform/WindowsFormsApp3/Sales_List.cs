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
    public partial class Sales_List : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string sid;

        public Sales_List()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }
        public void disp_all()
        {
            //display view all
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT so.stock_order_id, concat(cust_fname,' ',cust_lname) as custfull, so.stock_order_date, total_amount_stock_order from stock_order so, customer c where so.cust_id_stock_order_fk=c.cust_id order by so.stock_order_date desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            view_all_view.DataSource = dt;
            Conn.Close();
            view_all_view.Columns[0].HeaderText = "Stock Order ID";
            view_all_view.Columns[1].HeaderText = "Customer Name";
            view_all_view.Columns[2].HeaderText = "Transaction Date";
            view_all_view.Columns[3].HeaderText = "Total";
        }

        public void disp_sales()
        {
            //display view all
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT so.stock_order_id, concat(cust_fname,' ',cust_lname) as custfull, so.stock_order_date, total_amount_stock_order from stock_order so,  customer c where so.cust_id_stock_order_fk=c.cust_id and c.cust_fname!='Walk-in' order by so.stock_order_date desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            sales_view.DataSource = dt;
            Conn.Close();
            sales_view.Columns[0].HeaderText = "Stock Order ID";
            sales_view.Columns[1].HeaderText = "Customer Name";
            sales_view.Columns[2].HeaderText = "Transaction Date";
            sales_view.Columns[3].HeaderText = "Total";
        }

        public void disp_walk_in()
        {
            //display view all
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT so.stock_order_id, concat(cust_fname,' ',cust_lname) as custfull, so.stock_order_date, total_amount_stock_order from stock_order so, customer c where so.cust_id_stock_order_fk=c.cust_id and c.cust_fname='Walk-in' order by so.stock_order_date desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            walk_in_view.DataSource = dt;
            Conn.Close();
            walk_in_view.Columns[0].HeaderText = "Stock Order ID";
            walk_in_view.Columns[1].HeaderText = "Customer Name";
            walk_in_view.Columns[2].HeaderText = "Transaction Date";
            walk_in_view.Columns[3].HeaderText = "Total";
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Sales_Create g = new Sales_Create();
            g.Show();
            this.Hide();
        }

        private void Sales_List_Load(object sender, EventArgs e)
        {
            disp_all();
            disp_walk_in();
            disp_sales();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }

        private void view_all_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = view_all_view.Rows[e.RowIndex].Cells["stock_order_id"].Value.ToString();
                if (view_all_view.Rows.Count > 0)
                {
                    Sales_Details g = new Sales_Details();
                    sid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void sales_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                txtid.Text = walk_in_view.Rows[e.RowIndex].Cells["stock_order_id"].Value.ToString();
                if (view_all_view.Rows.Count > 0)
                {
                    Sales_Details g = new Sales_Details();
                    sid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void walk_in_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                txtid.Text = walk_in_view.Rows[e.RowIndex].Cells["stock_order_id"].Value.ToString();
                if (view_all_view.Rows.Count > 0)
                {
                    Sales_Details g = new Sales_Details();
                    sid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }
    }
}
