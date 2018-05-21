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
    public partial class Job_Order_View_Payments : Form
    {
        Class1 main;
        MySqlConnection Conn;
        MySqlDataReader sdr;
        public Job_Order_View_Payments()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }

        public void disp_hist()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT amount_paid, date_payment FROM job_order_payment where jp_job_order_id='" + Job_Order_Details.jobid + "' and amount_paid is not null";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            payment_view.DataSource = dt;
            payment_view.Columns[0].HeaderText = "Amount Paid";
            payment_view.Columns[1].HeaderText = "Date of Payment";
            Conn.Close();
        }

        private void Job_Order_View_Payments_Load(object sender, EventArgs e)
        {
            disp_hist();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
