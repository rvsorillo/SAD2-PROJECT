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
    public partial class Homepage : Form
    {
        Login_Form g;
        Class1 main;
        MySqlConnection Conn;

        public Homepage()
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
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, concat (c.cust_fname,' ',c.cust_lname) as cust_full, j.check_in, j.req_check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s, vehicle v, customer c where j.status_type_id_fk=s.status_type_id and j.plate_number_fk=v.plate_number and v.cust_id_vehicle_fk=c.cust_id and s.status_type='Past Deadline';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_view.DataSource = dt;
            job_order_view.Columns[0].HeaderText = "Job Order ID";
            job_order_view.Columns[1].HeaderText = "Plate Number";
            job_order_view.Columns[2].HeaderText = "Customer";
            job_order_view.Columns[3].HeaderText = "Check-in";
            job_order_view.Columns[4].HeaderText = "Requested Check-out";
            job_order_view.Columns[5].HeaderText = "Status";
            Conn.Close();
        }
        public void disp_fin()
        {
            // KAY DUEY
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct j.job_order_id, j.plate_number_fk, concat (c.cust_fname,' ',c.cust_lname) as cust_full, j.check_in, j.req_check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s, vehicle v, customer c where j.status_type_id_fk=s.status_type_id and j.plate_number_fk=v.plate_number and v.cust_id_vehicle_fk=c.cust_id and s.status_type='Finished';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            finished_view.DataSource = dt;
            finished_view.Columns[0].HeaderText = "Job Order ID";
            finished_view.Columns[1].HeaderText = "Plate Number";
            finished_view.Columns[2].HeaderText = "Customer";
            finished_view.Columns[3].HeaderText = "Check-in";
            finished_view.Columns[4].HeaderText = "Requested Check-out";
            finished_view.Columns[5].HeaderText = "Status";
            Conn.Close();
        }
        public void all_view()
        {
            // KAY DUEY
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct j.job_order_id, j.plate_number_fk, concat (c.cust_fname,' ',c.cust_lname) as cust_full, j.check_in, j.req_check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s, vehicle v, customer c where j.status_type_id_fk=s.status_type_id and j.plate_number_fk=v.plate_number and v.cust_id_vehicle_fk=c.cust_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            allview.DataSource = dt;
            allview.Columns[0].HeaderText = "Job Order ID";
            allview.Columns[1].HeaderText = "Plate Number";
            allview.Columns[2].HeaderText = "Customer";
            allview.Columns[3].HeaderText = "Check-in";
            allview.Columns[4].HeaderText = "Requested Check-out";
            allview.Columns[5].HeaderText = "Status";
            Conn.Close();
        }
        public void disp_inv()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT i.item_id, i.item_name, it. item_type, i.item_measurement, i.item_selling_price, inv.inventory_quantity, s.supplier_name, s.supplier_contact_person FROM INVENTORY inv, SUPPLIER s, ITEM i, item_type it WHERE inv.item_id_inventory_fk=i.item_id and i.supplier_id_item_fk=s.supplier_id and i.item_type_id_fk=it.item_type_id and inv.inventory_quantity<=10;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            inventory_view.DataSource = dt;
            Conn.Close();
            inventory_view.Columns[0].HeaderText = "Item ID";
            inventory_view.Columns[0].Visible = false;
            inventory_view.Columns[1].HeaderText = "Item Name";
            inventory_view.Columns[2].HeaderText = "Item Type";
            inventory_view.Columns[3].HeaderText = "Measurement";
            inventory_view.Columns[4].HeaderText = "Selling Price";
            inventory_view.Columns[5].HeaderText = "Inventory Quantity";
            inventory_view.Columns[6].HeaderText = "Supplier";
            inventory_view.Columns[7].HeaderText = "Contact Person";

        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            
            name_text.Text = Login_Form.firstname + " " + Login_Form.lastname;
            disp_inv();
            foreach (DataGridViewRow row in inventory_view.Rows)
            {
                for (int a = 0; a < inventory_view.Rows.Count - 1; a++)
                {
                    if (Convert.ToInt32(inventory_view.Rows[a].Cells[5].Value) <= 10)
                    {
                        notif_button.Visible = true;
                    }
                }

            }
            foreach (DataGridViewRow row in job_order_view.Rows)
            {
                for (int a = 0; a < job_order_view.Rows.Count - 1; a++)
                {
                    if (DateTime.Now >= Convert.ToDateTime(job_order_view.Rows[a].Cells[3].Value))
                    {
                        if (Convert.ToString(job_order_view.Rows[a].Cells[4].Value) == "Finished")
                        {

                        }
                        else
                        {
                            notif_button.Visible = true;

                        }
                    }
                }
            }

        }

        private void Job_Order_Link_Click(object sender, EventArgs e)
        {
            Job_Order_List g = new Job_Order_List();
            g.Show();
            this.Hide();
        }

        private void Sales_Link_Click(object sender, EventArgs e)
        {
            Sales_Page g = new Sales_Page();
            g.Show();
            this.Hide();
        }

        private void Inventory_Link_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }

        private void Profiles_Link_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Login_Form g = new Login_Form();
            g.Show();
            this.Hide();
        }

        private void notif_button_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            // get current date and compare to requested check out date to check past deadline job orders
            foreach (DataGridViewRow row in allview.Rows)
            {
                for (int a = 0; a < allview.Rows.Count - 1; a++)
                {
                    if (DateTime.Now >= Convert.ToDateTime(allview.Rows[a].Cells[3].Value))
                    {
                        if (Convert.ToString(allview.Rows[a].Cells[4].Value) == "Finished")
                        {
                           
                        }
                        else
                        {
                            Conn.Open();
                            string query2 = "select * from job_order where status_type_id_fk='1' and job_order_id='" + allview.Rows[a].Cells[0].Value + "';";
                            DataTable dt2 = new DataTable();
                            dt2 = main.SELECT_Statement(query2);

                            // if found
                            if (dt2.Rows.Count >= 1)
                            {

                            }
                            else
                            {
                                MySqlCommand cmd = Conn.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "Update job_order set status_type_id_fk='1' where job_order_id ='" + allview.Rows[a].Cells[0].Value + "';";
                                cmd.ExecuteNonQuery();
                            }
                            Conn.Close();
                        }
                    }

                }
            }


            disp_data();
            disp_fin();
            notif_button.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Link_Click(object sender, EventArgs e)
        {
            Reports_Page g =new Reports_Page();
            g.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           
        }

        private void exit_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            notif_button.Visible = true;
        }
    }

   
}
