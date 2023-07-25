using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Librarysystem
{
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L6DGNCK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        public student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            con.Open();
            string query = "select * from studentTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentData.DataSource = ds.Tables[0];

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage main = new Mainpage();
            main.Show();
        }

        private void student_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sidnum.Text == "" || sname.Text == "" || sdepartment.Text == "" || syear.Text == "" || sphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO studentTable VALUES (" + sidnum.Text + ",'" + sname.Text + "','" + sdepartment.Text + "','" + syear.Text + "', '" + sphone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("student added successufly!!");
                con.Close();
                populate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sidnum.Text == "")
            {
                MessageBox.Show("Enter the sudent Id");
            }
            else
            {
                con.Open();
                string quary = "delete from studentTable where Stid =" + sidnum.Text + ";";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("student Deleted successufly!!");
                con.Close();
                populate();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sidnum.Text == "" || sname.Text == "" || sdepartment.Text == "" || syear.Text == "" || sphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string quary = "Update  studentTable set  stname = '" + sname.Text + "',department = '" + sdepartment.Text + "',sem = '" + syear.Text + "',stphone = '" + sphone.Text + "' where Stid = "+sidnum.Text + ";";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Data updated successufly!!");
                con.Close();
                populate();

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            sidnum.Text = "";
            sname.Text = "";
            sdepartment.Text = "";
            syear.Text = "";
            sphone.Text = "";

        }
    }
}
