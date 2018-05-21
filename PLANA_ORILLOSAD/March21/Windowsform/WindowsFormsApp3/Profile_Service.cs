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
    public partial class Profile_Service : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Profile_Service()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
        }

        public void disp_fetch()
        {
            Conn.Open();
            MySqlCommand cmd8 = Conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select i.item_id, i.item_name, i.item_measurement, i.item_brand, i.item_purchase_price, i.item_selling_price, s.supplier_id, s.supplier_name from item i, supplier s, service_details sd, service where sd.item_id_service_fk=i.item_id and sd.service_type_fk_details=service.service_id and i.supplier_id_item_fk=s.supplier_id and service_type_fk_details='" + servid.Text + "'";
            cmd8.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd8);
            da.Fill(dt2);
            service_items_view.DataSource = dt2;
            service_items_view.Columns[0].HeaderText = "Item ID";
            service_items_view.Columns[0].Visible = false;
            service_items_view.Columns[1].HeaderText = "Item Name";
            service_items_view.Columns[2].HeaderText = "Measurement";
            service_items_view.Columns[3].HeaderText = "Brand";
            service_items_view.Columns[4].HeaderText = "Purchase Price";
            service_items_view.Columns[5].HeaderText = "Selling Price";
            service_items_view.Columns[6].HeaderText = "Supplier ID";
            service_items_view.Columns[6].Visible = false;
            service_items_view.Columns[7].HeaderText = "Supplier";
            Conn.Close();


        }
        public void fillserox()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from service order by service_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string list = sdr.GetString("service_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);

            }
            servid.Text = Convert.ToString(add);

            Conn.Close();
        }

        private void Profile_Service_Load(object sender, EventArgs e)
        {
            fillserox();
            combobox_item();
            disp_data();

        }

        public void disp_data()
        {
            // displaying data on data grid
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from service;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            service_view.DataSource = dt;
            Conn.Close();
            service_view.Columns[0].HeaderText = "Service ID";
            service_view.Columns[0].Visible = false;
            service_view.Columns[1].HeaderText = "Service Type";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Conn.Open();
            if (service_type_text.Text ==string.Empty)
            {
                MessageBox.Show("Please Input Service Type", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ex = "select * from service where service_type='" + service_type_text.Text + "'";
                DataTable dt = new DataTable();
                dt = main.SELECT_Statement(ex);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Service Type Already Exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query =
                               "INSERT INTO service(service_id, service_type)" +
                                "VALUES('"+ servid.Text +"','" + service_type_text.Text + "')";

                    int countrow = service_items_view.Rows.Count;
                    for (int i = 0; i < countrow; i++)
                    {
                        MySqlCommand cmd = new MySqlCommand("set foreign_key_checks=0; INSERT INTO service_details(service_type_fk_details, item_id_service_fk) VALUES (" + servid.Text + ",@iditem); set foreign_key_checks=1;", Conn);
                        cmd.Parameters.AddWithValue("@iditem", service_items_view.Rows[i].Cells[0].Value);
                        cmd.ExecuteNonQuery();


                    }
                    main.CUD_Statement(query);
                    MessageBox.Show("Service Type Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            Conn.Close();
            disp_data();
            string one = "1";
            int x = int.Parse(servid.Text) + int.Parse(one);
            service_id.Text = Convert.ToString(x);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            servid.Clear();
            service_type_text.Clear();
            add_button.Enabled = true;
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.ForeColor = System.Drawing.Color.White;
            item_name_text.Enabled = false;
            update_button.Enabled = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Profile_Page g = new Profile_Page();
            g.Show();
            this.Hide();
        }

        private void service_type_text_TextChanged(object sender, EventArgs e)
        {

        }
        int current;
        private void update_button_Click(object sender, EventArgs e)
        {

            // Insert update function
            if (service_type_text.Text == string.Empty)
            {
                MessageBox.Show("Please Input Service Type.");
            }
            else
            {
                Conn.Open();
                current = service_view.CurrentRow.Index;
                int id = Convert.ToInt32(service_view.Rows[current].Cells[0].Value);
                string query = " UPDATE service set service_type ='" + service_type_text.Text + "' where service_id = '" + servid.Text + "'";
                main.CUD_Statement(query);
                Conn.Close();
                
                MessageBox.Show("Service Type Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disp_data();
                item_name_text.Text = string.Empty;
                service_type_text.Clear();
            }
        }
        private void combobox_item()
        {  //adding database items in dropdown

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT item_name FROM item;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cmd.ExecuteReader();
            item_name_text.Items.Add("");
            while (dr.Read())
            {
                item_name_text.Items.Add(dr[0]);
            }
            Conn.Close();

            // search function
            string actual = item_name_text.Text;


            int index = item_name_text.FindString(actual);
            if (index > -1)
            {
                string found = item_name_text.Items.ToString();

                item_name_text.SelectionStart = actual.Length;
                item_name_text.SelectionLength = found.Length;
                item_name_text.SelectedIndex = index;
            }
        }
        private void item_name_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_name_text.DropDownStyle = ComboBoxStyle.DropDown;
            item_name_text.AutoCompleteSource = AutoCompleteSource.ListItems;
            item_name_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select i.item_id, i.item_measurement, i.item_brand, i.item_purchase_price, i.item_selling_price, s.supplier_id, s.supplier_name from item i, supplier s where i.supplier_id_item_fk=s.supplier_id and item_name='" + item_name_text.SelectedText + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                item_id.Text = sdr.GetString("item_id");
                measure_text.Text = sdr.GetString("item_measurement");
                brand_text.Text = sdr.GetString("item_brand");
                purchase_price_text.Text = sdr.GetString("item_purchase_price");
                selling_price_text.Text = sdr.GetString("item_selling_price");
                supplier_text.Text = sdr.GetString("supplier_name");
                supplier_id.Text = sdr.GetString("supplier_id");

                add_item.Enabled = true;
                remove_item.Enabled = true;


            }

            Conn.Close();
        }

        string itemid;
        private void add_item_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (string.IsNullOrEmpty(item_name_text.Text))
            {
                MessageBox.Show("Please select an item in the list");

            }
            else if (item_name_text.Items.Contains(item_name_text.Text) == false)
            {
                MessageBox.Show("Please Select an Item from the List.");
                item_name_text.Text = string.Empty;
            }
            else if (service_items_view.Rows.Count > 0)
            {
                // add items to another datagrid 

                foreach (DataGridViewRow row in service_items_view.Rows)
                {

                    itemid = Convert.ToString(row.Cells[0].Value);
                    if (item_id.Text == itemid)
                    {
                        MessageBox.Show("Item is already on the list.");
                        found = true;

                    }

                }

                // if item is not yet in the datagrid
                if (!found)
                {

                    DataTable datatb = (DataTable)service_items_view.DataSource;
                    DataRow drToAdd = datatb.NewRow();

                    drToAdd[0] = item_id.Text;
                    drToAdd[1] = item_name_text.Text;
                    drToAdd[2] = brand_text.Text;
                    drToAdd[3] = measure_text.Text;
                    drToAdd[4] = selling_price_text.Text;
                    drToAdd[5] = purchase_price_text.Text;
                    drToAdd[6] = supplier_id.Text;
                    drToAdd[7] = supplier_text.Text;

                    datatb.Rows.Add(drToAdd);
                    datatb.AcceptChanges();
                }
            }
            else
            {

                DataTable datatb = (DataTable)service_items_view.DataSource;
                DataRow drToAdd = datatb.NewRow();


                drToAdd[0] = item_id.Text;
                drToAdd[1] = item_name_text.Text;
                drToAdd[2] = brand_text.Text;
                drToAdd[3] = measure_text.Text;
                drToAdd[4] = selling_price_text.Text;
                drToAdd[5] = purchase_price_text.Text;
                drToAdd[6] = supplier_id.Text;
                drToAdd[7] = supplier_text.Text;


                datatb.Rows.Add(drToAdd);
                datatb.AcceptChanges();
            }
            int countrow = service_items_view.Rows.Count;
            for (int i = 0; i < countrow; i++)
            {
                string ex = "select * from service_details where item_id_service_fk='" + service_items_view.Rows[i].Cells[0].Value + "' and service_type_fk_details='" + servid.Text + "'";
                DataTable dt = new DataTable();
                dt = main.SELECT_Statement(ex);

                if (dt.Rows.Count > 0)
                {

                }
                else
                {
                    Conn.Open();
                    MySqlCommand cmd = new MySqlCommand("set foreign_key_checks=0; INSERT INTO service_details(service_type_fk_details, item_id_service_fk) VALUES (" + servid.Text + ",@iditem); set foreign_key_checks=1;", Conn);
                    cmd.Parameters.AddWithValue("@iditem", service_items_view.Rows[i].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                }

            }
            item_name_text.Text = string.Empty;
            measure_text.Clear();
            brand_text.Clear();
            supplier_text.Clear();
            supplier_id.Clear();
            purchase_price_text.Clear();
            selling_price_text.Clear();
        }

        private void service_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                servid.Text = service_view.Rows[e.RowIndex].Cells["service_id"].Value.ToString();
                service_type_text.Text = service_view.Rows[e.RowIndex].Cells["service_type"].Value.ToString();
                add_button.Enabled = false;
                this.add_button.BackColor = System.Drawing.Color.DarkGray;
                this.add_button.ForeColor = System.Drawing.Color.White;
                update_button.Enabled = true;
                disp_fetch();
                item_name_text.Enabled = true;
            }
        }

        private void service_items_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_name_text.Text = service_items_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                remove_item.Enabled = true;
                add_item.Enabled = true;
            }
        }

        private void remove_item_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_name_text.Text))
            {
                MessageBox.Show("Please select an item in the list");

            }
            else if (item_name_text.Items.Contains(item_name_text.Text) == false)
            {
                MessageBox.Show("Please Select an Item from the List.");
                item_name_text.Text = string.Empty;
            }
            else
            {
                // item inventory should be back to original quantity
                foreach (DataGridViewRow item in this.service_items_view.SelectedRows)
                {
                    Conn.Open();
                    MySqlCommand cmd = new MySqlCommand("set sql_safe_updates=0; delete from service_details where service_type_fk_details='" + servid.Text + "' and item_id_service_fk=@iditem; set sql_safe_updates=1;", Conn);
                    cmd.Parameters.AddWithValue("@iditem", item.Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    service_items_view.Rows.RemoveAt(item.Index);
                    item_name_text.Text = string.Empty;
                    measure_text.Clear();
                    brand_text.Clear();
                    supplier_text.Clear();
                    supplier_id.Clear();
                    purchase_price_text.Clear();
                    selling_price_text.Clear();
                }
            }
        }
    }
}
