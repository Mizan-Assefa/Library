using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarysystem
{
    public partial class LibririanForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L6DGNCK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        public LibririanForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage main = new Mainpage();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            con.Open();
            string query = "select * from libririanTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianData.DataSource = ds.Tables[0];

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             if(lidnum.Text == "" || lname.Text == "" || Lpassword.Text == "" || Lphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
             else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LibririanTable VALUES (" +lidnum.Text+ ",'" +lname.Text+ "','" +Lpassword.Text+"','"+Lphone.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librrian added successufly!!");
                con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lidnum.Text == "") //|| lname.Text == "" || Lpassword.Text == "" || Lphone.Text == ""
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                con.Open();
                string quary = "Update  LibririanTable set  libname = '" + lname.Text + "',libpassword = '" + Lpassword.Text + "',libphone = '" + Lphone.Text + "' where libid= " + lidnum.Text + ";";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librrian Data updated successufly!!");
                con.Close();
                populate();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            lidnum.Text = LibrarianData.SelectedRows[0].Cells[0].Value.ToString();
            lname.Text = LibrarianData.SelectedRows[0].Cells[1].Value.ToString();
            Lpassword.Text = LibrarianData.SelectedRows[0].Cells[2].Value.ToString();
            Lphone.Text = LibrarianData.SelectedRows[0].Cells[3].Value.ToString();
        */}

        private void LibririanForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lidnum.Text == "")
            {
                MessageBox.Show("Enter the Librarian Id");
            }
            else
            {
                con.Open();
                string quary = "delete from LibririanTable where libid =" + lidnum.Text + ";";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librrian deleted successufly!!");
                con.Close();
                populate();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lidnum.Text = "";
            lname.Text = "";
            Lpassword.Text = "";
            Lphone.Text = "";
        }
    }
}
