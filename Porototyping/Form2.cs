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

namespace Porototyping
{
    public partial class Form2 : Form
    {
        public string user;
        public string pass;
        public string host;
        public string db;
       
        public Form2()
        {
            InitializeComponent();
        }


        public bool ConnectionTest()
        {
            string connectionString = "server=" + host + ";database=" + db + ";user id=" + user + ";password=" + pass + ";";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MessageBox.Show(":D");
                conn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ...practice more.");
                return false;
            }
        }


        public bool ConnectionTest(string query)
        {
            string connectionString = "server=" + host + ";user id=" + user + ";password=" + pass + ";";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database stablished :D");
                conn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ...practice more.");
                return false;
            }
        }




        private void BtnLogin_Click(object sender, EventArgs e)
        {
            user = txtUser.Text; 
            pass = txtPass.Text;
            host = txtHost.Text;
            db = txtDb.Text;

            bool conexion = false;

            if (txtUser.Text != "" && txtPass.Text != "" && txtHost.Text != "" && txtDb.Text != "")
            {
                conexion = ConnectionTest();
                Form1 form1 = new Form1(conexion, user, pass, host, db);
                form1.Show();
                this.Close();
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;
            host = txtHost.Text;
            db = txtDb.Text;

            string query = "CREATE DATABASE " + db+";";
            ConnectionTest(query);
        }
    }
}
