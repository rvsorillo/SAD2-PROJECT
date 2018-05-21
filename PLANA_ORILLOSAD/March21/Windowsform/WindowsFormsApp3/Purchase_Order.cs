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
    public partial class Purchase_Order : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public string itemname;
        int current;
        public static string purid;
        public Purchase_Order()
        {
            InitializeComponent();

            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }
        public void fillpurchinbox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from purchase_order order by purch_order_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("purch_order_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);
            }
            purch_id.Text = Convert.ToString(add);

            Conn.Close();
        }
        public void disp_data()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select item.item_id, item.item_name, item.item_brand, item.item_measurement, item.item_purchase_price, item.item_selling_price, item_type.item_type from item, supplier, item_type where item.supplier_id_item_fk=supplier.supplier_id and item_type.item_type_id=item.item_type_id_fk and supplier.supplier_id='" + supplier_id.Text + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view.DataSource = dt;
            Conn.Close();
            item_view.Columns[0].HeaderText = "Item ID";
            item_view.Columns[0].Visible = false;
            item_view.Columns[1].HeaderText = "Item Name";
            item_view.Columns[2].HeaderText = "Brand";
            item_view.Columns[3].HeaderText = "Measurement";
            item_view.Columns[4].HeaderText = "Purchase Price";
            item_view.Columns[5].HeaderText = "Selling Price";
            item_view.Columns[5].Visible = false;
            item_view.Columns[6].HeaderText = "Item Type";
          
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
        private void combobox_employee()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT concat(emp_fname, ' ', emp_lname) as empfull FROM employee;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            employee_input.Items.Add("");
            while (dr.Read())
            {
                employee_input.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = employee_input.Text;


            int index = employee_input.FindString(actual);
            if (index > -1)
            {
                string found = employee_input.Items.ToString();

                employee_input.SelectionStart = actual.Length;
                employee_input.SelectionLength = found.Length;
                employee_input.SelectedIndex = index;
            }

        }
        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            fillpurchinbox();
            combobox_supplier();
            combobox_employee();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (supplier_text.Text == String.Empty && item_name_text.Text == String.Empty && item_quantity_text.Text == String.Empty && employee_input.Text == String.Empty)
            {
                MessageBox.Show("Please input required field.");
            }
            else if (supplier_text.Text == String.Empty)
            {
                MessageBox.Show("Please Select Supplier.");
            }
            else if (item_name_text.Text == String.Empty)
            {
                MessageBox.Show("Please Select Items to Add on your Purchase Order.");
            }
            else if (item_quantity_text.Text == String.Empty)
            {
                MessageBox.Show("Please Specify Item quantity.");
            }
            else if (employee_input.Text == String.Empty)
            {
                MessageBox.Show("Please Select Employee.");
            }
            else if (employee_input.Items.Contains(employee_input.Text) == false)
            {
                MessageBox.Show("Please Select an Employee from the List.");
                employee_input.Text = string.Empty;
            }
            else if (supplier_text.Items.Contains(supplier_text.Text) == false)
            {
                MessageBox.Show("Please Select a Supplier from the List.");
                supplier_text.Text = string.Empty;
            }
            else {
                if (stock_in_view.Rows.Count > 0)
                {
                    // add items to another datagrid 

                    foreach (DataGridViewRow row in stock_in_view.Rows)
                    {

                        itemname = Convert.ToString(row.Cells[0].Value);
                        if (item_name_text.Text == itemname)
                        {
                            // update quantity if item is already in the datagrid
                            row.Cells[3].Value = (Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(item_quantity_text.Text)));
                            found = true;
                            current = item_view.CurrentRow.Index;

                        }

                    }

                    // if item is not yet in the datagrid
                    if (!found)
                    {
                        int row = 0;
                        stock_in_view.Rows.Add();
                        row = stock_in_view.Rows.Count - 1;

                        stock_in_view["iname", row].Value = item_name_text.Text;
                        stock_in_view["iid", row].Value = item_id.Text;
                        stock_in_view["i_brand", row].Value = brand_text.Text;
                        stock_in_view["i_meas", row].Value = measure_text.Text;
                        stock_in_view["isp", row].Value = selling_price_text.Text;
                        stock_in_view["ipp", row].Value = purchase_price_text.Text;
                        stock_in_view["iqty", row].Value = item_quantity_text.Text;
                        stock_in_view["isupp", row].Value = supplier_text.Text;
                        stock_in_view["isuppid", row].Value = supplier_id.Text;
                        stock_in_view["subt", row].Value = Convert.ToString(Convert.ToInt32(purchase_price_text.Text) * Convert.ToInt32(item_quantity_text.Text));
                        stock_in_view["request", row].Value = employee_input.Text;
                    }
                }
                else
                {

                    int row = 0;
                    stock_in_view.Rows.Add();
                    row = stock_in_view.Rows.Count - 1;

                    stock_in_view["iname", row].Value = item_name_text.Text;
                    stock_in_view["iid", row].Value = item_id.Text;
                    stock_in_view["i_brand", row].Value = brand_text.Text;
                    stock_in_view["i_meas", row].Value = measure_text.Text;
                    stock_in_view["isp", row].Value = selling_price_text.Text;
                    stock_in_view["ipp", row].Value = purchase_price_text.Text;
                    stock_in_view["iqty", row].Value = item_quantity_text.Text;
                    stock_in_view["isupp", row].Value = supplier_text.Text;
                    stock_in_view["isuppid", row].Value = supplier_id.Text;
                    stock_in_view["subt", row].Value = Convert.ToString(Convert.ToInt32(purchase_price_text.Text) * Convert.ToInt32(item_quantity_text.Text));
                    stock_in_view["request", row].Value = employee_input.Text;

                }
                foreach (DataGridViewRow row in stock_in_view.Rows)
                {
                    int sum = 0;
                    int countrow = stock_in_view.Rows.Count;
                    for (int i = 0; i < countrow; i++)
                    {
                        sum += Convert.ToInt32(stock_in_view.Rows[i].Cells[9].Value);
                    }
                    total_text.Text = Convert.ToString(sum);
                }
                employee_input.Text = string.Empty;
                supplier_text.Enabled = false;
                item_name_text.Clear();
                item_quantity_text.Clear();
                purchase_price_text.Clear();
                selling_price_text.Clear();
            }
           
        }

        private void item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_id.Text = item_view.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                item_name_text.Text = item_view.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
                brand_text.Text = item_view.Rows[e.RowIndex].Cells["item_brand"].Value.ToString();
                measure_text.Text = item_view.Rows[e.RowIndex].Cells["item_measurement"].Value.ToString();
                purchase_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
                purchase_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
                selling_price_text.Text = item_view.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
               
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
        public static string format = "yyyy-MM-dd HH:mm:ss";

        private void create_button_Click(object sender, EventArgs e)
        {
            if (stock_in_view.Rows.Count == 0)
            {
                MessageBox.Show("Please input item/s to be added to the purchase order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                switch (MessageBox.Show("Are you sure you want to proceed with the Purchase Order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        Conn.Open();
                        string query2 = "insert into purchase_order(purch_order_id, purch_order_date, purch_suppid, purch_status, purch_total) values ('" + purch_id.Text + "','" + date_input.Value.ToString(format) + "','" + supplier_id.Text + "','Pending', '" + total_text.Text + "')";
                        main.CUD_Statement(query2);



                        int countrow = stock_in_view.Rows.Count;
                        for (int i = 0; i < countrow; i++)
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO purchase_order_details(purch_itemid,purch_itemqty, purch_purchid, purch_dstatus, purch_finalitemqty, purch_reqemployeeid) VALUES (@iditem,@qtyitem, " + purch_id.Text + ", 'Incomplete', @qtyitem, '"+ emp_id.Text +"')", Conn);
                            cmd.Parameters.AddWithValue("@iditem", stock_in_view.Rows[i].Cells[8].Value);
                            cmd.Parameters.AddWithValue("@qtyitem", stock_in_view.Rows[i].Cells[5].Value);
                            cmd.ExecuteNonQuery();


                        }


                        Conn.Close();

                        // messagebox for yes and no if sure about transaction
                        // show list of all items bought
                        purid = Convert.ToString(value: purch_id.Text);
                        new Purchase_Order_Form(purid).ShowDialog();
                        Inventory_Page g = new Inventory_Page();

                        g.Show();
                        this.Hide();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Purchase_Order_List g = new Purchase_Order_List();
            g.Show();
            this.Hide();
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

        private void employee_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_input.DropDownStyle = ComboBoxStyle.DropDown;
            employee_input.AutoCompleteSource = AutoCompleteSource.ListItems;
            employee_input.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select emp_id from employee where concat(emp_fname, ' ', emp_lname)='" + employee_input.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("emp_id");
                emp_id.Text = id;
            }
            Conn.Close();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            stock_in_view.Rows.Clear();
            total_text.Clear();
            supplier_text.Text = string.Empty;
            supplier_text.Enabled = true;
            employee_input.Text = string.Empty;
            item_name_text.Clear();
            item_quantity_text.Clear();
            purchase_price_text.Clear();
            selling_price_text.Clear();
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
                foreach (DataGridViewRow item in this.stock_in_view.SelectedRows)
                {                   
                    stock_in_view.Rows.RemoveAt(item.Index);
                }
                item_name_text.Clear();
                item_quantity_text.Clear();
                foreach (DataGridViewRow row in stock_in_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sum = 0;
                        for (int i = 0; i < stock_in_view.Rows.Count; i++)
                        {

                            sum += Convert.ToInt32(stock_in_view.Rows[i].Cells[9].Value);

                        }
                    total_text.Text = Convert.ToString(sum);

                }
                
            }
        }

        private void stock_in_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_name_text.Text = stock_in_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                item_quantity_text.Text = stock_in_view.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
