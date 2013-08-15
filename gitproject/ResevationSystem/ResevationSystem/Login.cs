using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace ResevationSystem
{
    public partial class Login : Form
    {
        string username, password;
        
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Dash d = new Dash();
            //d.Show();

            if (!(txtUsername.Text.Length > 0))
            {
                MessageBox.Show("Not a valid user name");

            }
            else if (!(txtPassword.Text.Length > 5))
            {
                MessageBox.Show("Not a valid password");

            }
            else
            {
                try
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    CheckUser(username, password);

                }
                catch
                {

                    MessageBox.Show("Cannot Establish connection to the database,contact your network administrator");

                }




            }

        }
            public void CheckUser(string username, string password)
        {
           SqlConnection con = new SqlConnection("Data Source=SPORTSSTADIA\\SQLEXPRESS;Initial Catalog=HM2; User ID=hm2; Password=stadia4321");
           //SqlConnection con = new SqlConnection("Data Source=EMC2\\SQLEXPRESS;Initial Catalog=HM2; User ID=hm; Password=stadia4321");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * FROM IUsers where UserName ='" + username + "' and Password= '" + password + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                Dash d = new Dash();
                this.Hide();

                username = dataSet.Tables[0].Rows[0]["UserName"].ToString();
               // password = dataSet.Tables[0].Rows[0]["Password"].ToString();
                this.Hide();

                string welcome = "Welcome: ";
                // objDash.txtwelcome.Text = welcome;
                //objDash.statusBarTextblock.Text = username;
                //objDash.Show();
                d.Show();

            }
            else { MessageBox.Show("Username or password is incorrect"); }
            con.Close();
           
           
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalendarHome dt = new CalendarHome();
            dt.Show();
        }


        
    }
}
