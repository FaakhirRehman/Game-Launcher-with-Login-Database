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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FM3KDMT;Initial Catalog=drag;Integrated Security=True");
                string Query = "insert into high values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "');";
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlConnection.Open();
                int execute = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Your Account Has Been Created! You can Now Close this Window and Login From the Login Window.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occured!" + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
