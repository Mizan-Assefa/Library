using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Librarysystem
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L6DGNCK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            */
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from LibririanTable where libname = '"+username.Text+"' and libpassword = '"+password.Text+"'", con);
            DataTable dt = new DataTable();     
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Mainpage main = new Mainpage();
                main.Show();
            }
            else
                MessageBox.Show("error while LogIn");
            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)

            {
                password.UseSystemPasswordChar = false;
            }
            else
                password.UseSystemPasswordChar = true;
        }
    }
}
