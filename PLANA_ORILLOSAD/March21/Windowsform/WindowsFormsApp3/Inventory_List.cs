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
    public partial class Inventory_List : Form
    {
        Class1 main;
        MySqlConnection Conn;

        public Inventory_List()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }
        // Display Data on Data grid
        public void disp_data()
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
            inventory_view.Columns[5].HeaderText = "Quantity";
            inventory_view.Columns[6].HeaderText = "Supplier";
            inventory_view.Columns[7].HeaderText = "Contact Person";
            foreach (DataGridViewRow row in inventory_view.Rows)
            {
                for (int a = 0; a < inventory_view.Rows.Count; a++)
                {
                    if (Convert.ToInt32(inventory_view.Rows[a].Cells[5].Value) <= 10)
                    {
                        inventory_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        inventory_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                    }
                }
            }

        }

        // Display Data on Data grid
        public void disp_con()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT i.item_id, i.item_name, it. item_type, i.item_measurement, i.item_selling_price, inv.inventory_quantity, s.supplier_name, s.supplier_contact_person FROM INVENTORY inv, SUPPLIER s, ITEM i, item_type it WHERE inv.item_id_inventory_fk=i.item_id and i.supplier_id_item_fk=s.supplier_id and i.item_type_id_fk=it.item_type_id and it.item_type='Consumable';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            con_view.DataSource = dt;
            Conn.Close();
            con_view.Columns[0].HeaderText = "Item ID";
            con_view.Columns[0].Visible = false;
            con_view.Columns[1].HeaderText = "Item Name";
            con_view.Columns[2].HeaderText = "Item Type";
            con_view.Columns[3].HeaderText = "Measurement";
            con_view.Columns[4].HeaderText = "Selling Price";
            con_view.Columns[5].HeaderText = "Quantity";
            con_view.Columns[6].HeaderText = "Supplier";
            con_view.Columns[7].HeaderText = "Contact Person";
            foreach (DataGridViewRow row in con_view.Rows)
            {
                for (int a = 0; a < con_view.Rows.Count; a++)
                {
                    if (Convert.ToInt32(con_view.Rows[a].Cells[5].Value) <= 10)
                    {
                        con_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        con_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                    }
                }
            }
        }

        // Display Data on Data grid
        public void disp_par()
        {

            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT i.item_id, i.item_name, it. item_type, i.item_measurement, i.item_selling_price, inv.inventory_quantity, s.supplier_name, s.supplier_contact_person FROM INVENTORY inv, SUPPLIER s, ITEM i, item_type it WHERE inv.item_id_inventory_fk=i.item_id and i.supplier_id_item_fk=s.supplier_id and i.item_type_id_fk=it.item_type_id and it.item_type='Part';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            par_view.DataSource = dt;
            Conn.Close();
            par_view.Columns[0].HeaderText = "Item ID";
            par_view.Columns[0].Visible = false;
            par_view.Columns[1].HeaderText = "Item Name";
            par_view.Columns[2].HeaderText = "Item Type";
            par_view.Columns[3].HeaderText = "Measurement";
            par_view.Columns[4].HeaderText = "Selling Price";
            par_view.Columns[5].HeaderText = "Quantity";
            par_view.Columns[6].HeaderText = "Supplier";
            par_view.Columns[7].HeaderText = "Contact Person";
            foreach (DataGridViewRow row in par_view.Rows)
            {
                for (int a = 0; a < par_view.Rows.Count; a++)
                {
                    if (Convert.ToInt32(par_view.Rows[a].Cells[5].Value) <= 10)
                    {
                        par_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        par_view.Rows[a].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                    }
                }
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Inventory_Page g = new Inventory_Page();
            g.Show();
            this.Hide();
        }

        private void Inventory_List_Load(object sender, EventArgs e)
        {
            // Call view function
            disp_data();
            disp_con();
            disp_par();
        }

        private void inventory_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
