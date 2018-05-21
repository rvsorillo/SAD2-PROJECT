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

    public partial class Profile_Customer : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Profile_Customer()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }
        public static string pass_owner;
        public static string pass_ownerfname;
        public static string pass_ownerlname;

        public void disp_data()
        {


            
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CUSTOMER;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            customer_view.DataSource = dt;
            Conn.Close();

            customer_view.Columns[0].HeaderText = "ID";
            customer_view.Columns[0].Visible = false;
            customer_view.Columns[1].HeaderText = "Firstname";
            customer_view.Columns[2].HeaderText = "Lastname";
            customer_view.Columns[3].HeaderText = "Contact";
            customer_view.Columns[4].HeaderText = "Address";
            customer_view.Columns[5].HeaderText = "Company";


        }

        // Display Data on Data grid


        private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // Insert add function
            if (cust_firstname_text.Text == string.Empty || cust_lastname_text.Text == string.Empty || cust_contact_text.Text == string.Empty || cust_address_text.Text == string.Empty)
            {
                MessageBox.Show("Please Input All Required Fields.");
            }
            else if (cust_firstname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Firstname!");
            }
            else if (cust_lastname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Lastname!");

            }
            else if (cust_contact_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Contact Number!");
            }
            else if (cust_address_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Address!");
            }
            else if (!cust_contact_text.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Contact is Invalid. Please Use numbers only.");
                cust_contact_text.Clear();
            }
            else
            {
                
                if (company_name.Text == string.Empty)
                {
                    string query =
                        "INSERT INTO customer(cust_fname,cust_lname,cust_contact,cust_address)" +
                         "VALUES('" + cust_firstname_text.Text + "','" + cust_lastname_text.Text + "','" + cust_contact_text.Text + "','" + cust_address_text.Text + "')";
                    main.CUD_Statement(query);

                }
                else
                {
                    string query =
                        "INSERT INTO customer(cust_fname,cust_lname,cust_contact,cust_address, company_name)" +
                         "VALUES('" + cust_firstname_text.Text + "','" + cust_lastname_text.Text + "','" + cust_contact_text.Text + "','" + cust_address_text.Text + "','" +company_name.Text +"')";
                    main.CUD_Statement(query);
                }
                MessageBox.Show("Customer added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disp_data();
                cust_firstname_text.Clear();
                cust_lastname_text.Clear();
                cust_contact_text.Clear();
                cust_address_text.Clear();
                company_name.Clear();
                disp_data();
                foreach (DataGridViewColumn column in customer_view.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
         

        }

        int current;
        private void update_button_Click(object sender, EventArgs e)
        {
            // Insert update function
            if (cust_firstname_text.Text == string.Empty || cust_lastname_text.Text == string.Empty || cust_contact_text.Text == string.Empty || cust_address_text.Text == string.Empty)
            {
                MessageBox.Show("Please Input All Required Fields.");
            }
            else if (cust_firstname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Firstname!");
            }
            else if (cust_lastname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Lastname!");

            }
            else if (cust_contact_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Contact Number!");
            }
            else if (cust_address_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Address!");
            }
            else if (!cust_contact_text.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Contact is Invalid. Please Use numbers only.");
                cust_contact_text.Clear();
            }
            else
            {
                current = customer_view.CurrentRow.Index;
                int id =Convert.ToInt32(customer_view.Rows[current].Cells[0].Value);
                if (company_name.Text == string.Empty)
                {
                    string query = " UPDATE customer set cust_fname ='" + cust_firstname_text.Text + "',cust_lname ='" + cust_lastname_text.Text + "',cust_contact ='" + cust_contact_text.Text + "',cust_address ='" + cust_address_text.Text + "' ,company_name=null where cust_id = '" + id + "'";
                    main.CUD_Statement(query);
                }
                else
                {
                    string query = " UPDATE customer set cust_fname ='" + cust_firstname_text.Text + "',cust_lname ='" + cust_lastname_text.Text + "',cust_contact ='" + cust_contact_text.Text + "',cust_address ='" + cust_address_text.Text + "',company_name='" + company_name.Text + "' where cust_id = '" + id + "'";
                    main.CUD_Statement(query);
                }
                add_vehicle_button.Enabled = false;
                cust_firstname_text.Clear();
                cust_lastname_text.Clear();
                cust_contact_text.Clear();
                cust_address_text.Clear();
                company_name.Clear();
                disp_data();
                foreach (DataGridViewColumn column in customer_view.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


            }
          

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // Insert reset function

            txtid.Clear();
            cust_firstname_text.Clear();
            cust_lastname_text.Clear();     // WALA PA NAGA GANA*/
            cust_contact_text.Clear();
            cust_address_text.Clear();
            company_name.Clear();
            add_button.Enabled = true;
            add_vehicle_button.Enabled = false;
            vehicle_view.Columns.Clear();
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_vehicle_button.BackColor = System.Drawing.Color.Gray;
            this.add_vehicle_button.ForeColor = System.Drawing.Color.Black;
            update_button.Enabled = false;

        }

        private void customer_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = customer_view.Rows[e.RowIndex].Cells["cust_id"].Value.ToString();
                cust_firstname_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_fname"].Value.ToString();
                cust_lastname_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_lname"].Value.ToString();
                cust_contact_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_contact"].Value.ToString();
                cust_address_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_address"].Value.ToString();
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.Gray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                add_vehicle_button.Enabled = true;
                this.add_button.BackColor = System.Drawing.Color.Gray;
                this.add_vehicle_button.ForeColor = System.Drawing.Color.White;
            }
            disp_vehicle();
        }

        private void vehicle_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_vehicle()
        {
            
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String cust_id = txtid.Text;
            cmd.CommandText = "SELECT V.plate_number,V.vehicle_make, V.vehicle_model, VT.vehicle_category FROM VEHICLE V,VEHICLE_TYPE VT where V.cust_id_vehicle_fk='" + cust_id + "' AND V.vehicle_type_fk=VT.vehicle_type_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            vehicle_view.DataSource = dt;
            Conn.Close();
            vehicle_view.Columns[0].HeaderText = "Plate Number";
            vehicle_view.Columns[1].HeaderText = "Make";
            vehicle_view.Columns[2].HeaderText = "Model";
            vehicle_view.Columns[3].HeaderText = "Category";

            foreach (DataGridViewColumn column in vehicle_view.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Profile_Customer_Load(object sender, EventArgs e)
        {
            // Call view function
            disp_data();

            foreach (DataGridViewColumn column in customer_view.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void add_vehicle_button_Click(object sender, EventArgs e)
        {
            if (customer_view.Rows.Count > 0)
            {
                Profile_Customer_Vehicle g = new Profile_Customer_Vehicle();
                pass_owner = txtid.Text;
                pass_ownerfname = cust_firstname_text.Text;
                pass_ownerlname = cust_lastname_text.Text;
                g.Show();
                this.Hide();

            }
        }

        private void cust_contact_text_KeyPress(object sender, KeyPressEventArgs e)
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

        private void customer_view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = customer_view.Rows[e.RowIndex].Cells["cust_id"].Value.ToString();
                cust_firstname_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_fname"].Value.ToString();
                cust_lastname_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_lname"].Value.ToString();
                cust_contact_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_contact"].Value.ToString();
                cust_address_text.Text = customer_view.Rows[e.RowIndex].Cells["cust_address"].Value.ToString();
                company_name.Text = customer_view.Rows[e.RowIndex].Cells["company_name"].Value.ToString();
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                add_vehicle_button.Enabled = true;
                this.add_vehicle_button.BackColor = System.Drawing.Color.Gray;
                this.add_vehicle_button.ForeColor = System.Drawing.Color.White;
                update_button.Enabled = true;

            }
            disp_vehicle();
        }
    }
    }

