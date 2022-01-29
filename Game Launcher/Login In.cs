using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Game_Launcher
{
    public partial class Login_In : Form
    {
        public static string user = String.Empty;
        public Login_In()
        {
            InitializeComponent();
        }

        private void Login_In_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FM3KDMT;Initial Catalog=drag;Integrated Security=True");
            string Query = "select * from high where gusername='" + this.textBox1.Text + "' and gpassword='" + this.textBox2.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.Hide();
                string username = this.textBox1.Text;
                user = username;
            }
            else
            {
                dr.Close();
                MessageBox.Show("Account Not Found! If You Don't have an Account, Try Signing Up.");
            }
            sqlConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
