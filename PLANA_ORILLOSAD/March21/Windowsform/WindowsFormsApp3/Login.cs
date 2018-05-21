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
    public partial class Login_Form : Form
    {
        Class1 main;
        public static string firstname, lastname;
        MySqlConnection Conn;

        public class Login
        {
            //declare global variables for name and id of logged in user
            public static string name;
            public static int id;
        }
        public Login_Form()
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
            cmd.CommandText = "SELECT j.job_order_id, j.plate_number_fk, j.check_in, j.req_check_out, j.check_out, s.status_type FROM JOB_ORDER j, STATUS_TYPE s where j.status_type_id_fk=s.status_type_id;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_view.DataSource = dt;
            Conn.Close();
        }
        public void disp_inv()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT i.item_id, i.item_name, it. item_type, i.item_measurement, i.item_selling_price, inv.inventory_quantity, s.supplier_name, s.supplier_contact_person FROM INVENTORY inv, SUPPLIER s, ITEM i, item_type it WHERE inv.item_id_inventory_fk=i.item_id and i.supplier_id_item_fk=s.supplier_id and i.item_type_id_fk=it.item_type_id;";
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


        private void login_button_Click(object sender, EventArgs e)
        {
            // get employees with admin privilege
            String username = text_user.Text;
            String password = text_password.Text;
            string query = "SELECT * FROM employee e, employee_type et WHERE e.emp_type_id_fk=et.emp_type_id and et.emp_type='Admin' and emp_username='" +username +"' and emp_password='" +password +"';";

            DataTable dt = new DataTable();
            dt = main.SELECT_Statement(query);
            
            // if found
            if (dt.Rows.Count == 1)
            {
                int sid = int.Parse(dt.Rows[0]["emp_id"].ToString());
                firstname = dt.Rows[0]["emp_fname"].ToString();
                lastname = dt.Rows[0]["emp_lname"].ToString();
                Login.name = firstname + " " + lastname;  //assign firstname and lastname to the global variable to be used on other forms
                Login.id = sid;
                MessageBox.Show("Welcome " + Login.name);

               
                // get inventory quantity and prompts if it reaches limit
                List<string> list2 = new List<string>();
                foreach (DataGridViewRow row in inventory_view.Rows)
                {
                    for (int a = 0; a < inventory_view.Rows.Count - 1; a++)
                    {
                        if (Convert.ToInt32(inventory_view.Rows[a].Cells[5].Value) <= 10)
                        {
                            list2.Add(Convert.ToString(inventory_view.Rows[a].Cells[1].Value));
                        }
                       


                    }
                }
                // get current date and compare to requested check out date to check past deadline job orders
                List<string> list = new List<string>();
                foreach (DataGridViewRow row in job_order_view.Rows)
                {
                    for (int a = 0; a < job_order_view.Rows.Count - 1; a++)
                    {
                        if (DateTime.Now >= Convert.ToDateTime(job_order_view.Rows[a].Cells[3].Value))
                        {
                            if (Convert.ToString(job_order_view.Rows[a].Cells[5].Value) == "Finished")
                            {

                            }
                            else
                            {
                                list.Add(Convert.ToString(job_order_view.Rows[a].Cells[0].Value));
                                Conn.Open();
                              
                                string query2 = "select * from job_order where status_type_id_fk='1' and job_order_id='" + job_order_view.Rows[a].Cells[0].Value + "';";
                                DataTable dt2 = new DataTable();
                                dt2 = main.SELECT_Statement(query2);

                                // if found
                                if (dt2.Rows.Count == 1)
                                {

                                }
                                else
                                {
                                    MySqlCommand cmd3 = Conn.CreateCommand();
                                    cmd3.CommandType = CommandType.Text;
                                    cmd3.CommandText = "Update job_order set status_type_id_fk='1' where job_order_id ='" + job_order_view.Rows[a].Cells[0].Value + "';";
                                    cmd3.ExecuteNonQuery();
                                }
                                Conn.Close();
                            }
                        }

                    }
                }

               
               
                string i = String.Join(", ", list2.Distinct().ToArray());
                // display messagebox showing list of items with 0 inventory quantity
                MessageBox.Show("Items with 10 or less quantity in the Inventory: \n" + i, "PRIORITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string s = String.Join(", ", list.Distinct().ToArray());
                // display messagebox showing list of past deadline job order
                MessageBox.Show("Job orders past the requested check-out dates: \n Job Orders # " + s, "PRIORITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Homepage g = new Homepage();
                g.Show();
                this.Hide();

            }

            else if (username is null && password is null)
            {
                MessageBox.Show("Enter Username and Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username is null)
            {
                MessageBox.Show("Enter Username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password is null)
            {
                MessageBox.Show("Enter Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Username/Password Not Found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }


        private void Login_Load(object sender, EventArgs e)
        {
            disp_data();
            disp_inv();
        }

        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
