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
    public partial class Profile_Customer_Vehicle : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        Profile_Customer g;
        String category;
        int vehiclecategory;

        public Profile_Customer_Vehicle()
        {
            InitializeComponent();
             main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // Insert add function
            if (plate_input.Text == "" || category == "" || owner_input.Text == "" || vehicle_make_input.Text == "" || vehicle_model_input.Text == "" || year.Text=="")
            {
                MessageBox.Show("Please input required field.");
            }
            else
            {

                string j = "select * from vehicle where plate_number = '" + plate_input.Text + "'";
                DataTable dt = new DataTable();
                dt = main.SELECT_Statement(j);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Vehicle Already Exists!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query =
                        "set foreign_key_checks=0;" +
                        "INSERT INTO vehicle(plate_number,cust_id_vehicle_fk,vehicle_type_fk,vehicle_make,vehicle_model, vehicle_year)" +
                         "VALUES('" + plate_input.Text + "','" + cust_id.Text + "','" + vehiclecategory + "','" + vehicle_make_input.Text + "','" + vehicle_model_input.Text + "','" + year.Text + "');" +
                         "set foreign_key_checks=1;";
                    main.CUD_Statement(query);
                    MessageBox.Show("Vehicle Added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Profile_Customer g = new Profile_Customer();
                    g.Show();
                    this.Hide();
                }
            }
            
        }

        private void Profile_Vehicle_Customer_Load(object sender, EventArgs e)
        {
            cust_id.Text = Profile_Customer.pass_owner;
            owner_input.Text = Profile_Customer.pass_ownerfname +" " +Profile_Customer.pass_ownerlname;            
        }
        public void getvehiclecategory()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select vehicle_type_id FROM vehicle_type WHERE vehicle_category='" + category + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string ans = sdr.GetString("vehicle_type_id");
                vehiclecategory = int.Parse(ans);
            }
            Conn.Close();
        }

        private void sedan_CheckedChanged(object sender, EventArgs e)
        {
            category = "Sedan";
            getvehiclecategory();
        }

        private void suv_CheckedChanged(object sender, EventArgs e)
        {
            category = "SUV";
            getvehiclecategory();
        }

        private void hatchback_CheckedChanged(object sender, EventArgs e)
        {
            category = "Hatchback";
            getvehiclecategory();
        }

        private void coupe_CheckedChanged(object sender, EventArgs e)
        {
            category = "Coupe";
            getvehiclecategory();
        }

        private void pickup_CheckedChanged(object sender, EventArgs e)
        {
            category = "Pickup";
            getvehiclecategory();
        }

        private void van_CheckedChanged(object sender, EventArgs e)
        {
            category = "Van";
            getvehiclecategory();
        }

        private void bus_CheckedChanged(object sender, EventArgs e)
        {
            category = "Bus";
            getvehiclecategory();
        }

        private void six_wheel_CheckedChanged(object sender, EventArgs e)
        {
            category = "6-Wheeler";
            getvehiclecategory();
        }

        private void eight_wheel_CheckedChanged(object sender, EventArgs e)
        {
            category = "8-Wheeler";
            getvehiclecategory();
        }

        private void tenth_wheel_CheckedChanged(object sender, EventArgs e)
        {
            category = "10-Wheeler";
            getvehiclecategory();
        }

        private void twelve_wheel_CheckedChanged(object sender, EventArgs e)
        {
            category = "12-Wheeler";
            getvehiclecategory();
        }

        private void eighteen_wheel_CheckedChanged(object sender, EventArgs e)
        {
            category = "18-Wheeler";
            getvehiclecategory();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Profile_Customer g = new Profile_Customer();
            g.Show();
            this.Hide();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // Insert reset function

            plate_input.Clear();
            //insert code for deselecting all radio buttons
            vehicle_make_input.Clear();
            vehicle_model_input.Clear();
            add_button.Enabled = true;
            this.add_button.BackColor= Color.SeaGreen;
            this.add_button.ForeColor = Color.White;
        }
    }
}
