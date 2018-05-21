using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Class1
    {
        public MySqlConnection con;

        public Class1()
        {
            con = new MySqlConnection("Server=localhost;Database=mltp_shop;uid=root;password=root");
        }
        public DataTable SELECT_Statement(String query)
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand(query, con);
            MySqlDataAdapter mda = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();

            mda.Fill(dt);
            con.Close();
            return dt;

        }
        public void CUD_Statement(string query)
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();

        }
    }
}