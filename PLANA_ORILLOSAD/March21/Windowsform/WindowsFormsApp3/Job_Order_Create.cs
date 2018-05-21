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
    public partial class Job_Order_Create : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        public static string jobids;

        public Job_Order_Create()
        {

            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }

        public void filljobox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from job_order order by job_order_id asc;";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("job_order_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);

            }
            job_order_id.Text = Convert.ToString(add);

            Conn.Close();
        }

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

        private void Job_Order_Create_Load(object sender, EventArgs e)
        {
            filljobox();
            combobox_employee();
            combobox_plate();
            combobox_servicetype();
            filljobdetailsox();
            Conn.Open();
            string additem = "insert into fetch_inventory(fetch_itemid, fetch_itemname, fetch_price, fetch_itemqty, fetch_brand, fetch_measurement, fetch_servid, fetch_itemtype, fetch_supp) SELECT distinct item.item_id, item.item_name, item.item_selling_price, inventory.inventory_quantity, item.item_brand, item.item_measurement, s.service_id, item_type_id_fk, sup.supplier_name FROM ITEM, INVENTORY, SERVICE s, SERVICE_DETAILS sd, SUPPLIER sup WHERE item.item_id=inventory.item_id_inventory_fk and sd.item_id_service_fk=item.item_id and sd.service_type_fk_details=s.service_id and inventory.inventory_quantity >0 and sup.supplier_id=item.supplier_id_item_fk;";
            main.CUD_Statement(additem);
            Conn.Close();
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
        public void disp_all_item()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT * from fetch_inventory where fetch_servid='" +service_id.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            da2.Fill(dt);
            view_item_view.DataSource = dt;
           
            Conn.Close();
            view_item_view.Columns[1].HeaderText = "Name";
            view_item_view.Columns[2].HeaderText = "Price";
            view_item_view.Columns[3].HeaderText = "In Stock";
            view_item_view.Columns[4].HeaderText = "Brand";
            view_item_view.Columns[5].HeaderText = "Measure";
            view_item_view.Columns[6].HeaderText = "ServiceID";
            view_item_view.Columns[6].Visible = false;
            view_item_view.Columns[7].Visible = false;
            view_item_view.Columns[8].HeaderText = "Supplier";
        }

        private void combobox_plate()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT plate_number FROM vehicle;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            plate_text.Items.Add("");
            while (dr.Read())
            {
                plate_text.Items.Add(dr[0]);
            }
            Conn.Close();
            // search function
            string actual = plate_text.Text;


            int index = plate_text.FindString(actual);
            if (index > -1)
            {
                string found = plate_text.Items.ToString();

                plate_text.SelectionStart = actual.Length;
                plate_text.SelectionLength = found.Length;
                plate_text.SelectedIndex = index;
            }


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
 
        private void back_button_Click(object sender, EventArgs e)
        {
            Conn.Open();
            if (problem_input.Text == string.Empty && diagnosis_input.Text == string.Empty && plate_text.Text == string.Empty && cust_input.Text == string.Empty && service_type_input.Text == string.Empty && service_fee_input.Text == string.Empty && employee_input.Text == string.Empty && total_input.Text == string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand("TRUNCATE fetch_inventory;", Conn);
                cmd2.ExecuteNonQuery();
                Job_Order_List g = new Job_Order_List();
                g.Show();
                this.Hide();
            }
            else
            {
                switch (MessageBox.Show("Are you sure you want to leave? \nChanges you have made will not be saved.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:

                        //fetch_temp should be truncated
                        MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                        cmd.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand("TRUNCATE fetch_inventory;", Conn);
                        cmd2.ExecuteNonQuery();
                        Job_Order_List g = new Job_Order_List();
                        g.Show();
                        this.Hide();

                        break;
                    case DialogResult.No:

                        break;
                }
                Conn.Close();
            }
        }




        private void services_tab_Click(object sender, EventArgs e)
        {

        }

        private void item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                MessageBox.Show("Service Type cannot be blank");
            }
            else
            {
                service_fee_input.Clear();
                item_input.Enabled = true;
                quantity_input.Enabled = true;
                price_input.Enabled = true;
                employee_input.Enabled = true;

            }
            item_input.Text = null;
            quantity_input.Clear();
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

        private void plate_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            plate_text.DropDownStyle = ComboBoxStyle.DropDown;
            plate_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            plate_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT v.cust_id_vehicle_fk, concat(c.cust_fname, ' ', c.cust_lname) as fullc FROM customer c, vehicle v where c.cust_id=v.cust_id_vehicle_fk and v.plate_number='" + plate_text.SelectedText + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cust_id.Text = dr.GetString("cust_id_vehicle_fk");
                cust_input.Text = dr.GetString("fullc");
            }
            Conn.Close();
        }

       


        private void add_item_button_Click(object sender, EventArgs e)
        {

        }


        string itemname;
        int current, amt;
        private void add_item_Click(object sender, EventArgs e)
        {
           
            if (service_type_input.Text == String.Empty)
            {
                MessageBox.Show("Please select a Service Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((service_type_input.Items.Contains(service_type_input.Text) == false))
            {
                MessageBox.Show("Service type is not valid. Please choose from the list.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            else if (Convert.ToInt32(item_inventory.Text)==0)
            {
                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fetch_table_view.Visible = true;
                service_type_input.Enabled = false;
                bool found = false;
                if (fetch_table_view.Rows.Count > 0)
                {
                    service_type_input.Enabled = false;
                    // add items to another datagrid 
                    foreach (DataGridViewRow row in fetch_table_view.Rows)
                    {
                        if (row.IsNewRow) continue;
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
                                string updsubt = "set sql_safe_updates=0; update fetch_temp set temp_subtotal=(temp_price * temp_qty) where temp_name = '" + row.Cells[0].Value + "' and temp_serviceid ='" + row.Cells[4].Value + "'; set sql_safe_updates = 1;";
                                main.CUD_Statement(updsubt);
                                current = view_item_view.CurrentRow.Index;
                                item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
                                string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty='" + item_inventory.Text + "' where fetch_itemid='" + item_id.Text + "'; set sql_safe_updates=1;";
                                main.CUD_Statement(inv);
                            }
                            disp_all_item();
                            found = true;
                            
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
                        else {
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
                    //total
                    disp_fetchy();
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
            quantity_input.Clear();
            item_input.Clear();
        }
        public int sum2;
        private void remove_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_input.Text))
            {
                MessageBox.Show("Please select an item in the list");

            }
            else
            {
                // item inventory should be back to original quantity
                foreach (DataGridViewRow item in this.fetch_table_view.SelectedRows
                    )
                {

                    int fetchtempid = Convert.ToInt32(item.Cells[5].Value);
                    int fetchtempqty = Convert.ToInt32(item.Cells[2].Value);
                    int fetchtemp_serv = Convert.ToInt32(item.Cells[4].Value);
                    Conn.Open();
                    MySqlCommand cmd8 = Conn.CreateCommand();
                    cmd8.CommandType = CommandType.Text;
                    cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                    cmd8.ExecuteNonQuery();
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
                
                item_input.Clear();
                quantity_input.Clear();
            }
            foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
            {
                if (row.IsNewRow) continue;
                int sum = 0;
                for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                {

                    sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                }
                total_input.Text = Convert.ToString(sum);

            }
        }

        public void filljobdetailsox()
        {
            string one = "1";
            int add = 0;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from job_order_services order by job_order_services_id asc;";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string list = sdr.GetString("job_order_services_id");
                add = int.Parse(list);



            }
            job_order_serviceid.Text = Convert.ToString(add);
            int ans = int.Parse(job_order_serviceid.Text) + int.Parse(one);
            job_order_sid.Text = Convert.ToString(ans);
            Conn.Close();
        }

        string st;
        private void add_service_Click(object sender, EventArgs e)
        {
            if (employee_input.Text == String.Empty && service_type_input.Text == string.Empty)
            {
                MessageBox.Show("Please input all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    fetch_table_view.Visible = false;
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
                                        string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty=fetch_itemqty+'" + fetchtempqty + "' where fetch_itemid='" + fetchtempid  + "'; set sql_safe_updates=1;";
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
                        int row = 0;
                        job_order_selected_service_view.Rows.Add();
                        row = job_order_selected_service_view.Rows.Count - 1;

                        job_order_selected_service_view["stype", row].Value = service_type_input.Text;
                        job_order_selected_service_view["sfee", row].Value = service_fee_input.Text;
                        job_order_selected_service_view["em", row].Value = employee_input.Text;
                        job_order_selected_service_view["sidval", row].Value = job_order_sid.Text;
                        job_order_selected_service_view["ts", row].Value = started_input.Value.ToString(format);
                        job_order_selected_service_view["idofemp", row].Value = emp_id.Text;
                        job_order_selected_service_view["idofserv", row].Value = service_id.Text;
                        job_order_selected_service_view["subtotal", row].Value = Convert.ToInt32(Convert.ToInt32(service_fee_input.Text));
                       

                    }
                }
                else
                {


                    int row = 0;
                    job_order_selected_service_view.Rows.Add();
                    row = job_order_selected_service_view.Rows.Count - 1;

                    job_order_selected_service_view["stype", row].Value = service_type_input.Text;
                    job_order_selected_service_view["sfee", row].Value = service_fee_input.Text;
                    job_order_selected_service_view["em", row].Value = employee_input.Text;
                    job_order_selected_service_view["sidval", row].Value = job_order_sid.Text;
                    job_order_selected_service_view["ts", row].Value = started_input.Value.ToString(format);
                    job_order_selected_service_view["idofemp", row].Value = emp_id.Text;
                    job_order_selected_service_view["idofserv", row].Value = service_id.Text;
                    job_order_selected_service_view["subtotal", row].Value = Convert.ToInt32(Convert.ToInt32(service_fee_input.Text));
                  
                }

                //total
                foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                {
                    if (row.IsNewRow) continue;
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
                reset_button_Click(sender, e);
            }
        }

        public void disp_fetchy()
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
       
        public void disp_fetch()
        {
            Conn.Open();
            MySqlCommand cmd8 = Conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select * from fetch_temp where temp_serviceid='" + jsid + "'";
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
        //string jsid;
        private void job_order_selected_service_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void job_order_serviceid_TextChanged(object sender, EventArgs e)
        {

        }
        public static string format = "yyyy-MM-dd HH:mm:ss";
        public static string idemp;
        private void save_button_Click(object sender, EventArgs e)
        {
            Conn.Open();
            // insert errors for combobox with values not found in the database
            if (plate_text.Text == String.Empty)
            {
                MessageBox.Show("Please Select Vehicle", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (job_order_selected_service_view.Rows.Count == 0)
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

                    switch (MessageBox.Show("The requested release date has already passed. \n Status will be changed to PAST DEADLINE. \n Would you like to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {

                        case DialogResult.No:
                            MessageBox.Show("Please set a requested date beyond the current date.");
                            this.Refresh();
                            break;
                        case DialogResult.Yes:
                            status_id.Text = "1";
                            string query2 = "insert into job_order(job_order_id, " +
                                    "plate_number_fk, problem_reported, initial_diagnosis, req_check_out, check_in, status_type_id_fk, total_amount) VALUES " +
                                    "('" + Convert.ToInt32(job_order_id.Text) + "','" +
                                    "" + plate_text.Text + "','" +
                                    "" + problem_input.Text + "','" +
                                    "" + diagnosis_input.Text + "','" +
                                    "" + requested_date_input.Value.ToString(format) + "','" +
                                    "" + check_in_date_input.Value.ToString(format) + "','" +
                                    "" + Convert.ToInt32(status_id.Text) + "','"+
                                    "" + Convert.ToInt32(total_input.Text) +"')";
                            main.CUD_Statement(query2);

                          
                                    MySqlCommand cmd8 = new MySqlCommand("set foreign_key_checks=0; truncate inventory; insert into inventory(item_id_inventory_fk, inventory_quantity) select distinct fetch_itemid, fetch_itemqty from fetch_inventory; set foreign_key_checks = 1;", Conn);
                                    cmd8.ExecuteNonQuery();

                            int countrow = job_order_selected_service_view.Rows.Count;
                            foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                            {
                                for (int a = 0; a < countrow; a++)
                                {
                                    string ex = "select * from job_order_services where service_type_job_order_fk= '" + job_order_selected_service_view.Rows[a].Cells[9].Value +
                                        "' and emp_id_job_order_fk ='" + job_order_selected_service_view.Rows[a].Cells[6].Value + "' and service_fee ='" + job_order_selected_service_view.Rows[a].Cells[1].Value + "' and time_started_serv='" + job_order_selected_service_view.Rows[a].Cells[7].Value + "'";
                                    DataTable dt = new DataTable();
                                    dt = main.SELECT_Statement(ex);

                                    if (dt.Rows.Count > 0)
                                    {
                                    }
                                    else
                                        if (job_order_selected_service_view.Rows[a].Cells[7].Value == null)
                                    {

                                    }
                                    else
                                    {
                                        if (job_order_selected_service_view.Rows[a].Cells[8].Value == null)
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

                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk,  job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
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
                            string q = "set foreign_key_checks=0;";
                            main.CUD_Statement(q);
                            // insert items from fetch_temp to job_order_items
                            string additem = "insert into job_order_items(item_id_job_order_fk, job_order_items_quantity, job_order_services_id_fk, total_job_order_items) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null;";
                            main.CUD_Statement(additem);
                            string additem2 = "insert into stock_order_details(item_id_stock_order_fk, stock_order_item_quantity, job_order_id_stock_order_fk, total_stock_order_details) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null and temp_type='2';";
                            main.CUD_Statement(additem2);
                            string additem3 = "insert into stock_out_details(item_id_stock_out_fk, stock_out_quantity, job_order_id_stock_out_fk, total_stock_out_details) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null and temp_type='2';";
                            main.CUD_Statement(additem3);
                            string q2 = "set foreign_key_checks=1;";
                            main.CUD_Statement(q2);
                            // there should be a prompt to continue 
                            // insert list of all services with items
                            // job order is created
                            MessageBox.Show("Job Order Created!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //fetch_temp should be truncated
                            MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                            cmd.ExecuteNonQuery();
                            //view details
                            //Job_Order_Details k = new Job_Order_Details();
                            Job_Order_List k = new Job_Order_List();
                            jobids = job_order_id.Text;
                            k.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    switch (MessageBox.Show("Are you sure you want to create the Job Order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {

                        case DialogResult.No:
                            break;
                        case DialogResult.Yes:
                            string query2 = "insert into job_order(job_order_id, " +
                                    "plate_number_fk, problem_reported, initial_diagnosis, req_check_out, check_in, status_type_id_fk, total_amount) VALUES " +
                                    "('" + Convert.ToInt32(job_order_id.Text) + "','" +
                                    "" + plate_text.Text + "','" +
                                    "" + problem_input.Text + "','" +
                                    "" + diagnosis_input.Text + "','" +
                                    "" + requested_date_input.Value.ToString(format) + "','" +
                                    "" + check_in_date_input.Value.ToString(format) + "','" +
                                    "" + Convert.ToInt32(status_id.Text) + "','" +
                                    "" + Convert.ToInt32(total_input.Text) + "')";
                            main.CUD_Statement(query2);

                            MySqlCommand cmd8 = new MySqlCommand("set foreign_key_checks=0; truncate inventory; insert into inventory(item_id_inventory_fk, inventory_quantity) select distinct fetch_itemid, fetch_itemqty from fetch_inventory; set foreign_key_checks = 1;", Conn);
                            cmd8.ExecuteNonQuery();



                            int countrow = job_order_selected_service_view.Rows.Count;
                            foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                            {
                                for (int a = 0; a < countrow; a++)
                                {
                                    string ex = "select * from job_order_services where service_type_job_order_fk= '" + job_order_selected_service_view.Rows[a].Cells[9].Value +
                                        "' and emp_id_job_order_fk ='" + job_order_selected_service_view.Rows[a].Cells[6].Value + "' and service_fee ='" + job_order_selected_service_view.Rows[a].Cells[1].Value + "' and time_started_serv='" + job_order_selected_service_view.Rows[a].Cells[7].Value + "'";
                                    DataTable dt = new DataTable();
                                    dt = main.SELECT_Statement(ex);

                                    if (dt.Rows.Count > 0)
                                    {
                                    }
                                    else
                                        if (job_order_selected_service_view.Rows[a].Cells[7].Value == null)
                                    {

                                    }
                                    else
                                    {
                                        if (job_order_selected_service_view.Rows[a].Cells[8].Value == null)
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

                                            MySqlCommand cmd2 = new MySqlCommand("set foreign_key_checks=0; insert into job_order_services(service_type_job_order_fk, service_fee, emp_id_job_order_fk,  job_order_id_serv_fk,time_started_serv, time_ended_serv, subtotal_job_order) VALUES(@stid, @servf, @eid," + Convert.ToInt32(job_order_id.Text) + ", @tstart, @tend, @total_serv); set foreign_key_checks=1;", Conn);
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
                            string q = "set foreign_key_checks=0;";
                            main.CUD_Statement(q);
                            // insert items from fetch_temp to job_order_items
                            string additem = "insert into job_order_items(item_id_job_order_fk, job_order_items_quantity, job_order_services_id_fk, total_job_order_items) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null;";
                            main.CUD_Statement(additem);
                            string additem2 = "insert into stock_order_details(item_id_stock_order_fk, stock_order_item_quantity, job_order_id_stock_order_fk, total_stock_order_details) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null and temp_type='2';";
                            main.CUD_Statement(additem2);
                            string additem3 = "insert into stock_out_details(item_id_stock_out_fk, stock_out_quantity, job_order_id_stock_out_fk, total_stock_out_details) select temp_itemid, temp_qty, temp_serviceid, temp_subtotal from fetch_temp where temp_serviceid is not null and temp_type='2';";
                            main.CUD_Statement(additem3);
                            string q2 = "set foreign_key_checks=1;";
                            main.CUD_Statement(q2);
                            // there should be a prompt to continue 
                            // insert list of all services with items
                            // job order is created
                            MessageBox.Show("Job Order Created!", "BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //fetch_temp should be truncated
                            MySqlCommand cmd = new MySqlCommand("TRUNCATE fetch_temp;", Conn);
                            cmd.ExecuteNonQuery();
                            //view details
                            //Job_Order_Details k = new Job_Order_Details();
                            Job_Order_List k = new Job_Order_List();
                            jobids = job_order_id.Text;
                            k.Show();
                            this.Hide();
                            idemp = job_order_id.Text;
                            break;
                    }
                }
            }
            Conn.Close();
        }
        DateTime ten;

        private void vehicle_release_Click(object sender, EventArgs e)
        {
         
            

        }
        int serid;
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

                        service_fee_input.Clear();
                    }
                   
                    reset_button_Click(sender, e);
                    job_order_selected_service_view.Rows.RemoveAt(item.Index);
                }
                foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                {
                    if (row.IsNewRow) continue;
                    int sum = 0;
                    for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                    }
                    total_input.Text = Convert.ToString(sum);

                }
            }
        }

        private void fetch_table_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void item_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (service_type_input.Text == string.Empty)
            {
                MessageBox.Show("Please Choose Service Type First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                   // add_item.Visible = false;
                    item_id.Text = view_item_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                    item_input.Text = view_item_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                    price_input.Text = view_item_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                    item_inventory.Text = view_item_view.Rows[e.RowIndex].Cells[3].Value.ToString();
                    item_type.Text = view_item_view.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
        }

        private void fetch_table_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                if (fetch_table_view.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    MessageBox.Show("Row cannot be selected.");
                }
                 else
                {
                    update_item.Visible = true;
                    remove_button.Visible = true;
                    item_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                    price_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                    quantity_input.Text = fetch_table_view.Rows[e.RowIndex].Cells[2].Value.ToString();

                }
            }
        }

        private void item_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (service_fee_input.Text == string.Empty)
            {
                MessageBox.Show("There are no existing items on the list.");
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    if (item_view.Rows[e.RowIndex].Cells[0].Value == null)
                    {
                        MessageBox.Show("Row cannot be selected.");
                    }
                    else
                    {
                        item_input.Text = item_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                        price_input.Text = item_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                        quantity_input.Text = item_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                }
            }
        }
        string jsid;
        private void job_order_selected_service_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_view.Rows.Clear();
                if (total_input.Text == string.Empty)
                {
                    MessageBox.Show("There are no existing services on the list.");
                }

                else
                {
                    service_id.Text = Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[9].Value);
                    //disp_all_item();



                    if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[8].Value) == string.Empty)
                    {
                        finished_task_button.Visible = true;
                        remove_service.Visible = true;
                        add_button_temp.Visible = true;
                        remove_button.Visible = true;
                        update_button.Visible = true;
                        edit_time_ended.Visible = false;

                    }
                    else
                    {
                        finished_task_button.Visible = false;
                        remove_service.Visible = false;
                        add_button_temp.Visible = false;
                        remove_button.Visible = false;
                        update_button.Visible = false;
                        edit_time_ended.Visible = true;

                    }
                    if (e.RowIndex > -1)
                    {



                        if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[0].Value) == string.Empty)
                        {
                            MessageBox.Show("Row cannot be selected.");
                        }
                        else if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[0].Value) != string.Empty)
                        {
                            fetch_table_view.Visible = true;
                            disp_fetch();
                            employee_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                            service_type_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                            jsid = job_order_selected_service_view.Rows[e.RowIndex].Cells[5].Value.ToString();
                            service_fee_input.Text = job_order_selected_service_view.Rows[e.RowIndex].Cells[1].Value.ToString();

                        }
                        else if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[8].Value) == string.Empty)
                        {
                            finished_task_button.Visible = true;
                            remove_service.Visible = true;
                            add_button_temp.Visible = true;
                            remove_button.Visible = true;
                            update_button.Visible = true;
                            edit_time_ended.Visible = false;


                        }
                        else
                        {

                            finished_task_button.Visible = false;
                            remove_service.Visible = false;
                            add_button_temp.Visible = false;
                            remove_button.Visible = false;
                            update_button.Visible = false;
                            update_item.Visible = false;
                            edit_time_ended.Visible = true;

                        }
                        add_item.Visible = false;
                        fetch_table_view.Visible = true;

                        disp_fetch();
                    }
                    else if (Convert.ToString(job_order_selected_service_view.Rows[e.RowIndex].Cells[8].Value) == string.Empty)
                    {
                        finished_task_button.Visible = true;
                        remove_service.Enabled = true;
                        this.remove_service.UseVisualStyleBackColor = true;
                        this.remove_service.ForeColor = System.Drawing.Color.Black;
                        remove_button.Enabled = true;
                        this.remove_button.UseVisualStyleBackColor = true;
                        this.remove_button.ForeColor = System.Drawing.Color.Black;
                        edit_time_ended.Visible = false;

                    }
                    else
                    {
                        finished_task_button.Visible = false;
                        remove_service.Enabled = false;
                        this.remove_service.BackColor = System.Drawing.Color.DarkGray;
                        this.remove_service.ForeColor = System.Drawing.Color.White;
                        remove_button.Enabled = false;
                        this.remove_button.BackColor = System.Drawing.Color.DarkGray;
                        this.remove_button.ForeColor = System.Drawing.Color.White;
                        edit_time_ended.Visible = true;

                    }
                    fetch_table_view.Visible = true;
                    service_type_input.Enabled = false;
                    fetch_table_view.Visible = true;
                    employee_input.Enabled = false;
                    add_service.Visible = false;
                }
                fetch_table_view.Visible = true;
                service_type_input.Enabled = false;
                fetch_table_view.Visible = true;
                employee_input.Enabled = false;
                add_service.Visible = false;
                reset_button.Visible = true;
                reset_label.Visible = true;
            }
        }
            private void cust_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void finished_task_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.job_order_selected_service_view.SelectedRows)
            {
                switch (MessageBox.Show("Are you sure you want set Task to Finished?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        item.Cells[8].Value = DateTime.Now.ToString(format);
                        remove_service.Visible = false;
                        add_service.Visible = false;
                        remove_button.Visible = false;
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

        private void item_view_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_button_temp_Click(object sender, EventArgs e)
        {

          //  item_view.Visible = false;
            bool found = false;
            int amt=0;
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
            else if (Convert.ToInt32(item_inventory.Text) == 0)
            {
                MessageBox.Show("You do not have enough Stocks", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (fetch_table_view.Rows.Count > 0)
                {
                    service_type_input.Enabled = false;
                    // add items to another datagrid 
                    foreach (DataGridViewRow row in fetch_table_view.Rows)
                    {
                    

                        if (row.IsNewRow) continue;
                        itemname = Convert.ToString(row.Cells[0].Value);
                        string jobsid = Convert.ToString(row.Cells[4].Value);
                        if (item_input.Text == itemname && jsid == jobsid)
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
                        }
                        disp_all_item();
                            found = true;
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
                            item_view.Rows[row].Cells[4].Value = jsid;
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
                        item_view.Rows[row].Cells[4].Value = jsid;
                        item_view.Rows[row].Cells[3].Value = Convert.ToInt32(price_input.Text) * Convert.ToInt32(quantity_input.Text);
                        item_view.Rows[row].Cells[6].Value = item_type.Text;
                        current = view_item_view.CurrentRow.Index;
                        item_inventory.Text = (Convert.ToString(Convert.ToInt32(item_inventory.Text) - Convert.ToInt32(quantity_input.Text)));
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
            update_button_Click(sender, e);
            quantity_input.Clear();
            item_input.Clear();
        }
            private void job_order_selected_service_view_Click(object sender, EventArgs e)
        {

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

        private void diagnosis_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (employee_input.Text == String.Empty && service_fee_input.Text == string.Empty && service_fee_input.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Service on the list.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void fetch_table_view_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void basic_info_tab_Click(object sender, EventArgs e)
        {

        }

        private void reset_item_Click(object sender, EventArgs e)
        {
            item_input.Text = null;
            service_type_input.Text = null;
            service_id.Clear();
            item_id.Clear();
            price_input.Clear();
            quantity_input.Clear();
            service_fee_input.Clear();
            disp_fetch();
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

                        if (Convert.ToInt32(quantity_input.Text) == 0)
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
                                            int tempid = Convert.ToInt32(item3.Cells[5].Value);
                                            int tempqty = Convert.ToInt32(item3.Cells[2].Value);

                                            foreach (DataGridViewRow item2 in view_item_view.Rows)
                                            {
                                                if (Convert.ToInt32(item2.Cells[0].Value) == tempid)
                                                {
                                                    int qty = Convert.ToInt32(item2.Cells[3].Value);
                                                    int add = qty + tempqty;
                                                    item2.Cells[3].Value = Convert.ToString(add);
                                                    fetch_table_view.Rows.RemoveAt(item3.Index);
                                                }
                                            }


                                            Conn.Open();
                                            MySqlCommand cmd8 = Conn.CreateCommand();
                                            cmd8.CommandType = CommandType.Text;
                                            cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                                            cmd8.ExecuteNonQuery();
                                            Conn.Close();
                                        }
                                    }
                                    break;

                            }
                        }

                        else
                        {
                            foreach (DataGridViewRow item3 in this.fetch_table_view.SelectedRows)
                            {
                                int tempid = Convert.ToInt32(item3.Cells[5].Value);
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

                            }



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
                       

                        break;
                }
                foreach (DataGridViewRow row in fetch_table_view.Rows)
                {
                    //if (row.IsNewRow) continue;

                    int sum = 0;
                    for (int i = 0; i < fetch_table_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(fetch_table_view.Rows[i].Cells[3].Value);

                    }
                    service_fee_input.Text = Convert.ToString(sum);
                    //update_button_Click(sender, e);
                    item_input.Clear();
                    quantity_input.Clear();

                }
                foreach (DataGridViewRow row in job_order_selected_service_view.Rows)
                {
                    if (row.IsNewRow) continue;
                    int sum = 0;
                    for (int i = 0; i < job_order_selected_service_view.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(job_order_selected_service_view.Rows[i].Cells[4].Value);

                    }
                    total_input.Text = Convert.ToString(sum);

                }
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

        private void edit_time_ended_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.job_order_selected_service_view.SelectedRows)
            {
                switch (MessageBox.Show("Are you sure you want to edit the finished task?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        remove_button.Visible = true;
                        item.Cells[8].Value = "";
                        remove_service.Visible = true;
                        add_service.Visible = true;
                        add_item.Visible = true;
                        add_button_temp.Visible = true;
                        update_button.Visible = true;
                        update_item.Visible = true;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        /* private void clear_button_Click(object sender, EventArgs e)
         {
             foreach (DataGridViewRow item in fetch_table_view.Rows)
             {
                 int fetchtempid = Convert.ToInt32(item.Cells[5].Value);
                 int fetchtempqty = Convert.ToInt32(item.Cells[2].Value);
                 int fetchtemp_serv = Convert.ToInt32(item.Cells[4].Value);
                 Conn.Open();
                 MySqlCommand cmd8 = Conn.CreateCommand();
                 cmd8.CommandType = CommandType.Text;
                 cmd8.CommandText = "set sql_safe_updates=0; delete from fetch_temp where temp_itemid='" + fetchtempid + "' and temp_serviceid='" + fetchtemp_serv + "'; set sql_safe_updates=1;";
                 cmd8.ExecuteNonQuery();
                 service_fee_input.Text = string.Empty;
                 string inv = "set sql_safe_updates=0; update fetch_inventory set fetch_itemqty=fetch_itemqty+" + fetchtempqty + " where fetch_itemid='" + fetchtempid + "'; set sql_safe_updates=1;";
                 main.CUD_Statement(inv);
                 Conn.Close();
             }
             disp_all_item();
             service_type_input.Text = null;
             fetch_table_view.Visible = false;
         }
         */
    }
}
   
