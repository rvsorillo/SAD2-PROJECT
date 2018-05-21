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
    public partial class Job_Order_Receipt : Form
    {
        Class1 main;
        MySqlConnection Conn;
        public static int id;
        public Job_Order_Receipt(int p)
        {
            main = new Class1();
            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");
            InitializeComponent();
        }
        public void finddata()
        {
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select jp_job_order_id from job_order_payment where job_order_payment_id ='" + Job_Order_Payment.jpid +"'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                id = sdr.GetInt32("jp_job_order_id");
            }
            Conn.Close();
        }

        private void Job_Order_Receipt_Load(object sender, EventArgs e)
        {
            finddata();
            Job_Order_Payment g = new Job_Order_Payment();
            g.Hide();
            Job_Order_Print_Receipt ob = new Job_Order_Print_Receipt();
            ob.SetParameterValue("joborderpaymentid", Job_Order_Payment.jpid);
            ob.SetParameterValue("joborderid", id);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
