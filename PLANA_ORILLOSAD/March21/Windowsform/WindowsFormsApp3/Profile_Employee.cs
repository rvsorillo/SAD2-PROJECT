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
    public partial class Profile_Employee : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Profile_Employee()
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
            cmd.CommandText = "SELECT emp_id,emp_fname, emp_lname, emp_contact, emp_address, emp_bday,emp_type, emp_status, emp_username, emp_password, emp_skills FROM EMPLOYEE, employee_type WHERE employee.emp_type_id_fk=employee_type.emp_type_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            employee_view.DataSource = dt;
            Conn.Close();

            employee_view.Columns[0].HeaderText = "ID";
            employee_view.Columns[0].Visible = false;
            employee_view.Columns[1].HeaderText = "Firstname";
            employee_view.Columns[2].HeaderText = "Lastname";
            employee_view.Columns[3].HeaderText = "Contact";
            employee_view.Columns[4].HeaderText = "Address";
            employee_view.Columns[5].HeaderText = "Birthday";
            employee_view.Columns[6].HeaderText = "Position";
            employee_view.Columns[7].HeaderText = "Status";
            employee_view.Columns[8].Visible = false;
            employee_view.Columns[9].Visible = false;
            employee_view.Columns[10].Visible = false;

            foreach (DataGridViewColumn column in employee_view.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }


        public void disp_task()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select j.job_order_id, j.plate_number_fk, s.service_type, js.time_started_serv from job_order j, job_order_services js, employee e, service s where j.job_order_id=js.job_order_id_serv_fk and js.service_type_job_order_fk=s.service_id  and e.emp_id=js.emp_id_job_order_fk and e.emp_id='" + textid.Text +"' and time_ended_serv is null order by js.time_started_serv asc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            task_view.DataSource = dt;
            Conn.Close();
            task_view.Columns[0].HeaderText = "Job Order ID";
            task_view.Columns[1].HeaderText = "Plate Number";
            task_view.Columns[2].HeaderText = "Service Type";
            task_view.Columns[3].HeaderText = "Time Started";
            foreach (DataGridViewColumn column in task_view.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void disp_alltask()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select j.job_order_id, j.plate_number_fk, s.service_type, js.time_started_serv, js.time_ended_serv from job_order j, job_order_services js, employee e, service s where j.job_order_id=js.job_order_id_serv_fk and js.service_type_job_order_fk=s.service_id and e.emp_id=js.emp_id_job_order_fk and e.emp_id='" + textid.Text + "' order by js.time_started_serv asc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            all_tasks.DataSource = dt;
            Conn.Close();
            all_tasks.Columns[0].HeaderText = "Job Order ID";
            all_tasks.Columns[1].HeaderText = "Plate Number";
            all_tasks.Columns[2].HeaderText = "Service Type";
            all_tasks.Columns[3].HeaderText = "Time Started";
            all_tasks.Columns[4].HeaderText = "Time Ended";
            foreach (DataGridViewColumn column in all_tasks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void Profile_Employee_Load(object sender, EventArgs e)
        {

            disp_data();
            combobox_position();
            disp_alltask();
            status_text.Items.Add("Active");
            status_text.Items.Add("Inactive");
        } 


        private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            // Insert add function
            if (emp_firstname_text.Text == String.Empty && emp_lastname_text.Text == String.Empty && emp_contact_text.Text == String.Empty && emp_address_text.Text == String.Empty && emp_position_text.Text == String.Empty && status_text.Text == string.Empty)
            {
                MessageBox.Show("Please input required field.");
            }
            else if (emp_firstname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Firstname!");
            }
            else if (emp_lastname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Lastname!");
            }
            else if (emp_contact_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Contact Number!");
            }
            else if (emp_address_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Address!");
            }
            else if (emp_position_text.Text == String.Empty)
            {
                MessageBox.Show("Choose Employee Position!");
            }
            else if (!emp_contact_text.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Contact is Invalid. Please Use numbers only.");
                emp_contact_text.Clear();

            }
            else if (status_text.Text == String.Empty)
            {
                MessageBox.Show("Choose Employee Status!");
            }
            else if (emp_position_text.Items.Contains(emp_position_text.Text) == false)
            {
                MessageBox.Show("Please select a position from list");
                emp_position_text.Text = string.Empty;
            }
            else if (status_text.Items.Contains(status_text.Text) == false)
            {
                MessageBox.Show("Please select a status from list");
                status_text.Text = string.Empty;
            }
            else
            {
                string format = "yyyy-MM-dd";
                string query = "INSERT INTO employee(emp_fname, emp_lname, emp_contact, emp_address, emp_bday, emp_type_id_fk, emp_username, emp_password, emp_skills, emp_status)" +
                         "VALUES('" + emp_firstname_text.Text + "','" + emp_lastname_text.Text + "','" + emp_contact_text.Text + "','" + emp_address_text.Text + "','" + date_input.Value.ToString(format) + "','" + positionid.Text + "','" + username_text.Text + "','" + password_text.Text + "','" + skills_text.Text + "','" + status_text.Text + "')";


                main.CUD_Statement(query);
                MessageBox.Show("Employee Added!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data();
                emp_firstname_text.Clear();
                emp_lastname_text.Clear();
                emp_contact_text.Clear();
                emp_address_text.Clear();
                emp_position_text.Text = string.Empty;
                date_input.Value = DateTime.Now;
                skills_panel.Visible = false;
                admin_panel.Visible = false;
                task_view.DataSource = null;
                status_text.Text = string.Empty;

            }

        }

        int current;
        private void update_button_Click(object sender, EventArgs e)
        {
            // Insert update
            if (emp_firstname_text.Text == String.Empty && emp_lastname_text.Text == String.Empty && emp_contact_text.Text == String.Empty && emp_address_text.Text == String.Empty && emp_position_text.Text == String.Empty)
            {
                MessageBox.Show("Please input required field.");
            }
            else if (emp_firstname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Firstname!");
            }
            else if (emp_lastname_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Lastname!");
            }
            else if (emp_contact_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Contact Number!");
            }
            else if (emp_address_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Address!");
            }
            else if (emp_position_text.Text == String.Empty)
            {
                MessageBox.Show("Enter Position!");
            }
            else if (!emp_contact_text.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Contact is Invalid. Please Use numbers only.");
                emp_contact_text.Clear();

            }
            else if (status_text.Text == String.Empty)
            {
                MessageBox.Show("Choose Employee Status!");
            }
            else if (emp_position_text.Items.Contains(emp_position_text.Text) == false)
            {
                MessageBox.Show("Please select a position from list");
                emp_position_text.Text = string.Empty;
            }
            else if (status_text.Items.Contains(status_text.Text) == false)
            {
                MessageBox.Show("Please select a status from list");
                status_text.Text = string.Empty;
            }
            else
            {
                string format = "yyyy-MM-dd";
                current = employee_view.CurrentRow.Index;
                int id = Convert.ToInt32(employee_view.Rows[current].Cells[0].Value);
                string query = " UPDATE employee set emp_fname ='" + emp_firstname_text.Text + "'," +
                    "emp_lname ='" + emp_lastname_text.Text + "',emp_contact ='" + emp_contact_text.Text + "'" +
                    ", emp_address ='" + emp_address_text.Text + "', emp_bday='" + date_input.Value.ToString(format) + "'" +
                    ", emp_type_id_fk ='" + positionid.Text + "', " +
                    "emp_username='" + username_text.Text + "', emp_password='" + password_text.Text + "', " +
                    "emp_skills='" + skills_text.Text + "', emp_status='" + status_text.Text + "' where emp_id = '" + id + "'";
                main.CUD_Statement(query);
                MessageBox.Show("Employee Updated!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data();
                emp_firstname_text.Clear();
                emp_lastname_text.Clear();
                emp_contact_text.Clear();
                emp_address_text.Clear();
                emp_position_text.Text = string.Empty;
                date_input.Value = DateTime.Now;
                skills_panel.Visible = false;
                admin_panel.Visible = false;
                task_view.DataSource = null;
                status_text.Text = string.Empty;


            }


        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            // Insert reset function


            textid.Clear();
            emp_firstname_text.Clear();
            emp_lastname_text.Clear();    
            emp_contact_text.Clear();
            emp_address_text.Clear();
            emp_position_text.Text = string.Empty;
            add_button.Enabled = true;
            task_view.DataSource = null;
            date_input.Value = DateTime.Now;
            this.add_button.ForeColor = System.Drawing.Color.Black;
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.view_task_history_button.BackColor = System.Drawing.Color.Gray;
            this.view_task_history_button.ForeColor = System.Drawing.Color.White;
            skills_panel.Visible = false;
            admin_panel.Visible = false;



        }



        private void combobox_position()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT emp_type FROM employee_type;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            emp_position_text.Items.Add("");
            while (dr.Read())
            {
                emp_position_text.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = emp_position_text.Text;


            int index = emp_position_text.FindString(actual);
            if (index > -1)
            {
                string found = emp_position_text.Items.ToString();

                emp_position_text.SelectionStart = actual.Length;
                emp_position_text.SelectionLength = found.Length;
                emp_position_text.SelectedIndex = index;
            }

        }

        private void emp_position_text_SelectedIndexChanged(object sender, EventArgs e)
        {

            emp_position_text.DropDownStyle = ComboBoxStyle.DropDown;
            emp_position_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            emp_position_text.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // use switch here
            int pos;
            if (emp_position_text.Text == String.Empty) {

                admin_panel.Visible = false;
                skills_panel.Visible = false;
                skills_text.Text = "";

            }
            if (emp_position_text.Text == "Admin")
            {

                skills_panel.Visible = false;
                admin_panel.Visible = true;
                admin_panel.BringToFront();
                pos = 1;
                positionid.Text = Convert.ToString(pos);
                username_text.Text = "";
                password_text.Text = "";
            }
            if (emp_position_text.Text == "Welder")
            {
                admin_panel.Visible = false;
                skills_panel.Visible = true;
                skills_panel.BringToFront();
                pos = 2;
                positionid.Text = Convert.ToString(pos);
                username_text.Text = "";
                password_text.Text = "";

            }
            if (emp_position_text.Text == "Driver")
            {
                admin_panel.Visible = false;
                skills_panel.Visible = true;
                skills_panel.BringToFront();
                pos = 3;
                positionid.Text = Convert.ToString(pos);
                username_text.Text = "";
                password_text.Text = "";

            }

            if (emp_position_text.Text == "Mechanic")
            {
                admin_panel.Visible = false;
                skills_panel.Visible = true;
                skills_panel.BringToFront();
                pos = 4;
                positionid.Text = Convert.ToString(pos);
                username_text.Text = "";
                password_text.Text = "";


            }
           
        }


        



        private void skills_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                textid.Text = employee_view.Rows[e.RowIndex].Cells["emp_id"].Value.ToString();
                status_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_status"].Value.ToString();
                emp_firstname_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_fname"].Value.ToString();
                emp_lastname_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_lname"].Value.ToString();
                emp_contact_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_contact"].Value.ToString();    // PARA MA VIEW ANG MGA DATA SA TEXTBOX*/
                emp_address_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_address"].Value.ToString();
                emp_position_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_type"].Value.ToString();
                username_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_username"].Value.ToString();
                password_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_password"].Value.ToString();
                skills_text.Text = employee_view.Rows[e.RowIndex].Cells["emp_skills"].Value.ToString();
                Conn.Open();
                MySqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select emp_bday from employee where emp_id='" + employee_view.Rows[e.RowIndex].Cells["emp_id"].Value.ToString() + "'";
                DataTable dt = new DataTable();
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    date_input.Value = sdr.GetDateTime("emp_bday");
                }
                Conn.Close();
                add_button.Enabled = false;
                task_view.Columns.Clear();
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                view_task_history_button.Enabled = true;
                this.view_task_history_button.UseVisualStyleBackColor = true;
                this.view_task_history_button.ForeColor = System.Drawing.Color.White;
            }
            disp_task();
        }

        private void employee_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emp_contact_text_KeyPress(object sender, KeyPressEventArgs e)
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

        private void view_task_history_button_Click(object sender, EventArgs e)
        {
            task_panel.Visible = true;
            disp_alltask();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task_panel.Visible = false;
        }
    }
}



