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
    public partial class Job_Order_Payment : Form
    {
        Class1 main;
        MySqlConnection Conn;
        Job_Order_Details g;
        public Job_Order_Payment()
        {
            InitializeComponent();
            main = new Class1();

            Conn = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;pwd=root;");

        }

        private void Payment_Load(object sender, EventArgs e)
        {
          
            fillpayment();
            disp_hist();
            total_text.Text = Job_Order_Details.tots;

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

 

        private void paid_text_TextChanged(object sender, EventArgs e)
        {
            if (paid_text.Text == string.Empty)
            {
                balance_text.Text = string.Empty;
            }
            else
            {
                balance_text.Text = Convert.ToString(Convert.ToInt32(total_text.Text) - Convert.ToInt32(paid_text.Text));
            }
        }
        public static int jpid;

        public void fillpayment()
        {
            int add = 1;
            Conn.Open();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select job_order_payment_id, balance from job_order_payment order by job_order_payment_id asc;";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string list = sdr.GetString("job_order_payment_id");
                string one = "1";
                add = int.Parse(list) + int.Parse(one);
            }
            jpid = Convert.ToInt32(add);

            Conn.Close();
        }

        public static string bal="";
        public static int jid;
        public static string format = "yyyy-MM-dd HH:mm:ss";
        private void record_button_Click(object sender, EventArgs e)
        {
            if (paid_text.Text == string.Empty)
            {
                MessageBox.Show("Please input amount paid.");
                paid_text.Clear();
            }
            else if (!paid_text.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please use numbers only.");
                paid_text.Clear();
            }       
            else if(Convert.ToInt32(paid_text.Text) > Convert.ToInt32(Job_Order_Details.tots)) {
                MessageBox.Show("Amount is more than the balance.");
                paid_text.Clear();
            }
            else
            {
                string q = "insert into job_order_payment(job_order_payment_id, jp_job_order_id, amount_paid, balance, date_payment) VALUES ('" +jpid +"','" + Job_Order_Details.jobid +"','" + Convert.ToDouble(paid_text.Text) +"','" + Convert.ToDouble(balance_text.Text) + "','" +date_pay.Value.ToString(format) +"')";
                main.CUD_Statement(q);


                if (Convert.ToInt32(balance_text.Text) == 0)
                {
                    string q2 = "update job_order set status_type_id_fk='4', check_out='" + date_pay.Value.ToString(format) + "' where job_order_id='" + Job_Order_Details.jobid + "'";
                    main.CUD_Statement(q2);

                    switch (MessageBox.Show("Payment is recorded and complete.\n The customer may now claim the vehicle. \n Would you like to print the Receipt?", "Job Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {

                        case DialogResult.Yes:
                            new Job_Order_Receipt(jpid).ShowDialog();
                            break;

                        case DialogResult.No:
                            break;

                    }
                }
                else
                {
                    switch (MessageBox.Show("Payment is recorded.\n The customer has a remaining balance of " + balance_text.Text + ". \n Would you like to print the Receipt?", "Job Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {

                        case DialogResult.Yes:
                            new Job_Order_Receipt(jpid).ShowDialog();
                            break;

                        case DialogResult.No:
                            break;

                    }

                }
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            payment_panel.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            payment_panel.Visible= false;
        }

        private void paid_text_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
