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
    public partial class Sales_Create : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        int current;
        public static string salid;
        public Sales_Create()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        // display values on datagrid
        public void disp_data()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT item.item_id, item.item_name,item.item_selling_price, item.item_brand, item.item_measurement, inventory.inventory_quantity, s.supplier_name FROM ITEM, INVENTORY, SUPPLIER s WHERE item.item_id=inventory.item_id_inventory_fk and inventory.inventory_quantity >0 and s.supplier_id=item.supplier_id_item_fk;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            sales_item_view.DataSource = dt;
            Conn.Close();
            sales_item_view.Columns[0].HeaderText = "Item ID";
            sales_item_view.Columns[0].Visible = false;
            sales_item_view.Columns[1].HeaderText = "Name";
            sales_item_view.Columns[2].HeaderText = "Price";
            sales_item_view.Columns[3].HeaderText = "Brand";
            sales_item_view.Columns[4].HeaderText = "Measure";
            sales_item_view.Columns[5].HeaderText = "In Stock";
            sales_item_view.Columns[6].HeaderText = "Supplier";


        }
        // display added values on datagrid
        public void disp_selected()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT item.item_id, item.item_name, item.item_selling_price, " +
                "stock_order_details.stock_order_item_quantity AS QUANTITY FROM STOCK_ORDER_DETAILS, ITEM " +
                "WHERE stock_order_details.item_id_stock_order_fk=item.item_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            selected_sales_item_view.DataSource = dt;
            Conn.Close();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            if (cust_name_input.Text == string.Empty && total_text.Text == string.Empty)
            {
                Sales_Page g = new Sales_Page();
                g.Show();
                this.Hide();
            }
            else
            {
                switch (MessageBox.Show("Are you sure you want to leave? \nChanges you have made will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        Homepage g = new Homepage();
                        g.Show();
                        this.Hide();
                        break;
                    case DialogResult.No:

                        break;
                }
            }
        }
        public void fillsalesbox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock_order order by stock_order_id asc;";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string list = sdr.GetString("stock_order_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);
            }
            sales_id.Text = Convert.ToString(add);

            Conn.Close();
        }
     
        private void Sales_Create_Load(object sender, EventArgs e)
        {
            // call view functions
            disp_data();
            fillsalesbox();
            combobox_customer();
        }
        string itemname;
        int countrow;
        int countrow2, amt;
        private void add_item_button_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (item_name_text.Text == String.Empty)
            {
                MessageBox.Show("Please choose an item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_quantity_text.Text == String.Empty)
            {
                MessageBox.Show("Please specify quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_inventory.Text == String.Empty)
            {
                MessageBox.Show("Please choose an item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Convert.ToInt32(item_inventory.Text) == 0)
            {
                MessageBox.Show("You do not have enough stocks.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (selected_sales_item_view.Rows.Count > 0)
                {
                    // add items to another datagrid 

                    foreach (DataGridViewRow row in selected_sales_item_view.Rows)
                    {


                        itemname = row.Cells[0].Value.ToString();
                        if (item_name_text.Text == itemname)
                        {
                            if (Convert.ToInt32(item_inventory.Text) == 0)
                            {
                                MessageBox.Show("You do not have enough stocks.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            // update quantity if item is already in the datagrid
                            row.Cells[2].Value = (Convert.ToString(Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(item_quantity_text.Text)));
                            found = true;
                            current = sales_item_view.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                            sales_item_view.Rows[current].Cells[5].Value = item_inventory.Text;
                        }

                    }

                    // if item is not yet in the datagrid
                    if (!found)
                    {
                        if (Convert.ToInt32(item_inventory.Text) == 0)
                        {
                            MessageBox.Show("You do not have enough stocks.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int row = 0;
                            selected_sales_item_view.Rows.Add();
                            row = selected_sales_item_view.Rows.Count - 1;

                            selected_sales_item_view["sid", row].Value = sales_id.Text;
                            selected_sales_item_view["iid", row].Value = item_id_text.Text;
                            selected_sales_item_view["itm_name", row].Value = item_name_text.Text;
                            selected_sales_item_view["Itm_Price", row].Value = item_price_text.Text;
                            selected_sales_item_view["qty", row].Value = item_quantity_text.Text;
                            selected_sales_item_view["sup", row].Value = supp_name.Text;
                            current = sales_item_view.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                            sales_item_view.Rows[current].Cells[5].Value = item_inventory.Text;
                        }
                    }
                }

                else
                {
                    if (Convert.ToInt32(item_inventory.Text) == 0)
                    {
                        MessageBox.Show("You do not have enough stocks.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int row = 0;
                        selected_sales_item_view.Rows.Add();
                        row = selected_sales_item_view.Rows.Count - 1;

                        selected_sales_item_view["sid", row].Value = sales_id.Text;
                        selected_sales_item_view["iid", row].Value = item_id_text.Text;
                        selected_sales_item_view["itm_name", row].Value = item_name_text.Text;
                        selected_sales_item_view["Itm_Price", row].Value = item_price_text.Text;
                        selected_sales_item_view["qty", row].Value = item_quantity_text.Text;
                        selected_sales_item_view["sup", row].Value = supp_name.Text;
                        current = sales_item_view.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(item_quantity_text.Text)));
                        sales_item_view.Rows[current].Cells[5].Value = item_inventory.Text;
                    }
                }
                // price * quantity
                foreach (DataGridViewRow row in selected_sales_item_view.Rows)
                {
                    row.Cells[3].Value = Convert.ToString(Convert.ToInt32(row.Cells[1].Value) * (Convert.ToInt32(row.Cells[2].Value)));
                }
                //total
                foreach (DataGridViewRow row in selected_sales_item_view.Rows)
                {
                    int sum = 0;
                    countrow = selected_sales_item_view.Rows.Count;
                    for (int i = 0; i < countrow; i++)
                    {
                        sum += Convert.ToInt32(selected_sales_item_view.Rows[i].Cells[3].Value);
                    }
                    total_text.Text = Convert.ToString(sum);
                }
            }
            item_name_text.Clear();
            item_price_text.Clear();
            item_quantity_text.Clear();
        }
        
        private void remove_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_name_text.Text) || string.IsNullOrEmpty(item_quantity_text.Text))
            {
                MessageBox.Show("Please select an item in the list");

            }
            else
            {
                // item inventory should be back to original quantity
                foreach (DataGridViewRow item in this.selected_sales_item_view.SelectedRows)
                {
                    int tempid = Convert.ToInt32(item.Cells[6].Value);
                    int tempqty = Convert.ToInt32(item.Cells[2].Value);
                    foreach (DataGridViewRow item2 in sales_item_view.Rows)
                    {
                        if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                        {
                            int qty = Convert.ToInt32(item2.Cells[5].Value);
                            int add = qty + tempqty;
                            item2.Cells[5].Value = Convert.ToString(add);
                            selected_sales_item_view.Rows.RemoveAt(item.Index);

                        }
                    }
                }
                foreach (DataGridViewRow row in selected_sales_item_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sum = 0;
                    for (int i = 0; i < selected_sales_item_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(selected_sales_item_view.Rows[i].Cells[3].Value);

                    }
                    total_text.Text = Convert.ToString(sum);

                }
                item_name_text.Clear();
                item_quantity_text.Clear();
                item_price_text.Clear();
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            if (cust_name_input.Text == String.Empty)
            {
                MessageBox.Show("Please Input Customer Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (selected_sales_item_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Item/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cust_name_input.Items.Contains(cust_name_input.Text) == false)
            {
                MessageBox.Show("Customer name not valid. Please select from the list.");
                cust_name_input.Text = string.Empty;
            }
            else
            {
                switch (MessageBox.Show("Are you sure you want to proceed with the Check-out?","", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {

                    case DialogResult.Yes:
                            Conn.Open();
                            string format = "yyyy-MM-dd HH:mm:ss";
                            string query2 = "insert into stock_order(stock_order_id, " +
                                    "cust_id_stock_order_fk, stock_order_date, total_amount_stock_order) VALUES " +
                                    "('" + Convert.ToInt32(sales_id.Text) + "','" +
                                    "" + Convert.ToInt32(cust_id.Text) + "','" +
                                    "" + date_input.Value.ToString(format) + "','" +
                                    "" + Convert.ToDouble(total_text.Text) + "')";
                            main.CUD_Statement(query2);

                            countrow2 = sales_item_view.Rows.Count;
                            for (int a = 0; a < countrow2; a++)
                            {
                                MySqlCommand cmd2 = new MySqlCommand("update inventory set inventory_quantity=@invq where item_id_inventory_fk=@item_id", Conn);
                                cmd2.Parameters.AddWithValue("@invq", sales_item_view.Rows[a].Cells[5].Value);
                                cmd2.Parameters.AddWithValue("@item_id", sales_item_view.Rows[a].Cells[0].Value);
                                cmd2.ExecuteNonQuery();
                            }

                            int countrow3 = selected_sales_item_view.Rows.Count;
                            for (int i = 0; i < countrow3; i++)
                            {
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO stock_order_details(stock_order_item_quantity,stock_order_id_fk, item_id_stock_order_fk, total_stock_order_details) VALUES (@sqty,@stockidfk,@itemidfk, @total)", Conn);

                                cmd.Parameters.AddWithValue("@sqty", selected_sales_item_view.Rows[i].Cells[2].Value);
                                cmd.Parameters.AddWithValue("@stockidfk", selected_sales_item_view.Rows[i].Cells[5].Value);
                                cmd.Parameters.AddWithValue("@itemidfk", selected_sales_item_view.Rows[i].Cells[6].Value);
                                cmd.Parameters.AddWithValue("@total", selected_sales_item_view.Rows[i].Cells[3].Value); cmd.ExecuteNonQuery();

                                MySqlCommand cmd2 = new MySqlCommand("INSERT INTO stock_out_details(stock_out_quantity, stock_out_type, item_id_stock_out_fk) VALUES (@sqty,'Sales',@itemidfk)", Conn);

                                cmd2.Parameters.AddWithValue("@sqty", selected_sales_item_view.Rows[i].Cells[2].Value);
                                cmd2.Parameters.AddWithValue("@itemidfk", selected_sales_item_view.Rows[i].Cells[6].Value);
                                cmd2.ExecuteNonQuery();

                            }


                            Conn.Close();

                            // messagebox for yes and no if sure about transaction
                            // show list of all items bought
                            switch (MessageBox.Show("Transaction Created! Would you like to print the Receipt?", "Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                            {

                                case DialogResult.Yes:
                                    salid = Convert.ToString(sales_id.Text);
                                    new Sales_Receipt(salid).ShowDialog();
                                    break;
                                case DialogResult.No:

                                    Sales_Page k = new Sales_Page();
                                    k.Show();
                                    this.Hide();
                                    break;
                            }

                            break;
                            case DialogResult.No:
                        break;
                }
                }
        }

        private void combobox_customer()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT concat(cust_fname,' ',cust_lname) as custfull FROM customer;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            cust_name_input.Items.Add("");
            while (dr.Read())
            {
                cust_name_input.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = cust_name_input.Text;


            int index = cust_name_input.FindString(actual);
            if (index > -1)
            {
                string found = cust_name_input.Items.ToString();

                cust_name_input.SelectionStart = actual.Length;
                cust_name_input.SelectionLength = found.Length;
                cust_name_input.SelectedIndex = index;
            }

        }
        private void cust_name_input_SelectedIndexChanged(object sender, EventArgs e)
        {

            cust_name_input.DropDownStyle = ComboBoxStyle.DropDown;
            cust_name_input.AutoCompleteSource = AutoCompleteSource.ListItems;
            cust_name_input.AutoCompleteMode = AutoCompleteMode.Suggest;

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cust_id from customer where concat(cust_fname,' ', cust_lname)='" + cust_name_input.SelectedText + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("cust_id");
                cust_id.Text = id;
            }
            Conn.Close();


        }

        private void item_name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void sales_item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // to put datagrid values on textbox
            if (e.RowIndex > -1)
            {
                item_id_text.Text = sales_item_view.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                item_name_text.Text = sales_item_view.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
                supp_name.Text = sales_item_view.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
                item_price_text.Text = sales_item_view.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
                item_inventory.Text = sales_item_view.Rows[e.RowIndex].Cells["inventory_quantity"].Value.ToString();
            }
        }

        private void selected_sales_item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_id_text.Text = selected_sales_item_view.Rows[e.RowIndex].Cells[6].Value.ToString();
                item_name_text.Text = selected_sales_item_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                item_quantity_text.Text= selected_sales_item_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                item_price_text.Text = selected_sales_item_view.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void selected_sales_item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void update_item_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.selected_sales_item_view.SelectedRows)
            {
                int fetchtempid = Convert.ToInt32(item.Cells[6].Value);
                int fetchtempqty = Convert.ToInt32(item.Cells[2].Value);
                int fetchtemp_serv = Convert.ToInt32(item.Cells[4].Value);
                switch (MessageBox.Show("Are you sure you want to change \n the item quantity of " + item.Cells[0].Value + " to " + item_quantity_text.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:

                        if (Convert.ToInt32(item_quantity_text.Text) == 0)
                        {
                            switch (MessageBox.Show("Would you like to delete the entire row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {

                                case DialogResult.No:
                                    break;
                                case DialogResult.Yes:
                                    if (string.IsNullOrEmpty(item_name_text.Text))
                                    {
                                        MessageBox.Show("Please select an item in the list");

                                    }
                                    else
                                    {
                                        // item inventory should be back to original quantity
                                        foreach (DataGridViewRow item3 in this.selected_sales_item_view.SelectedRows)
                                        {
                                            int tempid = Convert.ToInt32(item3.Cells[6].Value);
                                            int tempqty = Convert.ToInt32(item3.Cells[2].Value);
                                            selected_sales_item_view.Rows.RemoveAt(item3.Index);

                                            foreach (DataGridViewRow item2 in this.sales_item_view.SelectedRows)
                                            {
                                                if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                                                {
                                                    int qty = Convert.ToInt32(item2.Cells[5].Value);
                                                    int add = qty + tempqty;
                                                    item2.Cells[5].Value = Convert.ToString(add);
                                                }
                                            }
                                        }
                                    }
                                    break;

                            }
                        }

                        else
                        {
                            foreach (DataGridViewRow item3 in this.selected_sales_item_view.SelectedRows)
                            {
                                int tempid = Convert.ToInt32(item3.Cells[6].Value);
                                int tempqty = Convert.ToInt32(item3.Cells[2].Value) - Convert.ToInt32(item_quantity_text.Text);
                                item3.Cells[2].Value = item_quantity_text.Text;
                                item3.Cells[3].Value = Convert.ToInt32(item3.Cells[1].Value) * Convert.ToInt32(item3.Cells[2].Value);
                                foreach (DataGridViewRow item2 in sales_item_view.Rows)
                                {
                                    if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                                    {
                                        int qty = Convert.ToInt32(item2.Cells[5].Value);
                                        int add = qty + tempqty;
                                        item2.Cells[5].Value = Convert.ToString(add);
                                    }
                                }



                              
                            }
                        }
                        break;
                }
                foreach (DataGridViewRow row in selected_sales_item_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sum = 0;
                    for (int i = 0; i < selected_sales_item_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(selected_sales_item_view.Rows[i].Cells[3].Value);

                    }
                    total_text.Text = Convert.ToString(sum);

                }
                item_name_text.Clear();
                item_quantity_text.Clear();
                item_price_text.Clear();
            }
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

