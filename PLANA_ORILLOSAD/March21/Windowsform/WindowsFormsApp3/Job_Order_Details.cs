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
    public partial class Job_Order_Details : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        public static int jid;
        public static string tots;
        public Job_Order_Details()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }


        private void Job_Order_Details_Load(object sender, EventArgs e)
        {
           
            if (Job_Order_List.jid != string.Empty)
            {
                job_order_idx.Text = Job_Order_List.jid;
            }
            else if (Job_Order_Update.js != string.Empty)
            {
                job_order_idx.Text = Job_Order_Update.js;
            }
           
            filljodetailsbox();
            fillcustbox();
            fillservices();
            if (status_text.Text == "Released")
            {
                bill_button.Visible = false;
                record_payment_button.Visible = false;
                check_out_input.Visible = true;
                check_out_label.Visible = true;
                update.Visible = false;
                bal_text.Visible = false;
                bal_label.Visible = false;
              
            }
            else if (status_text.Text == "Finished")
            {
                button1.Visible = true;
                bill_button.Visible = true;
                record_payment_button.Visible = true;
                check_out_input.Visible = false;
                check_out_label.Visible = false;
                update.Visible = false;
                bal_text.Visible = true;
                bal_label.Visible = true;
                Conn.Open();
                MySqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select balance from job_order_payment where jp_job_order_id='" + job_order_idx.Text + "' order by date_payment asc";
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    bal_text.Text = sdr.GetString("balance");
                }
                if (bal_text.Text=="" || bal_text.Text =="0")
                {
                    button1.Visible = true;
                    bill_button.Visible = false;
                    record_payment_button.Visible = false;
                }
                Conn.Close();
            }
            else
            {

                bill_button.Visible = false;
                record_payment_button.Visible = false;
                check_out_input.Visible = false;
                check_out_label.Visible = false;
                update.Visible = true;

            }

        
                
        }
        public void filljodetailsbox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select j.job_order_id, v.plate_number, j.problem_reported,j.initial_diagnosis, j.check_in, j.req_check_out, j.check_out, s.status_type, j.total_amount from status_type s, job_order j, vehicle v where j.plate_number_fk=v.plate_number and j.status_type_id_fk=s.status_type_id and j.job_order_id='" + job_order_idx.Text + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                total_text.Text = sdr.GetString("total_amount");
                plate_input.Text = sdr.GetString("plate_number");
                check_in_date_input.Text = sdr.GetString("check_in");
                status_text.Text = sdr.GetString("status_type");
                
                if (sdr.GetString("problem_reported") is null)
                {
                    string value = "";
                    problem_input.Text = value;
                }
                else if (sdr.GetString("problem_reported") != null)
                {
                    problem_input.Text = sdr.GetString("problem_reported");
                }
                if (sdr.GetString("initial_diagnosis") is null)
                {
                    string value = "";
                    diagnosis_input.Text = value;
                }
                else if (sdr.GetString("initial_diagnosis") != null)
                {
                    diagnosis_input.Text = sdr.GetString("initial_diagnosis");
                }
               
                    requested_date_input.Value = sdr.GetDateTime("req_check_out");
             

            }

            Conn.Close();
        }

        public void fillcustbox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select c.cust_fname, c.cust_lname from customer c, vehicle v, job_order j where j.plate_number_fk=v.plate_number and v.cust_id_vehicle_fk=c.cust_id and j.job_order_id='" + job_order_idx.Text + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cust_input.Text = sdr.GetString("cust_fname") + " " + sdr.GetString("cust_lname");
            }

            Conn.Close();
        }

        public void fillservices()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select js.job_order_services_id, s.service_type, js.service_fee, concat (emp_fname,' ',emp_lname) as emp_full, js.labor_fee, js.time_started_serv, js.time_ended_serv, subtotal_job_order from job_order_services js, service s, job_order j, employee e where js.job_order_id_serv_fk=j.job_order_id and js.service_type_job_order_fk = s.service_id and js.emp_id_job_order_fk=e.emp_id and j.job_order_id='" + job_order_idx.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_selected_service_view.DataSource = dt;
            Conn.Close();
            job_order_selected_service_view.Columns[0].HeaderText = "JO Service ID";
            job_order_selected_service_view.Columns[0].Visible = false;
            job_order_selected_service_view.Columns[1].HeaderText = "Service Type";
            job_order_selected_service_view.Columns[2].HeaderText = "Service Fee";
            job_order_selected_service_view.Columns[3].HeaderText = "Employee";
            job_order_selected_service_view.Columns[4].HeaderText = "Labor Fee";
            job_order_selected_service_view.Columns[5].HeaderText = "Time Started";
            job_order_selected_service_view.Columns[6].HeaderText = "Time Ended";
            job_order_selected_service_view.Columns[7].HeaderText = "Subtotal";
            Conn.Close();
        }
        public void fillitems()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ji.job_order_items_id, i.item_name, i.item_measurement,i.item_selling_price, ji.job_order_items_quantity, (ji.job_order_items_quantity * i.item_selling_price) from job_order_items ji, job_order_services js, item i where ji.item_id_job_order_fk=i.item_id and ji.job_order_services_id_fk=js.job_order_services_id and js.job_order_services_id='" + job_order_serviceid.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            item_view.DataSource = dt;
            Conn.Close();
            item_view.Columns[0].HeaderText = "JO Items ID";
            item_view.Columns[0].Visible = false;
            item_view.Columns[1].HeaderText = "Item Name";
            item_view.Columns[2].HeaderText = "Measurement";
            item_view.Columns[3].HeaderText = "Price";
            item_view.Columns[4].HeaderText = "Quantity";
            item_view.Columns[5].HeaderText = "Subtotal";

            Conn.Close();
        }
  

        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static int jobid;
        private void update_Click(object sender, EventArgs e)
        {
            Job_Order_Update g = new Job_Order_Update();
            jobid = Convert.ToInt32(job_order_idx.Text); 
            g.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Job_Order_List g = new Job_Order_List();
            g.Show();
            this.Hide();
        }

        private void job_order_selected_service_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                job_order_serviceid.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells["job_order_services_id"].Value.ToString();
                fillitems();

            }

        }

        private void check_in_date_input_ValueChanged(object sender, EventArgs e)
        {

        }

        private void finish_button_Click(object sender, EventArgs e)
        {

        }

        private void record_payment_button_Click(object sender, EventArgs e)
        {
            Job_Order_Payment g = new Job_Order_Payment();
            jobid = Convert.ToInt32(job_order_idx.Text);
            tots = bal_text.Text;
            g.Show();
        }


        private void bill_button_Click(object sender, EventArgs e)
        {
            jobid = Convert.ToInt32(job_order_idx.Text);
            new Job_Order_Bill(jobid).ShowDialog();
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            Job_Order_View_Payments g = new Job_Order_View_Payments();
            jobid = Convert.ToInt32(job_order_idx.Text);
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job_Order_Labor k = new Job_Order_Labor();
            k.Show();
            this.Hide();
            jobid = Convert.ToInt32(job_order_idx.Text);

        }
    }
}
