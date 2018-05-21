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
    public partial class Profile_Supplier_Item : Form
    {
        Class1 main;
        MySqlConnection Conn;
        Profile_Supplier g;
        public Profile_Supplier_Item()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }
        public void fillitembox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from item order by item_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("item_id");
                string one = "1";
                int add = int.Parse(list) + int.Parse(one);
                item_id.Text = Convert.ToString(add);



            }

            Conn.Close();
        }
        private void measure_combo()
        {

            measure_text.Items.Add("Piece");
            measure_text.Items.Add("Quart");
            measure_text.Items.Add("Milliliter");
            measure_text.Items.Add("Liter");
            measure_text.Items.Add("Gallon");
        }

        private void Profile_Supplier_Item_Load(object sender, EventArgs e)
        {
            measure_combo();
            combobox_item();
            supplier_id.Text = Profile_Supplier.pass_supplier;
            item_supplier_text.Text = Profile_Supplier.pass_supplier_name;
            fillitembox();
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
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //add function

            if (item_name_text.Text == "" || item_type_text.Text == "" || item_purchaseprice_text.Text == "" || item_sellingprice_text.Text == "" || item_supplier_text.Text == "")
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
                    string query = "INSERT INTO item(item_name,item_type_id_fk, item_measurement, item_purchase_price,item_selling_price, supplier_id_item_fk, item_brand, item_size)" +
                         "VALUES('" + item_name_text.Text + "','" + typeid + "','" + measure_text.Text + "','" + item_purchaseprice_text.Text + "','" + item_sellingprice_text.Text + "','" + suppid + "','" + brand_text.Text + "','" + item_size.Text + "');";
                    main.CUD_Statement(query);
                    MessageBox.Show("Item Added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Profile_Supplier g = new Profile_Supplier();
                    g.Show();
                    this.Hide();

                }
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //reset function
            item_id.Clear();
            item_name_text.Clear();
            item_purchaseprice_text.Clear();      
            item_sellingprice_text.Clear();
            item_type_text.Text = string.Empty;
            measure_text.Text = string.Empty;
            item_type_id_fk.Clear();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

            Profile_Supplier g = new Profile_Supplier();
            g.Show();
            this.Hide();
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
