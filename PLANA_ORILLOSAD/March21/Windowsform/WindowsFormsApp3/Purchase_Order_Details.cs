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
    public partial class Purchase_Order_Details : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Purchase_Order_Details()
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
            cmd.CommandText = "select item_name, purch_finalitemqty, purch_itemqty, purch_dstatus, concat(e.emp_fname,' ',e.emp_lname),(purch_itemqty *item_purchase_price) from item i, purchase_order_details pd, purchase_order po, employee e where pd.purch_itemid=i.item_id and pd.purch_purchid=po.purch_order_id and e.emp_id=pd.purch_reqemployeeid and po.purch_order_id=" + Convert.ToInt32(Purchase_Order_List.pid) + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            purchase_order_view.DataSource = dt;
            Conn.Close();
            purchase_order_view.Columns[0].HeaderText = "Item Name";
            purchase_order_view.Columns[1].HeaderText = "Ordered";
            purchase_order_view.Columns[2].HeaderText = "Undelivered";
            purchase_order_view.Columns[3].HeaderText = "Status";
            purchase_order_view.Columns[4].HeaderText = "Requested By";
            purchase_order_view.Columns[5].HeaderText = "Balance";
        }
        private void Purchase_Order_Details_Load(object sender, EventArgs e)
        {
            txtid.Text = Purchase_Order_List.pid;
            disp_data();
            foreach (DataGridViewRow row in purchase_order_view.Rows)
            {
                int sum = 0;
                int countrow = purchase_order_view.Rows.Count;
                for (int i = 0; i < countrow; i++)
                {
                    sum += Convert.ToInt32(purchase_order_view.Rows[i].Cells[5].Value);
                }
                total_text.Text = Convert.ToString(sum);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Purchase_Order_List g = new Purchase_Order_List();
            g.Show();
            this.Hide();
        }
    }
}
