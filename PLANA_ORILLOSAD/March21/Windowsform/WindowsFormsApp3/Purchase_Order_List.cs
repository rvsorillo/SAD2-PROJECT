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
    public partial class Purchase_Order_List : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string pid;

        public Purchase_Order_List()
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
            cmd.CommandText = "SELECT purch_order_id, purch_order_date, supplier_name, purch_status from purchase_order p, supplier s where p.purch_suppid = s.supplier_id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            purchase_order_view.DataSource = dt;
            Conn.Close();
            purchase_order_view.Columns[0].HeaderText = "Purchase Order ID";
            purchase_order_view.Columns[1].HeaderText = "Date of Transaction";
            purchase_order_view.Columns[2].HeaderText = "Supplier Name";
            purchase_order_view.Columns[3].HeaderText = "Delivery Status";
        }

        public void disp_pending()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT purch_order_id, purch_order_date, supplier_name, purch_status from purchase_order p, supplier s where p.purch_suppid = s.supplier_id and purch_status='Pending'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            pending_view.DataSource = dt;
            Conn.Close();
            pending_view.Columns[0].HeaderText = "Purchase Order ID";
            pending_view.Columns[1].HeaderText = "Date of Transaction";
            pending_view.Columns[2].HeaderText = "Supplier Name";
            pending_view.Columns[3].HeaderText = "Delivery Status";
        }

        public void disp_completed()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT purch_order_id, purch_order_date, supplier_name, purch_status from purchase_order p, supplier s where p.purch_suppid = s.supplier_id and purch_status='Complete'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            complete_view.DataSource = dt;
            Conn.Close();
            complete_view.Columns[0].HeaderText = "Purchase Order ID";
            complete_view.Columns[1].HeaderText = "Date of Transaction";
            complete_view.Columns[2].HeaderText = "Supplier Name";
            complete_view.Columns[3].HeaderText = "Delivery Status";
        }


        private void Purchase_Order_List_Load(object sender, EventArgs e)
        {
            disp_data();
            disp_pending();
            disp_completed();
            foreach (DataGridViewRow row in purchase_order_view.Rows)
            {
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
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Purchase_Order g = new Purchase_Order();
            g.Show();
            this.Hide();
        }


        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            pid = purch_id.Text;
            g.Show();
            this.Hide();
        }

        private void pending_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                purch_id.Text = pending_view.Rows[e.RowIndex].Cells["purch_order_id"].Value.ToString();
                if (purchase_order_view.Rows.Count > 0)
                {
                    Purchase_Order_Details g = new Purchase_Order_Details();
                    pid = purch_id.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void complete_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                purch_id.Text = complete_view.Rows[e.RowIndex].Cells["purch_order_id"].Value.ToString();
                if (purchase_order_view.Rows.Count > 0)
                {
                    Purchase_Order_Details g = new Purchase_Order_Details();
                    pid = purch_id.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void purchase_order_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                purch_id.Text = purchase_order_view.Rows[e.RowIndex].Cells["purch_order_id"].Value.ToString();
                if (purchase_order_view.Rows.Count > 0)
                {
                    Purchase_Order_Details g = new Purchase_Order_Details();
                    pid = purch_id.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }
    }
}
