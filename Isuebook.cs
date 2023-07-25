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
    public partial class Isuebook : Form
    {
        private void fillstudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Stid from studentTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Stid", typeof(int));
            dt.Load(rdr);
            stcb.ValueMember = "Stid";
            stcb.DataSource = dt;
            con.Close();
        }
        private void fillbook()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select bookname from BookTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("bookname", typeof(string));
            dt.Load(rdr);
            Bookisu.ValueMember = "bookname";
            Bookisu.DataSource = dt;
            con.Close();
        }
        private void fechstudent()
        {
            con.Open();
            string query = "select * from studentTable where Stid = " + stcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(); // Initialize the SqlDataAdapter
            da.SelectCommand = cmd; // Assign the SqlCommand to the SelectCommand property
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nameisu.Text = dr["stname"].ToString();
                departmentisu.Text = dr["department"].ToString();
                phoneisu.Text = dr["stphone"].ToString();
            }
            con.Close();
        }
        public void populate()
        {
            con.Open();
            string query = "select * from BookissuTable ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            isuubook.DataSource  = ds.Tables[0];
            con.Close();
        }
        public Isuebook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L6DGNCK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        
        /*private void studentdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentTable where");
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if ( nameisu.Text == "" || numberisu.Text == "" || departmentisu.Text == "" || phoneisu.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string Issudate = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BookissuTable VALUES (" + stcb.SelectedValue.ToString() + "," + numberisu.Text + ",'" + nameisu.Text + "','" + departmentisu.Text + "','" + phoneisu.Text + "','" + Bookisu.SelectedValue.ToString() + "','" + dateTimePicker1.Text+ "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successufly Issued!!");
                con.Close();
                populate();
            }
        }


        private void Isuebook_Load(object sender, EventArgs e)
        {
            fillstudent();
            fillbook();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void stcb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void stcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fechstudent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
