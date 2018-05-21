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
    public partial class Stock_in : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public Stock_in()
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
            cmd.CommandText = "select p.purch_order_id, item.item_name, item.item_measurement, item.item_purchase_price, item.item_selling_price, item_type.item_type, pd.purch_itemqty, item.item_id from item, purchase_order p, purchase_order_details pd, supplier, item_type where item.supplier_id_item_fk=supplier.supplier_id and item_type.item_type_id=item.item_type_id_fk and p.purch_order_id=pd.purch_purchid and pd.purch_itemid=item.item_id and p.purch_suppid=item.supplier_id_item_fk and pd.purch_itemqty > 0 and item.supplier_id_item_fk='" + supplier_id.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view.DataSource = dt;
            Conn.Close();
            item_view.Columns[0].HeaderText = "Purchase Order ID";
            item_view.Columns[1].HeaderText = "Item";
            item_view.Columns[2].HeaderText = "Measure";
            item_view.Columns[3].HeaderText = "Price";
            item_view.Columns[4].Visible = false;
            item_view.Columns[5].HeaderText = "Type";
            item_view.Columns[6].HeaderText = "Qty Ordered";
            item_view.Columns[7].HeaderText = "Item ID";
            item_view.Columns[7].Visible = false;
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }

        public void fillstockinbox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock_in order by stock_in_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("stock_in_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);
            }
            stock_in_id.Text = Convert.ToString(add);

            Conn.Close();
        }

        private void Stock_in_Load(object sender, EventArgs e)
        {
            combobox_supplier();
            fillstockinbox();
        }

        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // to put datagrid values on textbox
            if (e.RowIndex > -1)
            {
                item_id.Text = item_view.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                item_name_text.Text = item_view.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
                purchase_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
                selling_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
                supplier_id.Text = item_view.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
                supplier_text.Text = item_view.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
            }
        }
        string itemname;
        int current;
        public static string format = "yyyy-MM-dd HH:mm:ss";
        private void add_button_Click(object sender, EventArgs e)
        {
            bool found= false;
            if (stock_in_view.Rows.Count > 0)
            {
                // add items to another datagrid 

                foreach (DataGridViewRow row in stock_in_view.Rows)
                {

                    itemname = Convert.ToString(row.Cells[0].Value);
                    if (item_name_text.Text == itemname)
                    {
                        if (Convert.ToInt32(item_quantity_text.Text) > Convert.ToInt32(item_inventory.Text))
                        {
                            MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // update quantity if item is already in the datagrid
                        else
                        {
                            row.Cells[3].Value = (Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(item_quantity_text.Text)));
                            found = true;
                            current = item_view.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                            item_view.Rows[current].Cells[6].Value = item_inventory.Text;
                        }
                    }

                }

                // if item is not yet in the datagrid
                if (!found)
                {
                    if (Convert.ToInt32(item_quantity_text.Text) > Convert.ToInt32(item_inventory.Text))
                    {
                        MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int row = 0;
                        stock_in_view.Rows.Add();
                        row = stock_in_view.Rows.Count - 1;

                        stock_in_view["iname", row].Value = item_name_text.Text;
                        stock_in_view["iid", row].Value = item_id.Text;
                        stock_in_view["isp", row].Value = selling_price_text.Text;
                        stock_in_view["ipp", row].Value = purchase_price_text.Text;
                        stock_in_view["iqty", row].Value = item_quantity_text.Text;
                        stock_in_view["isupp", row].Value = supplier_text.Text;
                        stock_in_view["isuppid", row].Value = supplier_id.Text;
                        stock_in_view["idel", row].Value = del_date.Value.ToString(format);
                        stock_in_view["istock", row].Value = stock_date.Value.ToString(format);
                        stock_in_view["ppid", row].Value = purch_id.Text;

                        current = item_view.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                        item_view.Rows[current].Cells[6].Value = item_inventory.Text;
                    }
                }
            }

            else
            {

                if (Convert.ToInt32(item_quantity_text.Text) > Convert.ToInt32(item_inventory.Text))
                {
                    MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int row = 0;
                    stock_in_view.Rows.Add();
                    row = stock_in_view.Rows.Count - 1;

                    stock_in_view["iname", row].Value = item_name_text.Text;
                    stock_in_view["iid", row].Value = item_id.Text;
                    stock_in_view["isp", row].Value = selling_price_text.Text;
                    stock_in_view["ipp", row].Value = purchase_price_text.Text;
                    stock_in_view["iqty", row].Value = item_quantity_text.Text;
                    stock_in_view["isupp", row].Value = supplier_text.Text;
                    stock_in_view["isuppid", row].Value = supplier_id.Text;
                    stock_in_view["idel", row].Value = del_date.Value.ToString(format);
                    stock_in_view["istock", row].Value = stock_date.Value.ToString(format);
                    stock_in_view["ppid", row].Value = purch_id.Text;

                    current = item_view.CurrentRow.Index;
                    item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                    item_view.Rows[current].Cells[6].Value = item_inventory.Text;
                }
                
            }
            item_name_text.Clear();
            item_quantity_text.Clear();
            purchase_price_text.Clear();
            selling_price_text.Clear();
        }

        private void stock_in_button_Click(object sender, EventArgs e)
        {
            if (stock_in_view.Rows.Count == 0)
            {
                MessageBox.Show("Please input item/s to be stocked in", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Conn.Open();
                string query2 = "insert into stock_in(stock_in_id, " +
                        "stock_in_date, delivery_date) VALUES " +
                        "('" + Convert.ToInt32(stock_in_id.Text) + "','" +
                        "" + stock_date.Value.ToString(format) + "','" +
                        "" + del_date.Value.ToString(format) + "')";
                main.CUD_Statement(query2);

                foreach (DataGridViewRow row in stock_in_view.Rows)
                {
                    if (row.IsNewRow) continue;
                    int countrow2 = stock_in_view.Rows.Count;
                    for (int a = 0; a < countrow2; a++)
                    {
                        string ex = "select inventory_quantity from inventory where item_id_inventory_fk =" + stock_in_view.Rows[a].Cells[8].Value;
                        DataTable dt = new DataTable();
                        dt = main.SELECT_Statement(ex);

                        if (dt.Rows.Count == 0)
                        {
                            MySqlCommand cmd2 = new MySqlCommand("insert into inventory (item_id_inventory_fk, inventory_quantity) values (@item_id, @invq)", Conn);
                            cmd2.Parameters.AddWithValue("@invq", stock_in_view.Rows[a].Cells[3].Value);
                             cmd2.Parameters.AddWithValue("@item_id", stock_in_view.Rows[a].Cells[8].Value);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlCommand cmd2 = new MySqlCommand("update inventory set inventory_quantity=(inventory_quantity + @invq) where item_id_inventory_fk=@item_id", Conn);
                            cmd2.Parameters.AddWithValue("@invq", stock_in_view.Rows[a].Cells[3].Value);
                            cmd2.Parameters.AddWithValue("@item_id", stock_in_view.Rows[a].Cells[8].Value);
                            cmd2.ExecuteNonQuery();
                        }

                    }

                }

                foreach (DataGridViewRow row in item_view.Rows)
                {
                    if (row.IsNewRow) continue ;
                    int countrow2 = item_view.Rows.Count;
                    for (int a = 0; a < countrow2; a++)
                    {
                        if (Convert.ToInt32(item_view.Rows[a].Cells[6].Value) == 0)
                        {

                            MySqlCommand cmd2 = new MySqlCommand("update purchase_order_details set purch_itemqty=0, purch_dstatus='Complete' where purch_itemid=@item_id and purch_purchid=@pid", Conn);
                            cmd2.Parameters.AddWithValue("@invq", item_view.Rows[a].Cells[6].Value);
                            cmd2.Parameters.AddWithValue("@item_id", item_view.Rows[a].Cells[7].Value);
                            cmd2.Parameters.AddWithValue("@pid", item_view.Rows[a].Cells[0].Value);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlCommand cmd2 = new MySqlCommand("update purchase_order_details set purch_itemqty=@invq, purch_dstatus='Incomplete' where purch_itemid=@item_id and purch_purchid=@pid", Conn);
                            cmd2.Parameters.AddWithValue("@invq", item_view.Rows[a].Cells[6].Value);
                            cmd2.Parameters.AddWithValue("@item_id", item_view.Rows[a].Cells[7].Value);
                            cmd2.Parameters.AddWithValue("@pid", item_view.Rows[a].Cells[0].Value);
                            cmd2.ExecuteNonQuery();
                        }

                    }

                }

                foreach (DataGridViewRow row in stock_in_view.Rows)
                {
                    if (row.IsNewRow) continue;
                    int countrow = stock_in_view.Rows.Count;
                    for (int i = 0; i < countrow; i++)
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO stock_in_details(item_id_stock_in_fk,stock_in_quantity, stock_in_id_fk) VALUES (@iditem,@stckqty,'" + stock_in_id.Text + "')", Conn);
                        cmd.Parameters.AddWithValue("@iditem", stock_in_view.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@stckqty", stock_in_view.Rows[i].Cells[3].Value);
                        cmd.ExecuteNonQuery();


                    }
                }

                Conn.Close();

                // messagebox for yes and no if sure about transaction
                // show list of all items bought
                MessageBox.Show("Stock in Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data();
                Reports_Page g = new Reports_Page();
                g.Show();
                this.Hide();
            }
        }

        private void item_name_text_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            // item inventory should be back to original quantity
            foreach (DataGridViewRow item in this.stock_in_view.SelectedRows)
            {
                stock_in_view.Rows.RemoveAt(item.Index);
            }
            item_name_text.Clear();
            item_quantity_text.Clear();
            purchase_price_text.Clear();
            selling_price_text.Clear();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {

        }

        private void item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_inventory.Text = item_view.Rows[e.RowIndex].Cells["purch_itemqty"].Value.ToString();
                item_id.Text = item_view.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                item_name_text.Text = item_view.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
                purchase_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
                selling_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
                purch_id.Text = item_view.Rows[e.RowIndex].Cells["purch_order_id"].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void purchase_price_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void selling_price_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplier_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void item_quantity_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_label_Click(object sender, EventArgs e)
        {

        }

        private void item_name_label_Click(object sender, EventArgs e)
        {

        }
        private void combobox_supplier()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT supplier_name FROM supplier;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            supplier_text.Items.Add("");
            while (dr.Read())
            {
                supplier_text.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = supplier_text.Text;


            int index = supplier_text.FindString(actual);
            if (index > -1)
            {
                string found = supplier_text.Items.ToString();

                supplier_text.SelectionStart = actual.Length;
                supplier_text.SelectionLength = found.Length;
                supplier_text.SelectedIndex = index;
            }
        }
        private void supplier_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier_text.DropDownStyle = ComboBoxStyle.DropDown;
            supplier_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            supplier_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT supplier_id from supplier where supplier_name='" + supplier_text.SelectedText + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("supplier_id");
                supplier_id.Text = id;
            }
            Conn.Close();
            disp_data();
        }

        private void item_quantity_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                e.Handled = true;
            }

        }
    }
    }
        
    

