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
    public partial class Profile_Vehicle : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;

        string category;
        int custid;
        int vehiclecategory;
        public Profile_Vehicle()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");


        }



        private void Profile_Vehicle_Load(object sender, EventArgs e)
        {
            // Display view function
            disp_vehicle();
            disp_vehicle_checked_in();
            combobox_owner();
        }



        public void disp_vehicle()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT v.plate_number, v.vehicle_make, v.vehicle_model, vt.vehicle_category, concat(c.cust_fname,' ',c.cust_lname) as custfull, c.cust_id, v.vehicle_year from vehicle v, customer c, vehicle_type vt where v.vehicle_type_fk=vt.vehicle_type_id and v.cust_id_vehicle_fk=c.cust_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            vehicle_view.DataSource = dt;
            Conn.Close();
            vehicle_view.Columns[0].HeaderText = "Plate #";
            vehicle_view.Columns[1].HeaderText = "Make";
            vehicle_view.Columns[2].HeaderText = "Model";
            vehicle_view.Columns[3].HeaderText = "Category";
            vehicle_view.Columns[4].HeaderText = "Owner";
            vehicle_view.Columns[5].Visible = false;
            vehicle_view.Columns[6].HeaderText = "Year";

        }
        public void disp_vehicle_checked_in()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct v.plate_number, v.vehicle_make, v.vehicle_model, vt.vehicle_category, concat(c.cust_fname,' ',c.cust_lname) as custfull, c.cust_id, v.vehicle_year from vehicle v, customer c, vehicle_type vt,job_order jo where v.vehicle_type_fk = vt.vehicle_type_id and v.plate_number= jo.plate_number_fk and v.cust_id_vehicle_fk = c.cust_id and jo.status_type_id_fk != '3';  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            checked_in_view.DataSource = dt;
            Conn.Close();
            checked_in_view.Columns[0].HeaderText = "Plate #";
            checked_in_view.Columns[1].HeaderText = "Make";
            checked_in_view.Columns[2].HeaderText = "Model";
            checked_in_view.Columns[3].HeaderText = "Category";
            checked_in_view.Columns[4].HeaderText = "Owner";
            checked_in_view.Columns[5].Visible=false;
            checked_in_view.Columns[6].HeaderText = "Year";
        }

        private void combobox_owner()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT concat(cust_fname,' ',cust_lname) as custfull FROM customer;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
           owner_input.Items.Add("");
            while (dr.Read())
            {
                owner_input.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = owner_input.Text;


            int index = owner_input.FindString(actual);
            if (index > -1)
            {
                string found = owner_input.Items.ToString();

                owner_input.SelectionStart = actual.Length;
                owner_input.SelectionLength = found.Length;
                owner_input.SelectedIndex = index;
            }

        }

    




        public void disp_history()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string plate_number = plate_input.Text;
            cmd.CommandText = "SELECT v.plate_number, s.service_type, concat(e.emp_fname,' ',e.emp_lname) as emp_full, jo.time_started_serv, jo.time_ended_serv FROM job_order_services jo, job_order j, employee e, vehicle v, service s WHERE jo.emp_id_job_order_fk=e.emp_id  AND jo.service_type_job_order_fk=s.service_id and j.job_order_id=jo.job_order_id_serv_fk and j.plate_number_fk = v.plate_number and plate_number='" + plate_number + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_history_view.DataSource = dt;
            Conn.Close();
            job_order_history_view.Columns[0].HeaderText = "Plate Number";
            job_order_history_view.Columns[0].Visible = false;
            job_order_history_view.Columns[1].HeaderText = "Service";
            job_order_history_view.Columns[2].HeaderText = "Employee";
            job_order_history_view.Columns[3].HeaderText = "Started";
            job_order_history_view.Columns[4].HeaderText = "Ended";
        }

        private void job_order_history_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void checked_in_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
        private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
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
                vehiclecattext.Text= sdr.GetString("vehicle_type_id"); 
                string ans = sdr.GetString("vehicle_type_id");
                vehiclecategory = int.Parse(ans);
            }
            Conn.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // Insert add function
            if (plate_input.Text == "" || category == "" || owner_input.Text == "" || vehicle_make_input.Text == "" || vehicle_model_input.Text == "" || year.Text == string.Empty)
            {
                MessageBox.Show("Please input required field.");
            }
            else if (owner_input.Items.Contains(owner_input.Text) == false)
            {
                MessageBox.Show("Please select an owner from list");
                owner_input.Text = string.Empty;
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
                         "VALUES('" + plate_input.Text + "','" + custid + "','" + vehiclecategory + "','" + vehicle_make_input.Text + "','" + vehicle_model_input.Text + "','" + year.Text + "');" +
                         "set foreign_key_checks=1;";
                    main.CUD_Statement(query);
                    MessageBox.Show("Vehicle Added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    job_order_history_view.DataSource = null;
                    disp_vehicle();
                    disp_vehicle_checked_in();
                    plate_input.Clear();
                    owner_input.Text = string.Empty;
                    //insert code for deselecting all radio buttons
                    vehicle_make_input.Clear();
                    vehicle_model_input.Clear();
                    year.Clear();
                }
            }
        }

        private void owner_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            owner_input.DropDownStyle = ComboBoxStyle.DropDown;
            owner_input.AutoCompleteSource = AutoCompleteSource.ListItems;
            owner_input.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cust_id from customer where concat(cust_fname,' ',cust_lname)='" + owner_input.SelectedText + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("cust_id");
                custid = Convert.ToInt32(id);
            }
            Conn.Close();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // Insert reset function
            job_order_history_view.DataSource = null;
            plate_input.Clear();
            owner_input.Text = string.Empty;
            //insert code for deselecting all radio buttons
            vehicle_make_input.Clear();    
            vehicle_model_input.Clear();
            add_button.Enabled = true;
            this.add_button.BackColor= Color.SeaGreen;
            this.add_button.ForeColor = Color.White;
            year.Clear();
            job_order_history_view.Columns.Clear();
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            if (plate_input.Text == "" && category == "" && owner_input.Text == "" | vehicle_make_input.Text == "" || vehicle_model_input.Text == "")
            {
                MessageBox.Show("Please input required field.");
            }

            else if (plate_input.Text == String.Empty)
            {
                MessageBox.Show("Enter Plate Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (category == String.Empty)
            {
                MessageBox.Show("Enter Category!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (owner_input.Text == String.Empty)
            {
                MessageBox.Show("Enter Owner Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (vehicle_make_input.Text == String.Empty)
            {
                MessageBox.Show("Enter Vehicle Make!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (year.Text == String.Empty)
            {
                MessageBox.Show("Enter Model Year of Vehicle!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string y = "select * from vehicle where plate_number= '" + plate_input.Text + "'";
            DataTable dt = new DataTable();
            dt = main.SELECT_Statement(y);
            if (dt.Rows.Count > 1)
            {
                MessageBox.Show("Plate Number Already Exists!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string query = " UPDATE vehicle set vehicle_make ='" + vehicle_make_input.Text + "',vehicle_model ='" + vehicle_model_input.Text + "',cust_id_vehicle_fk ='" + custid + "', vehicle_type_fk ='" + vehiclecategory + "', vehicle_year='" + year.Text + "' where plate_number = '" + plate_input.Text + "'";
                main.CUD_Statement(query);
                MessageBox.Show("Vehicle Updated!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                job_order_history_view.DataSource = null;
                disp_vehicle();
                disp_vehicle_checked_in();
                plate_input.Clear();
                year.Clear();
                owner_input.Text = string.Empty;
                //insert code for deselecting all radio buttons
                vehicle_make_input.Clear();
                vehicle_model_input.Clear();
            }
        }
        private void vehicle_view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                year.Text= vehicle_view.Rows[e.RowIndex].Cells["vehicle_year"].Value.ToString();
                plate_input.Text = vehicle_view.Rows[e.RowIndex].Cells["plate_number"].Value.ToString();
                owner_input.Text = vehicle_view.Rows[e.RowIndex].Cells[4].Value.ToString();
                vehicle_model_input.Text = vehicle_view.Rows[e.RowIndex].Cells["vehicle_model"].Value.ToString();
                vehicle_make_input.Text = vehicle_view.Rows[e.RowIndex].Cells["vehicle_make"].Value.ToString();
                category = vehicle_view.Rows[e.RowIndex].Cells["vehicle_category"].Value.ToString();
                custid= Convert.ToInt32(vehicle_view.Rows[e.RowIndex].Cells[5].Value.ToString());
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                switch (category)
                {
                    case "Sedan":
                        sedan.PerformClick();
                        break;
                    case "SUV":
                        suv.PerformClick();
                        break;
                    case "Hatchback":
                        hatchback.PerformClick();
                        break;
                    case "Coupe":
                        coupe.PerformClick();
                        break;
                    case "Pickup":
                        pickup.PerformClick();
                        break;
                    case "Van":
                        van.PerformClick();
                        break;
                    case "Bus":
                        bus.PerformClick();
                        break;
                    case "6-Wheeler":
                        six_wheel.PerformClick();
                        break;
                    case "8-Wheeler":
                        eight_wheel.PerformClick();
                        break;
                    case "10-Wheeler":
                        tenth_wheel.PerformClick();
                        break;
                    case "12-Wheeler":
                        twelve_wheel.PerformClick();
                        break;
                    case "18-Wheeler":
                        eighteen_wheel.PerformClick();
                        break;
                }
            }

            disp_history();
        }

        private void checked_in_view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                year.Text = checked_in_view.Rows[e.RowIndex].Cells["vehicle_year"].Value.ToString();
                plate_input.Text = checked_in_view.Rows[e.RowIndex].Cells["plate_number"].Value.ToString();
                owner_input.Text = checked_in_view.Rows[e.RowIndex].Cells[4].Value.ToString();
                vehicle_model_input.Text = checked_in_view.Rows[e.RowIndex].Cells["vehicle_model"].Value.ToString();
                vehicle_make_input.Text = checked_in_view.Rows[e.RowIndex].Cells["vehicle_make"].Value.ToString();
                category = checked_in_view.Rows[e.RowIndex].Cells["vehicle_category"].Value.ToString();
                custid = Convert.ToInt32(vehicle_view.Rows[e.RowIndex].Cells[5].Value.ToString());
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                switch (category)
                {
                    case "Sedan":
                        sedan.PerformClick();
                        break;
                    case "SUV":
                        suv.PerformClick();
                        break;
                    case "Hatchback":
                        hatchback.PerformClick();
                        break;
                    case "Coupe":
                        coupe.PerformClick();
                        break;
                    case "Pickup":
                        pickup.PerformClick();
                        break;
                    case "Van":
                        van.PerformClick();
                        break;
                    case "Bus":
                        bus.PerformClick();
                        break;
                    case "6-Wheeler":
                        six_wheel.PerformClick();
                        break;
                    case "8-Wheeler":
                        eight_wheel.PerformClick();
                        break;
                    case "10-Wheeler":
                        tenth_wheel.PerformClick();
                        break;
                    case "12-Wheeler":
                        twelve_wheel.PerformClick();
                        break;
                    case "18-Wheeler":
                        eighteen_wheel.PerformClick();
                        break;
                }
            }
            disp_history();
        }
    }
       

}
