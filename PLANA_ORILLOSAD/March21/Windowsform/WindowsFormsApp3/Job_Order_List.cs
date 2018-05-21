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
    public partial class Job_Order_List : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static string jid;

        public Job_Order_List()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        public void disp_data()
        {
            // KAY DUEY
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id order by status_type_id_fk asc, req_check_out desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_view.DataSource = dt;
            Conn.Close();
            job_order_view.Columns[0].HeaderText = "Job Order ID";
            job_order_view.Columns[1].HeaderText = "Plate Number";
            job_order_view.Columns[2].HeaderText = "Check-in Date";
            job_order_view.Columns[3].HeaderText = "Requested Check-out Date";
            job_order_view.Columns[4].HeaderText = "Check-out Date";
            job_order_view.Columns[5].HeaderText = "Status";
            foreach (DataGridViewRow row in job_order_view.Rows)
            {
                for (int a = 0; a < job_order_view.Rows.Count; a++)
                {
                    if (Convert.ToString(job_order_view.Rows[a].Cells[5].Value) == "Past Deadline")
                    {
                        job_order_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;



                    }
                    else if (Convert.ToString(job_order_view.Rows[a].Cells[5].Value) == "Finished")
                    {
                        job_order_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;

                    }
                    else
                    {
     
                        job_order_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                    }
                }
            }


        }
        public void disp_pastdeadline()
        {
            // KAY DUEY
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id and s.status_type='Past Deadline' order by status_type_id_fk asc, req_check_out desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            past_deadline_view.DataSource = dt;
            Conn.Close();
            past_deadline_view.Columns[0].HeaderText = "Job Order ID";
            past_deadline_view.Columns[1].HeaderText = "Plate Number";
            past_deadline_view.Columns[2].HeaderText = "Check-in Date";
            past_deadline_view.Columns[3].HeaderText = "Requested Check-out Date";
            past_deadline_view.Columns[4].HeaderText = "Check-out Date";
            past_deadline_view.Columns[5].HeaderText = "Status";

        }
        public void disp_on_progress()
        {
            // KAY DUEY
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id and s.status_type='On Progress' order by status_type_id_fk asc, req_check_out desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            on_progress_view.DataSource = dt;
            Conn.Close();
            on_progress_view.Columns[0].HeaderText = "Job Order ID";
            on_progress_view.Columns[1].HeaderText = "Plate Number";
            on_progress_view.Columns[2].HeaderText = "Check-in Date";
            on_progress_view.Columns[3].HeaderText = "Requested Check-out Date";
            on_progress_view.Columns[4].HeaderText = "Check-out Date";
            on_progress_view.Columns[5].HeaderText = "Status";
        }
            public void disp_finished()
        {
            
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id and s.status_type='Finished' order by status_type_id_fk asc, req_check_out desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            finished_view.DataSource = dt;
            Conn.Close();
            finished_view.Columns[0].HeaderText = "Job Order ID";
            finished_view.Columns[1].HeaderText = "Plate Number";
            finished_view.Columns[2].HeaderText = "Check-in Date";
            finished_view.Columns[3].HeaderText = "Requested Check-out Date";
            finished_view.Columns[4].HeaderText = "Check-out Date";
            finished_view.Columns[5].HeaderText = "Status";
        }

        public void disp_released()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id and s.status_type='Released' order by status_type_id_fk asc, req_check_out desc;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            released_view.DataSource = dt;
            Conn.Close();
            released_view.Columns[0].HeaderText = "Job Order ID";
            released_view.Columns[1].HeaderText = "Plate Number";
            released_view.Columns[2].HeaderText = "Check-in Date";
            released_view.Columns[3].HeaderText = "Requested Check-out Date";
            released_view.Columns[4].HeaderText = "Check-out Date";
            released_view.Columns[5].HeaderText = "Status";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage g = new Homepage();
            g.Show();
            this.Hide();
        }

        public void trunc()
        {
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand("TRUNCATE fetch_inventory;", Conn);
            cmd2.ExecuteNonQuery();
            Conn.Close();
        }

        private void Job_Order_List_Load(object sender, EventArgs e)
        {
           
            disp_data();
            disp_finished();
            disp_on_progress();
            disp_pastdeadline();
            disp_released();
            trunc();


        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Job_Order_Create g = new Job_Order_Create();
            g.Show();
            this.Hide();
        }

        private void job_order_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = job_order_view.Rows[e.RowIndex].Cells["job_order_id"].Value.ToString();
                if (job_order_view.Rows.Count > 0)
                {
                    Job_Order_Details g = new Job_Order_Details();
                    jid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void past_deadline_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = past_deadline_view.Rows[e.RowIndex].Cells["job_order_id"].Value.ToString();
                if (past_deadline_view.Rows.Count > 0)
                {
                    Job_Order_Details g = new Job_Order_Details();
                    jid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void on_progress_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = on_progress_view.Rows[e.RowIndex].Cells["job_order_id"].Value.ToString();
                if (on_progress_view.Rows.Count > 0)
                {
                    Job_Order_Details g = new Job_Order_Details();
                    jid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void finished_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = finished_view.Rows[e.RowIndex].Cells["job_order_id"].Value.ToString();
                if (finished_view.Rows.Count > 0)
                {
                    Job_Order_Details g = new Job_Order_Details();
                    jid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }

        private void released_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtid.Text = released_view.Rows[e.RowIndex].Cells["job_order_id"].Value.ToString();
                if (released_view.Rows.Count > 0)
                {
                    Job_Order_Details g = new Job_Order_Details();
                    jid = txtid.Text;
                    g.Show();
                    this.Hide();

                }
            }
        }
    }
    }

