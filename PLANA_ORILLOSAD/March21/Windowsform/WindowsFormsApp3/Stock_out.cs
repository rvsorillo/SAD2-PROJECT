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
    public partial class Stock_out : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Stock_out()
        {
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
            InitializeComponent();
        }

        string itemname1;
        int current;
        public static string format = "yyyy-MM-dd HH:mm:ss";
        public void disp_data()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select item.item_id, item.item_name, item.item_measurement, item.item_purchase_price, item.item_selling_price, item_type.item_type, supplier.supplier_id, supplier.supplier_name, supplier_contact_person, inventory_quantity from item, inventory, supplier, item_type where item.supplier_id_item_fk=supplier.supplier_id and item_type.item_type_id=item.item_type_id_fk and inventory.item_id_inventory_fk=item.item_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view_1.DataSource = dt;
            Conn.Close();
            item_view_1.Columns[0].HeaderText = "Item ID";
            item_view_1.Columns[0].Visible = false;
            item_view_1.Columns[1].HeaderText = "Item";
            item_view_1.Columns[2].HeaderText = "Measurement";
            item_view_1.Columns[3].HeaderText = "Price";
            item_view_1.Columns[4].HeaderText = "Selling Price";
            item_view_1.Columns[4].Visible = false;
            item_view_1.Columns[5].HeaderText = "Type";
            item_view_1.Columns[6].HeaderText = "Supplier ID";
            item_view_1.Columns[6].Visible = false;
            item_view_1.Columns[7].HeaderText = "Supplier";
            item_view_1.Columns[8].HeaderText = "Contact Person";
            item_view_1.Columns[8].Visible = false;
            item_view_1.Columns[9].HeaderText = "In Stock";

        }

        public void fillstockoutbox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock_out order by stock_out_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("stock_out_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);
            }
            stock_out_id.Text = Convert.ToString(add);

            Conn.Close();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (stock_out_view.Rows.Count > 0)
            {
                // add items to another datagrid 

                foreach (DataGridViewRow row in stock_out_view.Rows)
                {

                    itemname1 = Convert.ToString(row.Cells[0].Value);
                    if (item_name_text_1.Text == itemname1)
                    {
                        if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))
                        {
                            MessageBox.Show("There is not enough quantity to stock out.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // update quantity if item is already in the datagrid
                        else
                        {
                            row.Cells[3].Value = (Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(item_quantity_text_1.Text)));
                            found = true;
                            current = item_view_1.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                            item_view_1.Rows[current].Cells[9].Value = item_inventory.Text;
                        }

                    }
                }


            }


            // if item is not yet in the datagrid
            if (!found)
            {
                if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))
                {
                    MessageBox.Show("There is not enough quantity to stock out.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int row = 0;
                    stock_out_view.Rows.Add();
                    row = stock_out_view.Rows.Count - 1;

                    stock_out_view["iname", row].Value = item_name_text_1.Text;
                    stock_out_view["iid", row].Value = item_id_1.Text;
                    stock_out_view["isp", row].Value = selling_price_text_1.Text;
                    stock_out_view["ipp", row].Value = purchase_price_text_1.Text;
                    stock_out_view["iqty", row].Value = item_quantity_text_1.Text;
                    stock_out_view["isupp", row].Value = supplier_text_1.Text;
                    stock_out_view["isuppid", row].Value = supplier_id_1.Text;
                    stock_out_view["istock", row].Value = stock_out_date.Value.ToString(format);
                    current = item_view_1.CurrentRow.Index;
                    item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                    item_view_1.Rows[current].Cells[9].Value = item_inventory.Text;
                }
            }

            else
            {
                if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))
                {
                    MessageBox.Show("There is not enough quantity to stock out.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int row = 0;
                    stock_out_view.Rows.Add();
                    row = stock_out_view.Rows.Count - 1;

                    stock_out_view["iname", row].Value = item_name_text_1.Text;
                    stock_out_view["iid", row].Value = item_id_1.Text;
                    stock_out_view["isp", row].Value = selling_price_text_1.Text;
                    stock_out_view["ipp", row].Value = purchase_price_text_1.Text;
                    stock_out_view["iqty", row].Value = item_quantity_text_1.Text;
                    stock_out_view["isupp", row].Value = supplier_text_1.Text;
                    stock_out_view["isuppid", row].Value = supplier_id_1.Text;
                    stock_out_view["istock", row].Value = stock_out_date.Value.ToString(format);
                    current = item_view_1.CurrentRow.Index;
                    item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                    item_view_1.Rows[current].Cells[9].Value = item_inventory.Text;
                }
            }
            item_name_text_1.Clear();
            item_quantity_text_1.Clear();
            purchase_price_text_1.Clear();
            selling_price_text_1.Clear();
            supplier_text_1.Clear();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            // item inventory should be back to original quantity
            foreach (DataGridViewRow item in this.stock_out_view.SelectedRows)
            {
                stock_out_view.Rows.RemoveAt(item.Index);
            }
            item_name_text_1.Clear();
            item_quantity_text_1.Clear();
            purchase_price_text_1.Clear();
            selling_price_text_1.Clear();
            supplier_text_1.Clear();
        }

        private void item_view_1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            item_id_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            item_name_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
            purchase_price_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
            selling_price_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
            supplier_id_1.Text = item_view_1.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
            supplier_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
        }


        string itemname;
        private void remove_button_Click_1(object sender, EventArgs e)
        {
            bool found = false;
            if (stock_out_view.Rows.Count > 0)
            {
                // add items to another datagrid 

                foreach (DataGridViewRow row in stock_out_view.Rows)
                {

                    itemname = Convert.ToString(row.Cells[0].Value);
                    if (item_name_text_1.Text == itemname)
                    {
                        if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))
                        {
                            MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // update quantity if item is already in the datagrid
                        else
                        {
                            row.Cells[3].Value = (Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(item_quantity_text_1.Text)));
                            found = true;
                            current = item_view_1.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                            item_view_1.Rows[current].Cells[6].Value = item_inventory.Text;
                        }
                    }

                }

                // if item is not yet in the datagrid
                if (!found)
                {
                    if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))

                    {
                        MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int row = 0;
                        stock_out_view.Rows.Add();
                        row = stock_out_view.Rows.Count - 1;

                        stock_out_view["iname", row].Value = item_name_text_1.Text;
                        stock_out_view["iid", row].Value = item_id_1.Text;
                        stock_out_view["isp", row].Value = selling_price_text_1.Text;
                        stock_out_view["ipp", row].Value = purchase_price_text_1.Text;
                        stock_out_view["iqty", row].Value = item_quantity_text_1.Text;
                        stock_out_view["isupp", row].Value = supplier_text_1.Text;
                        stock_out_view["isuppid", row].Value = supplier_id_1.Text;
                        stock_out_view["istock", row].Value = stock_out_date.Value.ToString(format);

                        current = item_view_1.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                        item_view_1.Rows[current].Cells[6].Value = item_inventory.Text;
                    }
                }
            }

            else
            {

                if (Convert.ToInt32(item_quantity_text_1.Text) > Convert.ToInt32(item_inventory.Text))
                {
                    MessageBox.Show("Quantity is more than ordered.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int row = 0;
                    stock_out_view.Rows.Add();
                    row = stock_out_view.Rows.Count - 1;

                    stock_out_view["iname", row].Value = item_name_text_1.Text;
                    stock_out_view["iid", row].Value = item_id_1.Text;
                    stock_out_view["isp", row].Value = selling_price_text_1.Text;
                    stock_out_view["ipp", row].Value = purchase_price_text_1.Text;
                    stock_out_view["iqty", row].Value = item_quantity_text_1.Text;
                    stock_out_view["isupp", row].Value = supplier_text_1.Text;
                    stock_out_view["isuppid", row].Value = supplier_id_1.Text;
                    stock_out_view["istock", row].Value = stock_out_date.Value.ToString(format);

                    current = item_view_1.CurrentRow.Index;
                    item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text_1.Text)));
                    item_view_1.Rows[current].Cells[6].Value = item_inventory.Text;
                }

            }
            item_name_text_1.Clear();
            item_quantity_text_1.Clear();
            purchase_price_text_1.Clear();
            selling_price_text_1.Clear();
            supplier_text_1.Clear();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            stock_out_view.Rows.Clear();
        }

        private void stock_out_button_Click(object sender, EventArgs e)
        {
            if (stock_out_view.Rows.Count == 0)
            {
                MessageBox.Show("Please input item/s to be stocked out", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Conn.Open();
                string query2 = "insert into stock_out(stock_out_id, " + "stock_out_date) VALUES " +
                        "('" + Convert.ToInt32(stock_out_id.Text) + "','" +
                        "" + stock_out_date.Value.ToString(format) + "')";
                main.CUD_Statement(query2);
                Conn.Close();

                foreach (DataGridViewRow row in stock_out_view.Rows)
                {

                    int countrow2 = stock_out_view.Rows.Count;
                    for (int a = 0; a < countrow2; a++)
                    {
                        string ex = "select inventory_quantity from inventory where item_id_inventory_fk =" + stock_out_view.Rows[a].Cells[8].Value;
                        DataTable dt = new DataTable();
                        dt = main.SELECT_Statement(ex);

                        if (dt.Rows.Count == 0)
                        {
                        
                        }
                        else
                        {
                            Conn.Open();
                            MySqlCommand cmd2 = new MySqlCommand("update inventory set inventory_quantity=(inventory_quantity - @invq) where item_id_inventory_fk=@item_id", Conn);
                            cmd2.Parameters.AddWithValue("@invq", stock_out_view.Rows[a].Cells[3].Value);
                            cmd2.Parameters.AddWithValue("@item_id", stock_out_view.Rows[a].Cells[8].Value);
                            cmd2.ExecuteNonQuery();
                            Conn.Close();
                        }
                        foreach (DataGridViewRow row1 in stock_out_view.Rows)
                        {


                            int countrow = stock_out_view.Rows.Count;
                            for (int i = 0; i < countrow - 1; i++)
                            {
                                Conn.Open();

                                MySqlCommand cmd = new MySqlCommand("INSERT INTO stock_out_details(item_id_stock_out_fk,stock_out_quantity, stock_out_id_fk) VALUES (@iditem,@stckqty,'" + stock_out_id.Text + "')", Conn);
                                cmd.Parameters.AddWithValue("@iditem", stock_out_view.Rows[i].Cells[8].Value);
                                cmd.Parameters.AddWithValue("@stckqty", stock_out_view.Rows[i].Cells[3].Value);
                                cmd.ExecuteNonQuery();

                                Conn.Close();

                            }
                        }

                        // messagebox for yes and no if sure about transaction
                        // show list of all items bought
                        MessageBox.Show("Stock out Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disp_data();
                        Inventory_List g = new Inventory_List();
                        g.Show();
                        this.Hide();
                    }
                }

            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }

        private void Stockout_Load(object sender, EventArgs e)
        {
            disp_data();
            fillstockoutbox();
        }

        private void item_view_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item_id_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            item_name_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
            purchase_price_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
            selling_price_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
            supplier_id_1.Text = item_view_1.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
            supplier_text_1.Text = item_view_1.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
            item_inventory.Text = item_view_1.Rows[e.RowIndex].Cells["inventory_quantity"].Value.ToString();
        }

        private void item_quantity_text_1_KeyPress(object sender, KeyPressEventArgs e)
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
