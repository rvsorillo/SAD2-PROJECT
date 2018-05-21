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
    public partial class Profile_Supplier : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string pass_supplier;
        public static string pass_supplier_name;
        public Profile_Supplier()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        private void Profile_Supplier_Load(object sender, EventArgs e)
        {
        // Display view function
            disp_data();
        }

        // Display data on gridview
        public void disp_data()
        {
            string query = "SELECT * FROM supplier";

            DataTable dt = new DataTable();
            dt = main.SELECT_Statement(query);
            supplier_view.DataSource = dt;                          // MA VIEW SA DATAGRID ANG MGA VALUES*/
            supplier_view.Columns[0].Visible = false;
            supplier_view.Columns["supplier_name"].HeaderText = "Name";
            supplier_view.Columns["supplier_contact_person"].HeaderText = "Contact Person";
            supplier_view.Columns["supplier_contact"].HeaderText = "Contact Number";
            supplier_view.Columns["supplier_address"].HeaderText = "Address";

        }

            private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // insert add function

            if (supplier_name_text.Text == "" || supplier_contact_person.Text == "" || supplier_contact_text.Text == "" || supplier_address_text.Text == "")
            {
                MessageBox.Show("Please input required field.");
            }
            else
            {

                string y = "select * from supplier where supplier_name = '" + supplier_name_text.Text + "'";
                DataTable dt = new DataTable();
                dt = main.SELECT_Statement(y);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Supplier Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query =
                        "INSERT INTO supplier(supplier_name,supplier_contact_person,supplier_contact,supplier_address)" +
                         "VALUES('" + supplier_name_text.Text + "','" + supplier_contact_person.Text + "','" + supplier_contact_text.Text + "','" + supplier_address_text.Text + "')";
                    main.CUD_Statement(query);
                    MessageBox.Show("ADDED!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();

                }
            }
            supplier_name_text.Clear();
            supplier_contact_person.Clear();
            supplier_contact_text.Clear();
            supplier_address_text.Clear();
            item_view.DataSource = null;

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // insert reset function
            add_button.Enabled = true;
            item_view.DataSource = null;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.ForeColor = System.Drawing.Color.Black; supplier_id.Clear();
            add_item_button.Enabled = false;
            this.add_button.ForeColor = System.Drawing.Color.Black;
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_item_button.BackColor = System.Drawing.Color.Gray;
            this.add_item_button.ForeColor = System.Drawing.Color.Black;
            supplier_name_text.Clear();
            supplier_contact_person.Clear();    
            supplier_contact_text.Clear();
            supplier_address_text.Clear();
            update_button.Enabled = false;
        }

      

        public void disp_item()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT i.item_name, it.item_type, i.item_selling_price, i.item_purchase_price  from item i, item_type it where i.item_type_id_fk=it.item_type_id and i.supplier_id_item_fk='" +supplier_id.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view.DataSource = dt;
            Conn.Close();
            item_view.Columns[0].HeaderText = "Item Name";
            item_view.Columns[1].HeaderText = "Type";
            item_view.Columns[2].HeaderText = "Selling Price";
            item_view.Columns[3].HeaderText = "Purchase Price";

        }

        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
            if (supplier_view.Rows.Count > 0)
            {
                Profile_Supplier_Item g = new Profile_Supplier_Item();
                pass_supplier = supplier_id.Text;
                pass_supplier_name = supplier_name_text.Text;
                g.Show();
                this.Hide();

            }
        }

        private void supplier_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                supplier_id.Text = supplier_view.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
                supplier_name_text.Text = supplier_view.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
                supplier_contact_person.Text = supplier_view.Rows[e.RowIndex].Cells["supplier_contact_person"].Value.ToString();
                supplier_contact_text.Text = supplier_view.Rows[e.RowIndex].Cells["supplier_contact"].Value.ToString(); 
                supplier_address_text.Text = supplier_view.Rows[e.RowIndex].Cells["supplier_address"].Value.ToString();
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                add_item_button.Enabled = true;
                this.add_item_button.UseVisualStyleBackColor = true;
                this.add_item_button.ForeColor = System.Drawing.Color.White;
                update_button.Enabled = true;

            }
            disp_item();
        }

        int current;
        private void update_button_Click_1(object sender, EventArgs e)
        {
            // insert update function
            if (supplier_name_text.Text == "" || supplier_contact_person.Text == "" || supplier_contact_text.Text == "" || supplier_address_text.Text == "")
            {
                MessageBox.Show("Please input required field.");
            }
            else
            {
                current = supplier_view.CurrentRow.Index;
                int id = Convert.ToInt32(supplier_view.Rows[current].Cells[0].Value);
                string query = " UPDATE supplier set supplier_name ='" + supplier_name_text.Text + "',supplier_contact_person ='" + supplier_contact_person.Text + "',supplier_contact ='" + supplier_contact_text.Text + "',supplier_address ='" + supplier_address_text.Text + "' where supplier_id = '" + id + "'";
                    main.CUD_Statement(query);
                    MessageBox.Show("Supplier Updated!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();
              
            }
            supplier_name_text.Clear();
            supplier_contact_person.Clear();
            supplier_contact_text.Clear();
            supplier_address_text.Clear();
            item_view.DataSource = null;

        }

        private void supplier_contact_text_KeyPress(object sender, KeyPressEventArgs e)
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
