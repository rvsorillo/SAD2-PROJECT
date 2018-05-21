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
    public partial class Job_Order_Labor : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static int jid;
        public Job_Order_Labor()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }


        public void disp_labor()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.service_type, concat (emp_fname,' ',emp_lname) as emp_full,labor_fee, job_order_services_id from job_order_services js, service s, job_order j, employee e where js.job_order_id_serv_fk=j.job_order_id and js.service_type_job_order_fk = s.service_id and js.emp_id_job_order_fk=e.emp_id and emp_id_job_order_fk is not null and j.job_order_id='" + Job_Order_Details.jobid + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            labor_view.DataSource = dt;
            labor_view.Columns[0].HeaderText = "Service Type";
            labor_view.Columns[1].HeaderText = "Employee Name";
            labor_view.Columns[2].HeaderText = "Labor Fee";
            labor_view.Columns[3].HeaderText = "JID";
            labor_view.Columns[3].Visible = false;


            Conn.Close();
        }
        int newans = 0;
        private void Job_Order_Labor_Load(object sender, EventArgs e)
        {
            disp_labor();
           
        }
        
        private void labor_fee_button_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < labor_view.Rows.Count; a++)
            {
                if (Convert.ToString(labor_view.Rows[a].Cells[1].Value) == string.Empty)
                {

                }
                else
                {
                    Conn.Open();
                    MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set labor_fee=@labf, subtotal_job_order=(service_fee + @labf) where job_order_services_id=@jid; set foreign_key_checks=1;", Conn);
                    cmd2.Parameters.AddWithValue("@labf", labor_view.Rows[a].Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@jid", labor_view.Rows[a].Cells[3].Value);
                    cmd2.ExecuteNonQuery();
                    Conn.Close();


                }

            }
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select subtotal_job_order from job_order_services where job_order_id_serv_fk ='" + Job_Order_Details.jobid + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            views.DataSource = dt;
            foreach (DataGridViewRow row in views.Rows)
            {
                if (row.IsNewRow) continue;
                int sum = 0;
                for (int i = 0; i < views.Rows.Count; i++)
                {

                    sum += Convert.ToInt32(views.Rows[i].Cells[0].Value);

                }
                newans = sum;

            }

            string q="set foreign_key_checks=0; update job_order set total_amount='"+newans+"' where job_order_id='"+Job_Order_Details.jobid+"'; set foreign_key_checks=1;";
            main.CUD_Statement(q);
            string q2 = "set foreign_key_checks=0; insert into job_order_payment (balance, jp_job_order_id) values('" +newans + "','" +Job_Order_Details.jobid+"');  set foreign_key_checks=1;";
            main.CUD_Statement(q2);
            Conn.Close();
        Job_Order_Details g = new Job_Order_Details();
        g.Show();
        this.Hide();
    }
        
        private void cancel_button_Click(object sender, EventArgs e)
        {
            Job_Order_Details g = new Job_Order_Details();
            g.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.labor_view.SelectedRows)
            {
                item.Cells[2].Value = fee_number.Text;
            }
        }
        private void labor_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
