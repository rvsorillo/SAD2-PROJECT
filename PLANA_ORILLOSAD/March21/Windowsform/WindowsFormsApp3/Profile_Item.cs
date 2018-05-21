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
    public partial class Profile_Item : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Profile_Item()
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
           cmd.CommandText = "SELECT i.item_id, i.item_name, i.item_brand, it.item_type, i.item_measurement, i.item_purchase_price, i.item_selling_price, s.supplier_name, i.item_size FROM ITEM i, ITEM_TYPE it, SUPPLIER s WHERE i.supplier_id_item_fk=s.supplier_id AND i.item_type_id_fk=it.item_type_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view.DataSource = dt;
            Conn.Close();

            item_view.Columns[0].HeaderText = "ID";
            item_view.Columns[0].Visible = false;
            item_view.Columns[1].HeaderText = "Name";
            item_view.Columns[2].HeaderText = "Brand";
            item_view.Columns[3].HeaderText = "Type";
            item_view.Columns[4].HeaderText = "Measure";
            item_view.Columns[5].HeaderText = "Purchase Price";
            item_view.Columns[6].HeaderText = "Selling Price";
            item_view.Columns[7].HeaderText = "Supplier";
            item_view.Columns[8].HeaderText = "Size";

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

       
       

        private void add_button_Click(object sender, EventArgs e)
        {
            //add function

            if (item_name_text.Text == "" || item_size.Text == "" || item_type_text.Text == "" || item_purchaseprice_text.Text == "" || item_sellingprice_text.Text == "" || item_supplier_text.Text == "")
            {
                MessageBox.Show("Please input required field.");
            }
            else if (item_type_text.Items.Contains(item_type_text.Text) == false)
            {
                MessageBox.Show("Please select an item type from list");
                item_type_text.Text = String.Empty;
            }
            else if (measure_text.Items.Contains(measure_text.Text) == false)
            {
                MessageBox.Show("Please select a measurement from list");
                measure_text.Text = String.Empty;

            }
            else if (item_supplier_text.Items.Contains(item_supplier_text.Text) == false)
            {
                MessageBox.Show("Please select a supplier from list");
                item_supplier_text.Text = String.Empty;

            }
            else
            {

                string y = "select * from item where item_id = '" + item_id.Text + "'";
                DataTable dt = new DataTable();
                dt = main.SELECT_Statement(y);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Item already exists!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int suppid = Convert.ToInt32(supplier_id.Text);
                    int typeid = Convert.ToInt32(item_type_id_fk.Text);
                    string query =
                        "INSERT INTO item(item_name,item_type_id_fk, item_measurement, item_purchase_price,item_selling_price, supplier_id_item_fk, item_brand, item_size)" +
                         "VALUES('" + item_name_text.Text + "','" + typeid + "','" + measure_text.Text + "','" + item_purchaseprice_text.Text + "','" + item_sellingprice_text.Text + "','" + suppid + "','" + brand_text.Text + "','" + item_size.Text + "');";
                    main.CUD_Statement(query);
                    MessageBox.Show("Item Added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();

                }
            }
            item_id.Clear();
            item_size.Clear();
            item_name_text.Clear();
            item_purchaseprice_text.Clear();
            item_sellingprice_text.Clear();
            brand_text.Clear();
            item_type_text.Text = null;
            measure_text.Text = null;
            item_supplier_text.Text = null;
            item_type_id_fk.Clear();
            supplier_id.Clear();

        }
        int current;
        private void update_button_Click(object sender, EventArgs e)
        {
            //update function
            if (item_name_text.Text == "" || item_size.Text == "" || item_type_text.Text == "" || item_purchaseprice_text.Text == "" || item_sellingprice_text.Text == "" || item_supplier_text.Text == "")
            {
                MessageBox.Show("Please input required field.");
            }
            else if (item_type_text.Items.Contains(item_type_text.Text) == false)
            {
                MessageBox.Show("Please select an item type from list");
                item_type_text.Text = String.Empty;
            }
            else if (measure_text.Items.Contains(measure_text.Text) == false)
            {
                MessageBox.Show("Please select a measurement from list");
                measure_text.Text = String.Empty;

            }
            else if (item_supplier_text.Items.Contains(item_supplier_text.Text) == false)
            {
                MessageBox.Show("Please select a supplier from list");
                item_supplier_text.Text = String.Empty;

            }
            else
            {
                current = item_view.CurrentRow.Index;
                int id = Convert.ToInt32(item_view.Rows[current].Cells[0].Value);
                int suppid = Convert.ToInt32(supplier_id.Text);
                int typeid = Convert.ToInt32(item_type_id_fk.Text);
                string query = "UPDATE item set item_name ='" + item_name_text.Text + "', item_type_id_fk='" + typeid + "', " +
                    "item_measurement ='" + measure_text.Text + "', item_purchase_price = '" + item_purchaseprice_text.Text + "'," +
                    "item_selling_price ='" + item_sellingprice_text.Text + "', supplier_id_item_fk='" + suppid + "', item_brand ='" + brand_text.Text + "' item_size='" + item_size.Text + "' where " +
                    "item_id = '" + id + "';";
                main.CUD_Statement(query);
                MessageBox.Show("Item Updated!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data();



            }
        }

       
        private void reset_button_Click(object sender, EventArgs e)
        {
            //reset function
            item_id.Clear();
            item_name_text.Clear();
            item_purchaseprice_text.Clear();     
            item_sellingprice_text.Clear();
            brand_text.Clear();
            item_type_text.Text = null;
            measure_text.Text = null;
            item_supplier_text.Text = null;
            item_type_id_fk.Clear();
            supplier_id.Clear();
            add_button.Enabled = true;
            item_size.Clear();
            this.add_button.BackColor= System.Drawing.Color.SeaGreen;
            this.add_button.ForeColor = System.Drawing.Color.White;
            update_button.Enabled = false;
        }

        private void Profile_Item_Load(object sender, EventArgs e)
        {
            disp_data();
            combobox_item();
            combobox_supplier();
            measure_combo();
        }

        private void combobox_item()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT item_type FROM item_type;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            item_type_text.Items.Add("");
            while (dr.Read())
            {
                item_type_text.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = item_type_text.Text;


            int index = item_type_text.FindString(actual);
            if (index > -1)
            {
                string found = item_type_text.Items.ToString();

                item_type_text.SelectionStart = actual.Length;
                item_type_text.SelectionLength = found.Length;
                item_type_text.SelectedIndex = index;
            }

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
            item_supplier_text.Items.Add("");
            while (dr.Read())
            {
                item_supplier_text.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = item_supplier_text.Text;


            int index = item_supplier_text.FindString(actual);
            if (index > -1)
            {
                string found = item_supplier_text.Items.ToString();

                item_supplier_text.SelectionStart = actual.Length;
                item_supplier_text.SelectionLength = found.Length;
                item_supplier_text.SelectedIndex = index;
            }

        }
        private void measure_combo()
        {

            measure_text.Items.Add("Piece");
            measure_text.Items.Add("Quart");
            measure_text.Items.Add("Milliliter");
            measure_text.Items.Add("Liter");
            measure_text.Items.Add("Gallon");
        }

        private void item_type_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_type_text.DropDownStyle = ComboBoxStyle.DropDown;
            item_type_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            item_type_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT item_type_id from item_type where item_type='" + item_type_text.SelectedText + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("item_type_id");
                item_type_id_fk.Text = id;
            }
            Conn.Close();
        }

        private void measure_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            measure_text.DropDownStyle = ComboBoxStyle.DropDown;
            measure_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            measure_text.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void item_supplier_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();
            MySqlCommand cmd2 = Conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT supplier_id from supplier where supplier_name='" + item_supplier_text.Text + "'";
            MySqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                string id = sdr2.GetString("supplier_id");
                supplier_id.Text = id;
            }
            Conn.Close();
        }

        private void item_name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                item_size.Text = item_view.Rows[e.RowIndex].Cells["item_size"].Value.ToString();
                item_id.Text = item_view.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                item_name_text.Text = item_view.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
                item_type_text.Text = item_view.Rows[e.RowIndex].Cells["item_type"].Value.ToString();
                brand_text.Text = item_view.Rows[e.RowIndex].Cells["item_brand"].Value.ToString();
                measure_text.Text = item_view.Rows[e.RowIndex].Cells["item_measurement"].Value.ToString();
                item_purchaseprice_text.Text = item_view.Rows[e.RowIndex].Cells["item_purchase_price"].Value.ToString();
                item_sellingprice_text.Text = item_view.Rows[e.RowIndex].Cells["item_selling_price"].Value.ToString();
                item_supplier_text.Text = item_view.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                update_button.Enabled = true;
                Conn.Open();
                MySqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT item_type_id from item_type where item_type='" + item_type_text.Text + "'";
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string id = sdr.GetString("item_type_id");
                    item_type_id_fk.Text = id;
                }
                Conn.Close();
            }
           

        }

        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void item_purchaseprice_text_KeyPress(object sender, KeyPressEventArgs e)
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

        private void item_sellingprice_text_KeyPress(object sender, KeyPressEventArgs e)
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
