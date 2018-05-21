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
    public partial class Job_Order_Update : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        public static string js;
        public static string format = "yyyy-MM-dd HH:mm:ss";
        public Job_Order_Update()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }
        private void combobox_employee()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT concat(emp_fname, ' ', emp_lname) as empfull FROM employee where emp_status='Active';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            employee_input.Items.Add("");
            while (dr.Read())
            {
                employee_input.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = employee_input.Text;


            int index = employee_input.FindString(actual);
            if (index > -1)
            {
                string found = employee_input.Items.ToString();

                employee_input.SelectionStart = actual.Length;
                employee_input.SelectionLength = found.Length;
                employee_input.SelectedIndex = index;
            }

        }
        public void filljobdetailsox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from job_order_services order by job_order_services_id asc;";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string one = "1";
                string list = sdr.GetString("job_order_services_id");
                int add = int.Parse(list);
                job_order_serviceid.Text = Convert.ToString(add);
                int ans = int.Parse(job_order_serviceid.Text) + int.Parse(one);
                job_order_sid.Text = Convert.ToString(ans);


            }

            Conn.Close();
        }
        private void combobox_servicetype()
        {
            //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd2 = Conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT service_type from service";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            service_type_input.Items.Add("");
            while (dr2.Read())
            {
                service_type_input.Items.Add(dr2[0]);
            }
            Conn.Close();

            // search function
            string actual = service_type_input.Text;


            int index = service_type_input.FindString(actual);
            if (index > -1)
            {
                string found = service_type_input.Items.ToString();

                service_type_input.SelectionStart = actual.Length;
                service_type_input.SelectionLength = found.Length;
                service_type_input.SelectedIndex = index;
            }
        


        }
        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void filljodetailsbox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select j.job_order_id, v.plate_number, j.problem_reported,j.initial_diagnosis, j.check_in, j.req_check_out, j.check_out, s.status_type from status_type s, job_order j, vehicle v where j.plate_number_fk=v.plate_number and j.status_type_id_fk=s.status_type_id and j.job_order_id='" + Job_Order_Details.jobid + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                plate_input.Text = sdr.GetString("plate_number");
                check_in_date_input.Text = sdr.GetString("check_in");
                status_text.SelectedText = sdr.GetString("status_type");

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
                if (sdr.GetString("req_check_out") is null)
                {
                    string value = "";
                    requested_date_input.Text = value;
                }
                else if (sdr.GetString("req_check_out") != null)
                {
                    requested_date_input.Text = sdr.GetString("req_check_out");
                }

            }

            Conn.Close();
        }

        public void fillcustbox()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select c.cust_fname, c.cust_lname from customer c, vehicle v, job_order j where j.plate_number_fk=v.plate_number and v.cust_id_vehicle_fk=c.cust_id and j.job_order_id='" + Job_Order_Details.jobid + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cust_input.Text = sdr.GetString("cust_fname") + " " + sdr.GetString("cust_lname");
            }

            Conn.Close();
        }
        int rowc;
        public void fillservices()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.service_type, js.service_fee, concat(e.emp_fname,' ',e.emp_lname) as employee_full, js.labor_fee, subtotal_job_order, js.job_order_services_id, e.emp_id, js.time_started_serv, js.time_ended_serv, s.service_id  from job_order_services js, service s, job_order j, employee e where js.job_order_id_serv_fk=j.job_order_id and js.service_type_job_order_fk = s.service_id and js.emp_id_job_order_fk=e.emp_id and j.job_order_id='" + Job_Order_Details.jobid + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            job_order_selected_service_view.DataSource = dt;
            rowc = (Convert.ToInt32(job_order_selected_service_view.Rows.Count) - 1);
            rowcount.Text = Convert.ToString(rowc);
            for (int a = 0; a < job_order_selected_service_view.RowCount; a++)
            {
                string additem = "insert into fetch_temp(temp_name, temp_price, temp_qty, temp_subtotal, temp_serviceid, temp_itemid, temp_type) select distinct i.item_name, i.item_selling_price, ji.job_order_items_quantity, (i.item_selling_price * ji.job_order_items_quantity) as subtotal, js.job_order_services_id, ji.item_id_job_order_fk, i.item_type_id_fk from job_order_items ji, job_order_services js, item i where ji.item_id_job_order_fk=i.item_id and ji.job_order_services_id_fk=js.job_order_services_id and js.job_order_services_id='" + job_order_selected_service_view.Rows[a].Cells[5].Value + "'";
                main.CUD_Statement(additem);

            }
            Conn.Close();


            job_order_selected_service_view.Columns[0].HeaderText = "Service Type";
            job_order_selected_service_view.Columns[1].HeaderText = "Service Fee";
            job_order_selected_service_view.Columns[2].HeaderText = "Employee";
            job_order_selected_service_view.Columns[3].HeaderText = "Labor Fee";
            job_order_selected_service_view.Columns[3].Visible = false;
            job_order_selected_service_view.Columns[4].HeaderText = "Subtotal";
            job_order_selected_service_view.Columns[5].HeaderText = "Job Order Service ID";
            job_order_selected_service_view.Columns[5].Visible = false;
            job_order_selected_service_view.Columns[6].HeaderText = "Emp ID";
            job_order_selected_service_view.Columns[6].Visible = false;
            job_order_selected_service_view.Columns[7].HeaderText = "Time Started";
            job_order_selected_service_view.Columns[8].HeaderText = "Time Ended";
            job_order_selected_service_view.Columns[9].HeaderText = "Service ID";
            job_order_selected_service_view.Columns[9].Visible = false;

            foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
            {
                if (row.IsNewRow) continue;

                int sum = 0;
                for (int i = 0; i <= rowc; i++)
                {

                    sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                }
                total_input.Text = Convert.ToString(sum);

            }            
            Conn.Close();
        }
        //string jsid;
        public void disp_fetch()
        {
            Conn.Open();
            MySqlCommand cmd8 = Conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select * from fetch_temp where temp_serviceid='" + job_order_sid.Text + "'";
            cmd8.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd8);
            da.Fill(dt2);
            fetch_table_view.DataSource = dt2;

            fetch_table_view.Columns[0].HeaderText = "Item Name";
            fetch_table_view.Columns[1].HeaderText = "Item Price";
            fetch_table_view.Columns[2].HeaderText = "Quantity";
            fetch_table_view.Columns[3].HeaderText = "Subtotal";
            fetch_table_view.Columns[4].HeaderText = "Service ID";
            fetch_table_view.Columns[4].Visible = false;
            fetch_table_view.Columns[5].HeaderText = "Item ID";
            fetch_table_view.Columns[5].Visible = false;
            fetch_table_view.Columns[6].Visible = false;
            Conn.Close();


        }

        public void disp_all_item()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT * from fetch_inventory where fetch_servid='" + service_id.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            da2.Fill(dt);
            view_item_view.DataSource = dt;

            Conn.Close();
            view_item_view.Columns[0].HeaderText = "Item ID";
            view_item_view.Columns[0].Visible = false;
            view_item_view.Columns[1].HeaderText = "Name";
            view_item_view.Columns[2].HeaderText = "Price";
            view_item_view.Columns[3].HeaderText = "In Stock";
            view_item_view.Columns[4].HeaderText = "Brand";
            view_item_view.Columns[5].HeaderText = "Measurement";
            view_item_view.Columns[6].HeaderText = "ServiceID";
            view_item_view.Columns[6].Visible = false;
            view_item_view.Columns[8].HeaderText = "Supplier";
            view_item_view.Columns[7].Visible = false;
        }

        private void Job_Order_Details_Load(object sender, EventArgs e)
        {
            job_order_id.Text = Convert.ToString(Job_Order_Details.jobid);
            filljodetailsbox();
            fillcustbox();
            fillservices();
            combobox_employee();
            combobox_servicetype();
            filljobdetailsox();
            Conn.Open();
            string additem = "insert into fetch_inventory(fetch_itemid, fetch_itemname, fetch_price, fetch_itemqty, fetch_brand, fetch_measurement, fetch_servid, fetch_itemtype) SELECT distinct item.item_id, item.item_name, item.item_selling_price, inventory.inventory_quantity, item.item_brand, item.item_measurement, s.service_id, item.item_type_id_fk FROM ITEM, INVENTORY, SERVICE s, SERVICE_DETAILS sd WHERE item.item_id=inventory.item_id_inventory_fk and sd.item_id_service_fk=item.item_id and sd.service_type_fk_details=s.service_id and inventory.inventory_quantity >0;";
            main.CUD_Statement(additem);
            Conn.Close();

        }




        private void back_button_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to leave? \nChanges you have made will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes:
                    Conn.Open();
                    //fetch_temp should be truncated
                    MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand("TRUNCATE fetch_inventory;", Conn);
                    cmd2.ExecuteNonQuery();
                    Job_Order_List g = new Job_Order_List();
                    g.Show();
                    this.Hide();
                    Conn.Close();

                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void service_type_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_item.Visible = true;
            service_type_input.DropDownStyle = ComboBoxStyle.DropDown;
            service_type_input.AutoCompleteSource = AutoCompleteSource.ListItems;
            service_type_input.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_view.Rows.Clear();
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT service_id from service where service_type='" + service_type_input.SelectedText + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string service = sdr.GetString("service_id");
                service_id.Text = service;
            }
            Conn.Close();
            disp_all_item();
            if (service_id.Text == null)
            {

            }
            else
            {
                item_input.Enabled = true;
                quantity_input.Enabled = true;
                price_input.Enabled = true;
                employee_input.Enabled = true;
            }
            item_input.Text = null;
            quantity_input.Clear();
            service_fee_input.Clear();
        }


        private void employee_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_input.DropDownStyle = ComboBoxStyle.DropDown;
            employee_input.AutoCompleteSource = AutoCompleteSource.ListItems;
            employee_input.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select emp_id from employee where concat(emp_fname, ' ', emp_lname)='" + employee_input.Text + "'";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string id = sdr.GetString("emp_id");
                emp_id.Text = id;
            }
            Conn.Close();
            disp_task();
        }

        private void status_text_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
        string itemname;
        int current, amt;
        private void add_item_Click(object sender, EventArgs e)
        {
            
            bool found = false;

            if (service_type_input.Text == String.Empty)
            {
                MessageBox.Show("Please select a Service Type");

            }
            else if (item_input.Text == String.Empty)
            {
                MessageBox.Show("Please Choose an Item");

            }
            else if (quantity_input.Text == String.Empty)
            {
                MessageBox.Show("Please Specify Quantity");

            }
            else if (item_inventory.Text == String.Empty)
            {
                MessageBox.Show("Please Choose an Item");

            }
            else if (Convert.ToInt32(quantity_input.Text) >= Convert.ToInt32(item_inventory.Text))
            {
                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (fetch_table_view.Rows.Count > 0)
                {
                    // add items to another datagrid 
                    foreach (DataGridViewRow row in fetch_table_view.Rows)
                    {
                        if (row.IsNewRow) continue;
                        service_type_input.Enabled = false;
                        fetch_table_view.Visible = true;

                        itemname = Convert.ToString(row.Cells[0].Value);
                        string jobsid = Convert.ToString(row.Cells[4].Value);
                        if (item_input.Text == itemname && job_order_sid.Text == jobsid)
                        {
                            foreach (DataGridViewRow row2 in view_item_view.Rows)
                            {
                                if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                                {
                                    amt = Convert.ToInt32(row2.Cells[3].Value);

                                }
                            }
                            if (Convert.ToInt32(quantity_input.Text) > amt)
                            {
                                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else if (Convert.ToInt32(item_inventory.Text) == 0)
                            {
                                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string updfetch = "set sql_safe_updates=0; update fetch_temp set temp_qty = temp_qty +" + Convert.ToInt32(quantity_input.Text) + " where temp_name = '" + row.Cells[0].Value + "' and temp_serviceid ='" + row.Cells[4].Value + "'; set sql_safe_updates = 1;";
                                main.CUD_Statement(updfetch);

                                current = view_item_view.CurrentRow.Index;
                                item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                                view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                                disp_all_item();
                                found = true;
                            }
                        }
                    }
                    // if item is not yet in the datagrid
                    if (!found)
                    {
                        foreach (DataGridViewRow row2 in view_item_view.Rows)
                        {
                            if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                            {
                                amt = Convert.ToInt32(row2.Cells[3].Value);

                            }
                        }
                        if (Convert.ToInt32(quantity_input.Text) > amt)
                        {
                            MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else if (Convert.ToInt32(item_inventory.Text) == 0)
                        {
                            MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int row = 0;
                            item_view.Rows.Add();
                            row = item_view.Rows.Count - 2;
                            item_view.Rows[row].Cells[0].Value = item_input.Text;
                            item_view.Rows[row].Cells[5].Value = item_id.Text;
                            item_view.Rows[row].Cells[1].Value = price_input.Text;
                            item_view.Rows[row].Cells[2].Value = quantity_input.Text;
                            item_view.Rows[row].Cells[4].Value = job_order_sid.Text;
                            item_view.Rows[row].Cells[3].Value = Convert.ToInt32(price_input.Text) * Convert.ToInt32(quantity_input.Text);
                            item_view.Rows[row].Cells[6].Value = item_type.Text;
                            current = view_item_view.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                            view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                            string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                            main.CUD_Statement(inv);
                            disp_all_item();
                            Conn.Open();
                            MySqlCommand cmd2 = new MySqlCommand("insert into fetch_temp(temp_name, temp_price, temp_qty, temp_subtotal, temp_serviceid, temp_itemid, temp_type) values(@tname, @tprice, @tqty, @tstotal, @tservid, @tiid, @titype);", Conn);
                            cmd2.Parameters.AddWithValue("@tname", item_view.Rows[row].Cells[0].Value);
                            cmd2.Parameters.AddWithValue("@tprice", item_view.Rows[row].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@tqty", item_view.Rows[row].Cells[2].Value);
                            cmd2.Parameters.AddWithValue("@tstotal", item_view.Rows[row].Cells[3].Value);
                            cmd2.Parameters.AddWithValue("@tservid", item_view.Rows[row].Cells[4].Value);
                            cmd2.Parameters.AddWithValue("@tiid", item_view.Rows[row].Cells[5].Value);
                            cmd2.Parameters.AddWithValue("@titype", item_view.Rows[row].Cells[6].Value);
                            cmd2.ExecuteNonQuery();
                            Conn.Close();
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row2 in view_item_view.Rows)
                    {
                        if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                        {
                            amt = Convert.ToInt32(row2.Cells[3].Value);

                        }
                    }
                    if (Convert.ToInt32(quantity_input.Text) > amt)
                    {
                        MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (Convert.ToInt32(item_inventory.Text) == 0)
                    {
                        MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int row = 0;
                        item_view.Rows.Add();
                        row = item_view.Rows.Count - 2;
                        item_view.Rows[row].Cells[0].Value = item_input.Text;
                        item_view.Rows[row].Cells[5].Value = item_id.Text;
                        item_view.Rows[row].Cells[1].Value = price_input.Text;
                        item_view.Rows[row].Cells[2].Value = quantity_input.Text;
                        item_view.Rows[row].Cells[4].Value = job_order_sid.Text;
                        item_view.Rows[row].Cells[3].Value = Convert.ToInt32(price_input.Text) * Convert.ToInt32(quantity_input.Text);
                        item_view.Rows[row].Cells[6].Value = item_type.Text;
                        current = view_item_view.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                        view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                        string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                        main.CUD_Statement(inv);
                        disp_all_item();
                        Conn.Open();
                        MySqlCommand cmd2 = new MySqlCommand("insert into fetch_temp(temp_name, temp_price, temp_qty, temp_subtotal, temp_serviceid, temp_itemid, temp_type) values(@tname, @tprice, @tqty, @tstotal, @tservid, @tiid, @titype);", Conn);
                        cmd2.Parameters.AddWithValue("@tname", item_view.Rows[row].Cells[0].Value);
                        cmd2.Parameters.AddWithValue("@tprice", item_view.Rows[row].Cells[1].Value);
                        cmd2.Parameters.AddWithValue("@tqty", item_view.Rows[row].Cells[2].Value);
                        cmd2.Parameters.AddWithValue("@tstotal", item_view.Rows[row].Cells[3].Value);
                        cmd2.Parameters.AddWithValue("@tservid", item_view.Rows[row].Cells[4].Value);
                        cmd2.Parameters.AddWithValue("@tiid", item_view.Rows[row].Cells[5].Value);
                        cmd2.Parameters.AddWithValue("@titype", item_view.Rows[row].Cells[6].Value);
                        cmd2.ExecuteNonQuery();
                        Conn.Close();
                    }  

                }
            }
            disp_fetch();
            //total
            foreach (DataGridViewRow row in fetch_table_view.Rows)
            {
                if (row.IsNewRow) continue;

                int sum = 0;
                for (int i = 0; i < fetch_table_view.Rows.Count; i++)
                {

                    sum += Convert.ToInt32(fetch_table_view.Rows[i].Cells[3].Value);

                }
                service_fee_input.Text = Convert.ToString(sum);

            }
            quantity_input.Clear();
            item_input.Clear();
        }

        public void disp_fetchy()
        {
            Conn.Open();
            MySqlCommand cmd8 = Conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select * from fetch_temp where temp_serviceid='" + job_order_sidx.Text + "'";
            cmd8.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd8);
            da.Fill(dt2);
            fetch_table_view.DataSource = dt2;

            fetch_table_view.Columns[0].HeaderText = "Item Name";
            fetch_table_view.Columns[1].HeaderText = "Item Price";
            fetch_table_view.Columns[2].HeaderText = "Quantity";
            fetch_table_view.Columns[3].HeaderText = "Subtotal";
            fetch_table_view.Columns[4].HeaderText = "Service ID";
            fetch_table_view.Columns[4].Visible = false;
            fetch_table_view.Columns[5].HeaderText = "Item ID";
            fetch_table_view.Columns[5].Visible = false;
            fetch_table_view.Columns[6].Visible = false;

            Conn.Close();


        }

        int tempid, tempqty;
        string st;

        private void view_item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (service_type_input.Text == string.Empty)
            {
                MessageBox.Show("Please Choose Service Type First");
            }
            else if (service_type_input.Items.Contains(service_type_input.Text) == false)
            {
                MessageBox.Show("Service Type is not valid. \n Please select from the list.");
                service_type_input.Text = String.Empty;
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    item_id.Text = view_item_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                    item_input.Text = view_item_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                    price_input.Text = view_item_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                    item_inventory.Text = view_item_view.Rows[e.RowIndex].Cells[3].Value.ToString();
                    item_type.Text = view_item_view.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }

        }

        private void job_order_selected_service_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                service_type_input.Enabled = false;
                fetch_table_view.Visible = true;
                employee_input.Enabled = false;
                add_service.Visible = false;

                if (e.RowIndex <= rowc)
                {
                    disp_fetchy();
                    add_item.Visible = false;
                    job_order_sidx.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells["job_order_services_id"].Value.ToString();

                    if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[8].Value) == string.Empty)
                    {
                        disp_fetchy();
                        finished_task_button.Visible = true;
                        update_button.Visible = true;
                        add_button_temp.Visible = true;

                    }
                    else
                    {
                        disp_fetchy();
                        finished_task_button.Visible = false;
                        update_item.Visible = false;
                        update_button.Visible = false;
                        add_button_temp.Visible = false;

                    }

                    disp_fetchy();
                    add_item.Visible = false;
                    remove_service.Visible = false;
                    add_service.Visible = false;
                }

                else
                {

                    if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[8].Value) == string.Empty)
                    {

                        finished_task_button.Visible = true;
                        remove_service.Visible = true;
                        add_button_temp.Visible = true;
                        add_item.Visible = false;
                        update_button.Visible = true;
                        disp_fetchy();
                    }
                    else
                    {
                        finished_task_button.Visible = false;
                        remove_service.Visible = false;
                        add_button_temp.Visible = false;
                        add_item.Visible = false;
                        update_button.Visible = false;
                        disp_fetchy();
                    }
                }
                disp_fetchy();
                service_id.Clear();
                job_order_sidx.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells["job_order_services_id"].Value.ToString();
                employee_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                service_type_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                service_fee_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                add_item.Visible = false;
                employee_input.Enabled = false;
                service_id.Text = Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[9].Value);
                disp_all_item();
                disp_fetchy();
                reset_button.Visible = true;
                reset_label.Visible = true;
            }
         
        }
        int serid;
        public void disp_task()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select j.job_order_id, j.plate_number_fk, s.service_type, js.time_started_serv from job_order j, job_order_services js, employee e, service s where j.job_order_id=js.job_order_id_serv_fk and js.service_type_job_order_fk=s.service_id  and e.emp_id=js.emp_id_job_order_fk and e.emp_id='" + emp_id.Text + "' and time_ended_serv is null order by js.time_started_serv asc;";
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

        }
        private void remove_service_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(service_type_input.Text))
            {
                MessageBox.Show("Please select a service type in the list");

            }
            else
            {
                // item inventory should be back to original quantity
                foreach (DataGridViewRow item in this.job_order_selected_service_view.SelectedRows)
                {
                    serid = Convert.ToInt32(item.Cells[5].Value);
                    service_fee_input.Text = Convert.ToString(Convert.ToInt32(service_fee_input.Text) + Convert.ToInt32(item.Cells[1].Value));
                    foreach (DataGridViewRow item2 in fetch_table_view.Rows)
                    {
                        int fetchtempid = Convert.ToInt32(item2.Cells[5].Value);
                        int fetchtempqty = Convert.ToInt32(item2.Cells[2].Value);
                        int fetchtemp_serv = Convert.ToInt32(item2.Cells[4].Value);
                        Conn.Open();
                        MySqlCommand cmd8 = Conn.CreateCommand();
                        cmd8.CommandType = CommandType.Text;
                        cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_serviceid='" + serid + "'; set sql_safe_updates=1;";
                        cmd8.ExecuteNonQuery();
                        Conn.Close();
                        foreach (DataGridViewRow row in view_item_view.Rows)
                        {

                            if (Convert.ToInt32(row.Cells[0].Value) == fetchtempid)
                            {
                                int qty = Convert.ToInt32(row.Cells[3].Value);
                                int add = qty + fetchtempqty;
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + Convert.ToString(add) + "' where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                                disp_all_item();
                            }

                        }
                        fetch_table_view.Rows.RemoveAt(item2.Index);
                        service_fee_input.Clear();
                    }
                    foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int sum = 0;
                        for (int i = 0; i <= rowc; i++)
                        {

                            sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                        }
                        total_input.Text = Convert.ToString(sum);

                    }
                    job_order_selected_service_view.Rows.RemoveAt(item.Index);
                    reset_button_Click(sender, e);
                }
            }
        }

        private void services_tab_Click(object sender, EventArgs e)
        {

        }

        private void fetch_table_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void job_order_selected_service_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Conn.Open();
            // insert errors for combobox with values not found in the database


            if (job_order_selected_service_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Service/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Item/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                status_id.Text = "2";
                if (DateTime.Now >= requested_date_input.Value)
                {

                    switch (MessageBox.Show("The requested release date has already passed. '\n Status will be changed to PAST DEADLINE. \n Would you like to Continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {

                        case DialogResult.No:
                            MessageBox.Show("Please set a requested date beyond the current date");
                            this.Refresh();
                            break;
                        case DialogResult.Yes:
                            status_id.Text = "1";
                            string query2 = "update job_order set problem_reported='" + problem_input.Text + "'" +
                               ", initial_diagnosis ='" + diagnosis_input.Text + "', req_check_out ='" + requested_date_input.Value.ToString(format) + "', status_type_id_fk='" + Convert.ToInt32(status_id.Text) + "', total_amount='" + Convert.ToInt32(total_input.Text) +"'" + 
                               "where job_order_id='" + Convert.ToInt32(job_order_id.Text) + "'";
                            main.CUD_Statement(query2);

                            MySqlCommand cmd8 = new MySqlCommand("set foreign_key_checks=0; truncate inventory; insert into inventory(item_id_inventory_fk, inventory_quantity) select distinct fetch_itemid, fetch_itemqty from fetch_inventory; set foreign_key_checks = 1;", Conn);
                            cmd8.ExecuteNonQuery();




                            int countrow = job_order_selected_service_view.Rows.Count;
                                // for items that were already added (update na lang sila)
                                for (int a = 0; a <= rowc; a++)
                                {
                                    if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                    {
                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();
                                    }
                                    else
                                    { 
                                        DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                        cmd2.Parameters.AddWithValue("@ten", ten);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();
                                  
                                    }

                                }


                                // for new items
                                for (int a = rowc+1; a < countrow; a++)
                                {
                                    string ex = "select * from job_order_services where service_type_job_order_fk= '" + job_order_selected_service_view.Rows[a].Cells[9].Value +
                                        "' and emp_id_job_order_fk ='" + job_order_selected_service_view.Rows[a].Cells[6].Value + "' and time_started_serv='" + job_order_selected_service_view.Rows[a].Cells[7].Value + "'";
                                    DataTable dt = new DataTable();
                                    dt = main.SELECT_Statement(ex);

                                    if (dt.Rows.Count > 0)
                                    {
                                        if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                        {
                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                            cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                            cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                            cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                         
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                        cmd2.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                            cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                            cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                            cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                            cmd2.Parameters.AddWithValue("@ten", ten);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                        cmd2.ExecuteNonQuery();


                                        }

                                    }
                                    else
                                    {
                                        if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[7].Value) == string.Empty)
                                        {

                                        }
                                        else
                                        {
                                            if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                            {
                                                DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);

                                                MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk, job_order_id_serv_fk,time_started_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @total_serv); set foreign_key_checks=1;", Conn);
                                                cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                                cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                                cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                               
                                                cmd2.Parameters.AddWithValue("@tstart", tst);
                                            cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                            cmd2.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);
                                                DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                                MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk, job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid, @labf," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
                                                cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                                cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                                cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                               
                                                cmd2.Parameters.AddWithValue("@tstart", tst);
                                                cmd2.Parameters.AddWithValue("@tend", ten);
                                            cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                            cmd2.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                
                            }
                            MySqlCommand cmd3 = Conn.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "select * from fetch_temp where temp_itemid is not null and temp_type='2'";
                            cmd3.ExecuteNonQuery();
                            DataTable dt3 = new DataTable();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                            da.Fill(dt3);
                            trialgrid.DataSource = dt3;

                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trialgrid.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trialgrid.Rows[a].Cells[5].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from stock_order_details where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update stock_order_details set stock_order_item_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_order_details='" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) +"' where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);
                                        }
                                        else
                                        {
                                            string additem2 = "insert into stock_order_details(item_id_stock_order_fk, stock_order_item_quantity, job_order_id_stock_order_fk, total_stock_order_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) +"')";
                                            main.CUD_Statement(additem2);

                                        }
                                       
                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }
                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trialgrid.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trialgrid.Rows[a].Cells[5].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from stock_out_details where item_id_stock_out_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_out_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update stock_out_details set stock_out_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_out_details='" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "' where item_id_stock_out_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_out_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);
                                        }
                                        else
                                        {
                                            string additem2 = "insert into stock_out_details(item_id_stock_out_fk, stock_out_quantity, job_order_id_stock_out_fk, total_stock_out_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "')";
                                            main.CUD_Statement(additem2);

                                        }

                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }
                            MySqlCommand cmd4 = Conn.CreateCommand();
                            cmd4.CommandType = CommandType.Text;
                            cmd4.CommandText = "select * from fetch_temp where temp_itemid is not null";
                            cmd4.ExecuteNonQuery();
                            DataTable dt4 = new DataTable();
                            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd4);
                            da2.Fill(dt4);
                            trial_grid4.DataSource = dt4;

                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {

                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trial_grid4.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trial_grid4.Rows[a].Cells[4].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from job_order_items where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update job_order_items set job_order_items_quantity='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "', total_job_order_items='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value) +"' where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);
                                         

                                        }

                                        // insert items from fetch_temp to job_order_items
                                        else
                                        {
                                            string additem = "insert into job_order_items(item_id_job_order_fk, job_order_items_quantity, job_order_services_id_fk, total_job_order_items) values ('" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "','" +Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value)+"');";
                                            main.CUD_Statement(additem);
                                           
                                        }
                                      
                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }
                           
                            // there should be a prompt to continue 
                            // insert list of all services with items
                            // job order is created
                            MessageBox.Show("Job Order Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //fetch_temp should be truncated
                            MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                            cmd.ExecuteNonQuery();
                            //view details
                            Job_Order_Details k = new Job_Order_Details();
                            js = job_order_id.Text;
                            k.Show();
                            this.Hide();
                            break;
                    }
                }
                // if job order is already on progress
                else
                {
                    switch (MessageBox.Show("Are you sure you want to update the Job Order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {

                        case DialogResult.No:
                            break;
                        case DialogResult.Yes:
                            status_id.Text = "2";
                            string query2 = "update job_order set problem_reported='" + problem_input.Text + "'" +
                              ", initial_diagnosis ='" + diagnosis_input.Text + "', req_check_out ='" + requested_date_input.Value.ToString(format) + "', status_type_id_fk='" + Convert.ToInt32(status_id.Text) + "', total_amount='" + Convert.ToInt32(total_input.Text) + "'" +
                              "where job_order_id='" + Convert.ToInt32(job_order_id.Text) + "'";
                            main.CUD_Statement(query2);


                            MySqlCommand cmd8 = new MySqlCommand("set foreign_key_checks=0; truncate inventory; insert into inventory(item_id_inventory_fk, inventory_quantity) select distinct fetch_itemid, fetch_itemqty from fetch_inventory; set foreign_key_checks = 1;", Conn);
                            cmd8.ExecuteNonQuery();


                            int countrow = job_order_selected_service_view.Rows.Count;
                            // for items that were already added (update na lang sila)
                            for (int a = 0; a <= rowc; a++)
                            {
                                if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                {
                                    MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                    cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                    cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                    cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();
                                }
                                else
                                {
                                    DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                    MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                    cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                    cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                    cmd2.Parameters.AddWithValue("@ten", ten);
                                    cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();

                                }

                            }


                            // for new items
                            for (int a = rowc + 1; a < countrow; a++)
                            {
                                string ex = "select * from job_order_services where service_type_job_order_fk= '" + job_order_selected_service_view.Rows[a].Cells[9].Value +
                                    "' and emp_id_job_order_fk ='" + job_order_selected_service_view.Rows[a].Cells[6].Value + "' and time_started_serv='" + job_order_selected_service_view.Rows[a].Cells[7].Value + "'";
                                DataTable dt = new DataTable();
                                dt = main.SELECT_Statement(ex);

                                if (dt.Rows.Count > 0)
                                {
                                    if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                    {
                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                        cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                        cmd2.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                        cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                        cmd2.Parameters.AddWithValue("@ten", ten);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                        cmd2.ExecuteNonQuery();


                                    }

                                }
                                else
                                {
                                    if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[7].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                        {
                                            DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);

                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk,  job_order_id_serv_fk,time_started_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @total_serv); set foreign_key_checks=1;", Conn);
                                            cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                            cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                            cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                            cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                            cmd2.Parameters.AddWithValue("@tstart", tst);
                                            cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                            cmd2.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);
                                            DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk,  job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
                                            cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                            cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                            cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                            cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                            cmd2.Parameters.AddWithValue("@tstart", tst);
                                            cmd2.Parameters.AddWithValue("@tend", ten);
                                            cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                            cmd2.ExecuteNonQuery();
                                        }
                                    }
                                }

                            }
                            MySqlCommand cmd3 = Conn.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "select * from fetch_temp where temp_itemid is not null and temp_type='2'";
                            cmd3.ExecuteNonQuery();
                            DataTable dt3 = new DataTable();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                            da.Fill(dt3);
                            trialgrid.DataSource = dt3;

                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trialgrid.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trialgrid.Rows[a].Cells[5].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from stock_order_details where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update stock_order_details set stock_order_item_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_order_details='" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "' where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);
                                        }
                                        else
                                        {
                                            string additem2 = "insert into stock_order_details(item_id_stock_order_fk, stock_order_item_quantity, job_order_id_stock_order_fk, total_stock_order_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "')";
                                            main.CUD_Statement(additem2);

                                        }

                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }
                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trialgrid.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trialgrid.Rows[a].Cells[5].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from stock_out_details where item_id_stock_out_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_out_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update stock_out_details set stock_out_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_out_details='" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "' where item_id_stock_out_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_out_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);
                                        }
                                        else
                                        {
                                            string additem2 = "insert into stock_out_details(item_id_stock_out_fk, stock_out_quantity, job_order_id_stock_out_fk, total_stock_out_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "')";
                                            main.CUD_Statement(additem2);

                                        }

                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }
                            MySqlCommand cmd4 = Conn.CreateCommand();
                            cmd4.CommandType = CommandType.Text;
                            cmd4.CommandText = "select * from fetch_temp where temp_itemid is not null";
                            cmd4.ExecuteNonQuery();
                            DataTable dt4 = new DataTable();
                            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd4);
                            da2.Fill(dt4);
                            trial_grid4.DataSource = dt4;

                            foreach (DataGridViewRow row in trialgrid.Rows)
                            {

                                if (row.IsNewRow) continue;
                                for (int a = 0; a < trial_grid4.Rows.Count; a++)
                                {
                                    if (Convert.ToString(trial_grid4.Rows[a].Cells[4].Value) == string.Empty)
                                    {

                                    }
                                    else
                                    {
                                        string q = "set foreign_key_checks=0;";
                                        main.CUD_Statement(q);
                                        string z = "select * from job_order_items where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                        DataTable dtz = new DataTable();
                                        dtz = main.SELECT_Statement(z);

                                        if (dtz.Rows.Count > 0)
                                        {
                                            string upditem = "update job_order_items set job_order_items_quantity='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "', total_job_order_items='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value) + "' where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                            main.CUD_Statement(upditem);


                                        }

                                        // insert items from fetch_temp to job_order_items
                                        else
                                        {
                                            string additem = "insert into job_order_items(item_id_job_order_fk, job_order_items_quantity, job_order_services_id_fk, total_job_order_items) values ('" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value) + "');";
                                            main.CUD_Statement(additem);

                                        }

                                        string q2 = "set foreign_key_checks=1;";
                                        main.CUD_Statement(q2);
                                    }
                                }
                            }


                            // there should be a prompt to continue 
                            // insert list of all services with items
                            // job order is created
                            MessageBox.Show("Job Order Updated!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //fetch_temp should be truncated
                            MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                            cmd.ExecuteNonQuery();
                            //view details
                            //Job_Order_Details k = new Job_Order_Details();
                            Job_Order_Details k = new Job_Order_Details();
                            js = job_order_id.Text;
                            k.Show();
                            this.Hide();
                            break;
                    }
                }
            }
            Conn.Close();
        }

        private void finished_task_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.job_order_selected_service_view.SelectedRows)
            {
                switch (MessageBox.Show("Are you sure you want set Task to Finished?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        remove_button.Visible = false;
                        item.Cells[8].Value = DateTime.Now.ToString(format);
                        remove_service.Visible = false;
                        add_service.Visible = false;
                        add_item.Visible = false;
                        add_button_temp.Visible = false;
                        update_button.Visible = false;
                        update_item.Visible = false;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            finished_task_button.Visible = false;
        }

        private void add_button_temp_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (service_type_input.Text == String.Empty)
            {
                MessageBox.Show("Please select a Service Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_input.Text == String.Empty)
            {
                MessageBox.Show("Please Choose an Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (quantity_input.Text == String.Empty)
            {
                MessageBox.Show("Please Specify Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_inventory.Text == String.Empty)
            {
                MessageBox.Show("Please Choose an Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Convert.ToInt32(quantity_input.Text) >= Convert.ToInt32(item_inventory.Text))
            {
                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (fetch_table_view.Rows.Count > 0)
                {
                    // add items to another datagrid 
                    foreach (DataGridViewRow row in fetch_table_view.Rows)
                    {

                        itemname = Convert.ToString(row.Cells[0].Value);
                        string jobsid = Convert.ToString(row.Cells[4].Value);
                        if (item_input.Text == itemname && job_order_sidx.Text == jobsid)
                        {
                            foreach (DataGridViewRow row2 in view_item_view.Rows)
                            {
                                if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                                {
                                    amt = Convert.ToInt32(row2.Cells[3].Value);

                                }
                            }
                            if (Convert.ToInt32(quantity_input.Text) > amt)
                            {
                                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else if (Convert.ToInt32(item_inventory.Text) == 0)
                            {
                                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string updfetch = "set sql_safe_updates=0; update fetch_temp set temp_qty = temp_qty +" + Convert.ToInt32(quantity_input.Text) + " where temp_name = '" + row.Cells[0].Value + "' and temp_serviceid ='" + row.Cells[4].Value + "'; set sql_safe_updates = 1;";
                                main.CUD_Statement(updfetch);
                                string updsubt = "set sql_safe_updates=0; update fetch_temp set temp_subtotal=(temp_price * temp_qty) where temp_name = '" + row.Cells[0].Value + "' and temp_serviceid ='" + row.Cells[4].Value + "'; set sql_safe_updates = 1;";
                                main.CUD_Statement(updsubt);

                                current = view_item_view.CurrentRow.Index;
                                item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                                view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                                disp_all_item();
                                found = true;
                            }
                        }
                    }

                    // if item is not yet in the datagrid
                    if (!found)
                    {
                        foreach (DataGridViewRow row2 in view_item_view.Rows)
                        {
                            if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                            {
                                amt = Convert.ToInt32(row2.Cells[3].Value);

                            }
                        }
                        if (Convert.ToInt32(quantity_input.Text) > amt)
                        {
                            MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else if (Convert.ToInt32(item_inventory.Text) == 0)
                        {
                            MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int row = 0;
                            item_view.Rows.Add();
                            row = item_view.Rows.Count - 2;
                            item_view.Rows[row].Cells[0].Value = item_input.Text;
                            item_view.Rows[row].Cells[5].Value = item_id.Text;
                            item_view.Rows[row].Cells[1].Value = price_input.Text;
                            item_view.Rows[row].Cells[2].Value = quantity_input.Text;
                            item_view.Rows[row].Cells[4].Value = job_order_sidx.Text;
                            item_view.Rows[row].Cells[3].Value = Convert.ToInt32(price_input.Text) * Convert.ToInt32(quantity_input.Text);
                            item_view.Rows[row].Cells[6].Value = item_type.Text;
                            current = view_item_view.CurrentRow.Index;
                            item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                            view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                            string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                            main.CUD_Statement(inv);
                            disp_all_item();
                            string xyz = "select * from fetch_temp where temp_name='" + item_view.Rows[row].Cells[0].Value + "' and temp_qty='" + item_view.Rows[row].Cells[2].Value + "' and temp_serviceid='" + item_view.Rows[row].Cells[4].Value + "'; ";
                            DataTable dt = new DataTable();
                            dt = main.SELECT_Statement(xyz);

                            if (dt.Rows.Count > 0)
                            {

                            }
                            else
                            {
                                Conn.Open();
                                MySqlCommand cmd2 = new MySqlCommand("insert into fetch_temp(temp_name, temp_price, temp_qty, temp_subtotal, temp_serviceid, temp_itemid, temp_type) values(@tname, @tprice, @tqty, @tstotal, @tservid, @tiid, @titype);", Conn);
                                cmd2.Parameters.AddWithValue("@tname", item_view.Rows[row].Cells[0].Value);
                                cmd2.Parameters.AddWithValue("@tprice", item_view.Rows[row].Cells[1].Value);
                                cmd2.Parameters.AddWithValue("@tqty", item_view.Rows[row].Cells[2].Value);
                                cmd2.Parameters.AddWithValue("@tstotal", item_view.Rows[row].Cells[3].Value);
                                cmd2.Parameters.AddWithValue("@tservid", item_view.Rows[row].Cells[4].Value);
                                cmd2.Parameters.AddWithValue("@tiid", item_view.Rows[row].Cells[5].Value);
                                cmd2.Parameters.AddWithValue("@titype", item_view.Rows[row].Cells[6].Value);
                                cmd2.ExecuteNonQuery();
                                Conn.Close();
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row2 in view_item_view.Rows)
                    {
                        if (item_input.Text == Convert.ToString(row2.Cells[1].Value))
                        {
                            amt = Convert.ToInt32(row2.Cells[3].Value);

                        }
                    }
                    if (Convert.ToInt32(quantity_input.Text) > amt)
                    {
                        MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (Convert.ToInt32(item_inventory.Text) == 0)
                    {
                        MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int row = 0;
                        item_view.Rows.Add();
                        row = item_view.Rows.Count - 2;
                        item_view.Rows[row].Cells[0].Value = item_input.Text;
                        item_view.Rows[row].Cells[5].Value = item_id.Text;
                        item_view.Rows[row].Cells[1].Value = price_input.Text;
                        item_view.Rows[row].Cells[2].Value = quantity_input.Text;
                        item_view.Rows[row].Cells[4].Value = job_order_sidx.Text;
                        item_view.Rows[row].Cells[3].Value = Convert.ToInt32(price_input.Text) * Convert.ToInt32(quantity_input.Text);
                        item_view.Rows[row].Cells[6].Value = item_type.Text;
                        current = view_item_view.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                        view_item_view.Rows[current].Cells[3].Value = item_inventory.Text;
                        string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                        main.CUD_Statement(inv);
                        disp_all_item();
                        string xyz = "select * from fetch_temp where temp_name='" + item_view.Rows[row].Cells[0].Value + "' and temp_qty='" + item_view.Rows[row].Cells[2].Value + "' and temp_serviceid='" + item_view.Rows[row].Cells[4].Value + "'; ";
                        DataTable dt = new DataTable();
                        dt = main.SELECT_Statement(xyz);

                        if (dt.Rows.Count > 0)
                        {

                        }
                        else
                        {
                            Conn.Open();
                            MySqlCommand cmd2 = new MySqlCommand("insert into fetch_temp(temp_name, temp_price, temp_qty, temp_subtotal, temp_serviceid, temp_itemid, temp_type) values(@tname, @tprice, @tqty, @tstotal, @tservid, @tiid, @titype);", Conn);
                            cmd2.Parameters.AddWithValue("@tname", item_view.Rows[row].Cells[0].Value);
                            cmd2.Parameters.AddWithValue("@tprice", item_view.Rows[row].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@tqty", item_view.Rows[row].Cells[2].Value);
                            cmd2.Parameters.AddWithValue("@tstotal", item_view.Rows[row].Cells[3].Value);
                            cmd2.Parameters.AddWithValue("@tservid", item_view.Rows[row].Cells[4].Value);
                            cmd2.Parameters.AddWithValue("@tiid", item_view.Rows[row].Cells[5].Value);
                            cmd2.Parameters.AddWithValue("@titype", item_view.Rows[row].Cells[6].Value);
                            cmd2.ExecuteNonQuery();
                            Conn.Close();

                        }
                    }

                
                }
                disp_fetchy();
                //total
                foreach (DataGridViewRow row in fetch_table_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sum = 0;
                    for (int i = 0; i < fetch_table_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(fetch_table_view.Rows[i].Cells[3].Value);

                    }
                    service_fee_input.Text = Convert.ToString(sum);

                }

                update_button_Click(sender, e);
            }
            quantity_input.Clear();
            item_input.Clear();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            item_view.Rows.Clear();
            price_input.Clear();
            quantity_input.Clear();
            service_fee_input.Clear();
            item_input.Text = null;
            employee_input.Enabled = true;
            service_type_input.Enabled = true;
            update_button.Visible = false;
            update_item.Visible = false;
            service_type_input.Text = string.Empty;
            finished_task_button.Visible = false;
            fetch_table_view.Visible = false;
            employee_input.Text = string.Empty;
            add_button_temp.Visible = true;
            add_item.Visible = true;
            remove_button.Visible = false;
            add_service.Visible = true;
            remove_service.Visible = false;
            service_id.Clear();
            reset_button.Visible = false;
            reset_label.Visible = false;
            task_view.DataSource = null;
            view_item_view.DataSource = null;
        }

        private void problem_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

            if (employee_input.Text == String.Empty && service_fee_input.Text == string.Empty && service_fee_input.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Service on the list.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (employee_input.Text == String.Empty)
            {
                MessageBox.Show("Please Assign an Employee", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (service_type_input.Text == String.Empty)
            {
                MessageBox.Show("Please Select Service", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (employee_input.Items.Contains(employee_input.Text) == false)
            {
                MessageBox.Show("Employee does not exist. \n Please select from the list.");
                employee_input.Text = String.Empty;
            }
            else if (item_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Item/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (job_order_selected_service_view.Rows.Count > 0)
                {
                    bool found1 = false;

                    // add items to another datagrid 
                    foreach (DataGridViewRow row2 in job_order_selected_service_view.Rows)
                    {

                        st = Convert.ToString(row2.Cells[0].Value);
                        string emp = Convert.ToString(row2.Cells[2].Value);
                        if (service_type_input.Text == st && employee_input.Text == emp)
                        {
                            row2.Cells[1].Value = service_fee_input.Text;
                            found1 = true;
                        }

                    }
                    // add items to another datagrid 

                    if (!found1)
                    {

                        DataTable datatb = (DataTable)job_order_selected_service_view.DataSource;
                        DataRow drToAdd = datatb.NewRow();
                        drToAdd[0] = service_type_input.Text;
                        drToAdd[1] = service_fee_input.Text;
                        drToAdd[2] = employee_input.Text;
                        drToAdd[5] = job_order_sid.Text;
                        drToAdd[6] = emp_id.Text;
                        drToAdd[7] = started_input.Value.ToString(format);
                        drToAdd[9] = service_id.Text;
                        datatb.Rows.Add(drToAdd);
                        datatb.AcceptChanges();

                    }
                }
                else
                {
                    DataTable datatb = (DataTable)job_order_selected_service_view.DataSource;
                    DataRow drToAdd = datatb.NewRow();
                    drToAdd[0] = service_type_input.Text;
                    drToAdd[1] = service_fee_input.Text;
                    drToAdd[2] = employee_input.Text;
                    drToAdd[5] = job_order_sid.Text;
                    drToAdd[6] = emp_id.Text;
                    drToAdd[7] = started_input.Value.ToString(format);
                    drToAdd[9] = service_id.Text;
                    datatb.Rows.Add(drToAdd);
                    datatb.AcceptChanges();

                }
                for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                {
                    
                        int sum = Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[1].Value);
                        job_order_selected_service_view.Rows[i].Cells[4].Value = Convert.ToString(sum);
                    
                }

                foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                {
                    int sum = 0;
                    for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                    }
                    total_input.Text = Convert.ToString(sum);

                }
            }
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            Conn.Open();
            // insert errors for combobox with values not found in the database
            if (job_order_selected_service_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Service/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (item_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Item/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                switch (MessageBox.Show("Job Order Status will be changed to FINISHED. \n Changes cannot be made afterwards. \n Would you like to Continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    case DialogResult.No:
                        this.Refresh();
                        break;
                    case DialogResult.Yes:
                        status_id.Text = "3";
                        string query2 = "update job_order set problem_reported='" + problem_input.Text + "'" +
                               ", initial_diagnosis ='" + diagnosis_input.Text + "', req_check_out ='" + requested_date_input.Value.ToString(format) + "', status_type_id_fk='" + Convert.ToInt32(status_id.Text) + "', total_amount='" + Convert.ToInt32(total_input.Text) + "'" +
                               "where job_order_id='" + Convert.ToInt32(job_order_id.Text) + "'";
                        main.CUD_Statement(query2);



                        MySqlCommand cmd8 = new MySqlCommand("set foreign_key_checks=0; truncate inventory; insert into inventory(item_id_inventory_fk, inventory_quantity) select distinct fetch_itemid, fetch_itemqty from fetch_inventory; set foreign_key_checks = 1;", Conn);
                        cmd8.ExecuteNonQuery();




                        int countrow = job_order_selected_service_view.Rows.Count;
                        for (int a = 0; a <= rowc; a++)
                        {

                            if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                            {
                                DateTime ten = DateTime.Now;

                                MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf,time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                cmd2.Parameters.AddWithValue("@ten", ten);
                                cmd2.ExecuteNonQuery();

                            }
                            else
                            {
                                DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf, time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                cmd2.Parameters.AddWithValue("@ten", ten);
                                cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                cmd2.ExecuteNonQuery();

                            }

                        }



                        for (int a = rowc+1; a < countrow; a++)
                        {
                            string ex = "select * from job_order_services where service_type_job_order_fk= '" + job_order_selected_service_view.Rows[a].Cells[9].Value +
                                "' and emp_id_job_order_fk ='" + job_order_selected_service_view.Rows[a].Cells[6].Value + "' and time_started_serv='" + job_order_selected_service_view.Rows[a].Cells[7].Value + "'";
                            DataTable dt = new DataTable();
                            dt = main.SELECT_Statement(ex);

                            if (dt.Rows.Count > 0)
                            {
                                if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                {
                                    DateTime ten = DateTime.Now;

                                    MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf,time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                    cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                    cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                    cmd2.Parameters.AddWithValue("@ten", ten);
                                    cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();
                                }
                                else
                                {
                                    DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                    MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; update job_order_services set service_fee=@servf,time_ended_serv=@ten, subtotal_job_order=@total_serv where job_order_services_id=@jids; set foreign_key_checks=1;", Conn);
                                    cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                    cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@jids", job_order_selected_service_view.Rows[a].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                    cmd2.Parameters.AddWithValue("@ten", ten);
                                    cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                    cmd2.ExecuteNonQuery();


                                }

                            }
                            else
                            {
                                if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[7].Value) == string.Empty)
                                {

                                }
                                else
                                {
                                    if (Convert.ToString(job_order_selected_service_view.Rows[a].Cells[8].Value) == string.Empty)
                                    {
                                        DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);
                                        DateTime ten = DateTime.Now;

                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk, job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                        cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                        cmd2.Parameters.AddWithValue("@tstart", tst);
                                        cmd2.Parameters.AddWithValue("@tend", ten);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);

                                        cmd2.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        DateTime tst = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[7].Value);
                                        DateTime ten = Convert.ToDateTime(job_order_selected_service_view.Rows[a].Cells[8].Value);

                                        MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk, job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
                                        cmd2.Parameters.AddWithValue("@stid", job_order_selected_service_view.Rows[a].Cells[9].Value);
                                        cmd2.Parameters.AddWithValue("@servf", job_order_selected_service_view.Rows[a].Cells[1].Value);
                                        cmd2.Parameters.AddWithValue("@eid", job_order_selected_service_view.Rows[a].Cells[6].Value);
                                        cmd2.Parameters.AddWithValue("@labf", job_order_selected_service_view.Rows[a].Cells[3].Value);
                                        cmd2.Parameters.AddWithValue("@tstart", tst);
                                        cmd2.Parameters.AddWithValue("@total_serv", job_order_selected_service_view.Rows[a].Cells[4].Value);
                                        cmd2.Parameters.AddWithValue("@tend", ten);
                                        cmd2.ExecuteNonQuery();
                                    }
                                }
                            }

                        }

                        MySqlCommand cmd3 = Conn.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "select * from fetch_temp where temp_itemid is not null";
                        cmd3.ExecuteNonQuery();
                        DataTable dt3 = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                        da.Fill(dt3);
                        trialgrid.DataSource = dt3;

                        foreach (DataGridViewRow row in trialgrid.Rows)
                        {
                            if (row.IsNewRow) continue;
                            for (int a = 0; a < trialgrid.Rows.Count; a++)
                            {
                                if (Convert.ToString(trialgrid.Rows[a].Cells[5].Value) == string.Empty)
                                {

                                }
                                else
                                {
                                    string q = "set foreign_key_checks=0;";
                                    main.CUD_Statement(q);
                                    string z = "select * from stock_order_details where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                    DataTable dtz = new DataTable();
                                    dtz = main.SELECT_Statement(z);

                                    if (dtz.Rows.Count > 0)
                                    {
                                        string upditem = "update stock_order_details set stock_order_item_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_order_details= '" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "' where item_id_stock_order_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_order_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        main.CUD_Statement(upditem);
                                        string upditem2 = "update stock_out_details set stock_out_quantity='" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "', total_stock_out_details= '" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "' where item_id_stock_out_fk ='" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "' and job_order_id_stock_out_fk='" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "'";
                                        main.CUD_Statement(upditem2);
                                    }
                                    else
                                    {
                                        string additem2 = "insert into stock_order_details(item_id_stock_order_fk, stock_order_item_quantity, job_order_id_stock_order_fk, total_stock_order_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "')";
                                        main.CUD_Statement(additem2);
                                        string additem3 = "insert into stock_out_details(item_id_stock_out_fk, stock_out_quantity, job_order_id_stock_out_fk, total_stock_out_details) values('" + Convert.ToInt32(trialgrid.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trialgrid.Rows[a].Cells[3].Value) + "')";
                                        main.CUD_Statement(additem3);

                                    }

                                    string q2 = "set foreign_key_checks=1;";
                                    main.CUD_Statement(q2);
                                }
                            }
                        }

                        MySqlCommand cmd4 = Conn.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "select * from fetch_temp where temp_itemid is not null";
                        cmd4.ExecuteNonQuery();
                        DataTable dt4= new DataTable();
                        MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
                        da.Fill(dt4);
                        trial_grid4.DataSource = dt4;

                        foreach (DataGridViewRow row in trial_grid4.Rows)
                        {

                            if (row.IsNewRow) continue;
                            for (int a = 0; a < trial_grid4.Rows.Count; a++)
                            {
                                if (Convert.ToString(trial_grid4.Rows[a].Cells[4].Value) == string.Empty)
                                {

                                }
                                else
                                {
                                    string q = "set foreign_key_checks=0;";
                                    main.CUD_Statement(q);
                                    string z = "select * from job_order_items where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                    DataTable dtz = new DataTable();
                                    dtz = main.SELECT_Statement(z);

                                    if (dtz.Rows.Count > 0)
                                    {
                                        string upditem = "update job_order_items set job_order_items_quantity='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "', total_job_order_items='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value) + "' where item_id_job_order_fk ='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "' and job_order_services_id_fk='" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "'";
                                        main.CUD_Statement(upditem);


                                    }

                                    // insert items from fetch_temp to job_order_items
                                    else
                                    {
                                        string additem = "insert into job_order_items(item_id_job_order_fk, job_order_items_quantity, job_order_services_id_fk, total_job_order_items) values ('" + Convert.ToInt32(trial_grid4.Rows[a].Cells[5].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[2].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[4].Value) + "','" + Convert.ToInt32(trial_grid4.Rows[a].Cells[3].Value) + "');";
                                        main.CUD_Statement(additem);

                                    }

                                    string q2 = "set foreign_key_checks=1;";
                                    main.CUD_Statement(q2);
                                }
                            }
                        }

                        // there should be a prompt to continue 
                        // insert list of all services with items
                        // job order is created
                        MessageBox.Show("Job Order is Finished.\n You may now generate the Bill.");
                        //fetch_temp should be truncated
                        MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                        cmd.ExecuteNonQuery();
                        Job_Order_Details k = new Job_Order_Details();
                        js = job_order_id.Text;
                        k.Show();
                        this.Hide();
                        break;
                }
            }
            Conn.Close();
        }

        private void view_item_view_Click(object sender, EventArgs e)
        {

        }

        private void fetch_table_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fetchinv.Text = "0";
            if (e.RowIndex > -1)
            {
                if (fetch_table_view.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    MessageBox.Show("Row cannot be selected.");
                }
                else
                {
                    remove_button.Visible = true;
                    update_item.Visible = true;
                    item_id.Text = fetch_table_view.Rows[e.RowIndex].Cells[5].Value.ToString();
                    item_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                    price_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                    quantity_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                    update_item.Visible = true;
                    Conn.Open();
                    MySqlCommand cmd = Conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select job_order_items_quantity from job_order_items where item_id_job_order_fk='" + Convert.ToInt32(fetch_table_view.Rows[e.RowIndex].Cells[5].Value) + "' and  job_order_services_id_fk='" + Convert.ToInt32(fetch_table_view.Rows[e.RowIndex].Cells[4].Value) + "'";
                    MySqlDataReader sd = cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        fetchinv.Text = sd.GetString("job_order_items_quantity");
                    }
                    Conn.Close();
                }
            }

        }

        private void update_item_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.fetch_table_view.SelectedRows)
            {
                int fetchtempid = Convert.ToInt32(item.Cells[5].Value);
                int fetchtempqty = Convert.ToInt32(item.Cells[2].Value);
                int fetchtemp_serv = Convert.ToInt32(item.Cells[4].Value);
                switch (MessageBox.Show("Are you sure you want to change \n the item quantity of " + item.Cells[0].Value + " to " + quantity_input.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        if (Convert.ToInt32(quantity_input.Text) < Convert.ToInt32(fetchinv.Text))
                        {
                            MessageBox.Show("Quantity cannot be updated. \n Please try a number NOT LESS THAN " + fetchinv.Text + "");
                        }
                        else if (Convert.ToInt32(quantity_input.Text) == 0)
                        {
                            switch (MessageBox.Show("Would you like to delete the entire row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {

                                case DialogResult.No:
                                    break;
                                case DialogResult.Yes:
                                    if (string.IsNullOrEmpty(item_input.Text))
                                    {
                                        MessageBox.Show("Please select an item in the list");

                                    }
                                    else
                                    {
                                        // item inventory should be back to original quantity
                                        foreach (DataGridViewRow item3 in this.fetch_table_view.SelectedRows)
                                        {
                                            tempid = Convert.ToInt32(item3.Cells[5].Value);
                                            tempqty = Convert.ToInt32(item3.Cells[2].Value);

                                            foreach (DataGridViewRow item2 in view_item_view.Rows)
                                            {
                                                if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                                                {
                                                    int qty = Convert.ToInt32(item2.Cells[3].Value);
                                                    int add = qty + tempqty;
                                                    string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + Convert.ToString(add) + "' where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                                                    main.CUD_Statement(inv);
                                                    fetch_table_view.Rows.RemoveAt(item3.Index);
                                                    disp_all_item();

                                                }
                                            }


                                            Conn.Open();
                                            MySqlCommand cmd8 = Conn.CreateCommand();
                                            cmd8.CommandType = CommandType.Text;
                                            cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                                            cmd8.ExecuteNonQuery();
                                            Conn.Close();
                                        }
                                        update_button_Click(sender, e);
                                    }
                                    break;

                            }
                        }

                        else
                        {
                            foreach (DataGridViewRow item3 in this.fetch_table_view.SelectedRows)
                            {
                                tempid = Convert.ToInt32(item3.Cells[5].Value);
                                int tempqty = Convert.ToInt32(item3.Cells[2].Value) - Convert.ToInt32(quantity_input.Text);
                                item3.Cells[2].Value = quantity_input.Text;

                                foreach (DataGridViewRow item2 in view_item_view.Rows)
                                {
                                    if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                                    {
                                        int qty = Convert.ToInt32(item2.Cells[3].Value);
                                        int add = qty + tempqty;
                                        item2.Cells[3].Value = Convert.ToString(add);
                                    }
                                }
                                update_button_Click(sender, e);


                                Conn.Open();
                                MySqlCommand cmd8 = Conn.CreateCommand();
                                cmd8.CommandType = CommandType.Text;
                                cmd8.CommandText = "set sql_safe_updates=0; update fetch_temp set temp_qty='" + quantity_input.Text + "' where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "';set sql_safe_updates=1;";
                                cmd8.ExecuteNonQuery();
                                MySqlCommand cmd9 = Conn.CreateCommand();
                                cmd9.CommandType = CommandType.Text;
                                cmd9.CommandText = "set sql_safe_updates=0; update fetch_temp set temp_subtotal=(temp_price * " + quantity_input.Text + ") where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "';set sql_safe_updates=1;";
                                cmd9.ExecuteNonQuery();
                                Conn.Close();
                                disp_fetchy();
                            }
                        }
                        break;
                }
                foreach (DataGridViewRow row in fetch_table_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sum = 0;
                    for (int i = 0; i < fetch_table_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(fetch_table_view.Rows[i].Cells[3].Value);

                    }
                    service_fee_input.Text = Convert.ToString(sum);

                }
                update_button_Click(sender, e);
                item_input.Clear();
                quantity_input.Clear();
            }
        }

        private void fetch_table_view_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_input.Text))
            {
                MessageBox.Show("Please select an item in the list");

            }
            else
            {
                foreach (DataGridViewRow item in this.fetch_table_view.SelectedRows)
                {

                    int fetchtempid = Convert.ToInt32(item.Cells[5].Value);
                    int fetchtempqty = Convert.ToInt32(item.Cells[2].Value);
                    int fetchtemp_serv = Convert.ToInt32(item.Cells[4].Value);
                    string qz = "select * from fetch_temp where temp_type='1' and temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "';";
                    DataTable dt = new DataTable();
                    dt = main.SELECT_Statement(qz);

                    if (dt.Rows.Count == 0)
                    {

                        Conn.Open();
                        MySqlCommand cmd8 = Conn.CreateCommand();
                        cmd8.CommandType = CommandType.Text;
                        cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                        cmd8.ExecuteNonQuery();
                        MySqlCommand cmd9 = Conn.CreateCommand();
                        cmd9.CommandType = CommandType.Text;
                        cmd9.CommandText = "set sql_safe_updates=0; delete from job_order_items where item_id_job_order_fk='" + fetchtempid + "' and job_order_services_id_fk='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                        cmd9.ExecuteNonQuery();
                        service_fee_input.Text = Convert.ToString(Convert.ToInt32(service_fee_input.Text) - Convert.ToInt32(item.Cells[3].Value));
                        Conn.Close();
                        foreach (DataGridViewRow row in view_item_view.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == fetchtempid)
                            {
                                int qty = Convert.ToInt32(row.Cells[3].Value);
                                int add = qty + fetchtempqty;
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + Convert.ToString(add) + "' where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                                disp_all_item();
                            }
                        }
                        fetch_table_view.Rows.RemoveAt(item.Index);
                        update_button_Click(sender, e);
                    

                    item_input.Clear();
                    quantity_input.Clear();
                }
                    else
                    {
                       
                        Conn.Open();
                        MySqlCommand cmd8 = Conn.CreateCommand();
                        cmd8.CommandType = CommandType.Text;
                        cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                        cmd8.ExecuteNonQuery();
                        MySqlCommand cmd9 = Conn.CreateCommand();
                        cmd9.CommandType = CommandType.Text;
                        cmd9.CommandText = "set sql_safe_updates=0; delete from job_order_items where item_id_job_order_fk='" + fetchtempid + "' and job_order_services_id_fk='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                        cmd9.ExecuteNonQuery();
                        service_fee_input.Text = Convert.ToString(Convert.ToInt32(service_fee_input.Text) - Convert.ToInt32(item.Cells[3].Value));
                        Conn.Close();
                        foreach (DataGridViewRow row in view_item_view.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == fetchtempid)
                            {
                                int qty = Convert.ToInt32(row.Cells[3].Value);
                                int add = qty + fetchtempqty;
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + Convert.ToString(add) + "' where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                                disp_all_item();
                            }
                        }
                        fetch_table_view.Rows.RemoveAt(item.Index);
                        update_button_Click(sender, e);
                    }
                }

                    item_input.Clear();
                    quantity_input.Clear();

                }
        }

        private void quantity_input_KeyPress(object sender, KeyPressEventArgs e)
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
    private void add_service_Click(object sender, EventArgs e)
        {
            if (employee_input.Text == String.Empty)
            {
                MessageBox.Show("Please Assign an Employee", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else if (service_type_input.Text == String.Empty)
            {
                MessageBox.Show("Please Select Service", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (employee_input.Items.Contains(employee_input.Text) == false)
            {
                MessageBox.Show("Employee does not exist. \n Please select from the list.");
                employee_input.Text = String.Empty;
            }
            else if (item_view.Rows.Count == 0)
            {
                MessageBox.Show("Please Input Item/s", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (job_order_selected_service_view.Rows.Count > 0)
                {
                    bool found1 = false;
                    
                    // add items to another datagrid 
                    foreach (DataGridViewRow row2 in job_order_selected_service_view.Rows)
                    {

                        st = Convert.ToString(row2.Cells[0].Value);
                        string emp = Convert.ToString(row2.Cells[2].Value);
                        if (service_type_input.Text == st && employee_input.Text == emp)
                        {
                            MessageBox.Show("Service Type is already on the list.\nClick the row if you wish to update it.");

                            foreach (DataGridViewRow item2 in fetch_table_view.Rows)
                            {
                                int fetchtempid = Convert.ToInt32(item2.Cells[5].Value);
                                int fetchtempqty = Convert.ToInt32(item2.Cells[2].Value);
                                int fetchtemp_serv = Convert.ToInt32(item2.Cells[4].Value);
                                Conn.Open();
                                MySqlCommand cmd8 = Conn.CreateCommand();
                                cmd8.CommandType = CommandType.Text;
                                cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_serviceid='" + job_order_sid.Text + "'; set sql_safe_updates=1;";
                                cmd8.ExecuteNonQuery();
                                Conn.Close();
                                foreach (DataGridViewRow row in view_item_view.Rows)
                                {

                                    if (Convert.ToInt32(row.Cells[0].Value) == fetchtempid)
                                    {
                                        int qty = Convert.ToInt32(row.Cells[3].Value);
                                        string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty=fetch_itemqty+'" + fetchtempqty + "' where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                                        main.CUD_Statement(inv);
                                        disp_all_item();
                                    }

                                }
                                fetch_table_view.Visible = false;
                            }
                            found1 = true;
                        }

                    }
                    // add items to another datagrid 

                    if (!found1)
                    {

                        DataTable datatb = (DataTable)job_order_selected_service_view.DataSource;
                        DataRow drToAdd = datatb.NewRow();
                        drToAdd[0] = service_type_input.Text;
                        drToAdd[1] = service_fee_input.Text;
                        drToAdd[2] = employee_input.Text;
                        drToAdd[4] = Convert.ToInt32(service_fee_input.Text);
                        drToAdd[5] = job_order_sid.Text;
                        drToAdd[6] = emp_id.Text;
                        drToAdd[7] = started_input.Value.ToString(format);
                        drToAdd[9] = service_id.Text;
                        datatb.Rows.Add(drToAdd);
                        datatb.AcceptChanges();

                    } 
                }
                else
                {
                    DataTable datatb = (DataTable)job_order_selected_service_view.DataSource;
                    DataRow drToAdd = datatb.NewRow();
                    drToAdd[0] = service_type_input.Text;
                    drToAdd[1] = service_fee_input.Text;
                    drToAdd[2] = employee_input.Text;
                    drToAdd[4] = Convert.ToInt32(service_fee_input.Text);
                    drToAdd[5] = job_order_sid.Text;
                    drToAdd[6] = emp_id.Text;
                    drToAdd[7] = started_input.Value.ToString(format);
                    drToAdd[9] = service_id.Text;
                    datatb.Rows.Add(drToAdd);
                    datatb.AcceptChanges();

                }
                
                foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                {
                    int sum = 0;
                    for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                    }
                    total_input.Text = Convert.ToString(sum);

                }
                string one = "1";
                int x = int.Parse(job_order_sid.Text) + int.Parse(one);
                job_order_sid.Text = Convert.ToString(x);
                job_order_sidx.Text = job_order_sid.Text;
                reset_button_Click(sender, e);
            }
        }
    }
}
