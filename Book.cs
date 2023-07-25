using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;



namespace Librarysystem
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L6DGNCK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void populate()
        {
            con.Open();
            string query = "select * from BookTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookData.DataSource = ds.Tables[0];

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Bname.Text == "" || Bautor.Text == "" || Bpublisher.Text == "" || Bprice.Text == "" || Bnumber.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BookTable VALUES ('" + Bname.Text + "','" + Bautor.Text + "','" + Bpublisher.Text + "'," + Bprice.Text + ", "+ Bnumber.Text +")", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successufly!!");
                con.Close();
               populate();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Bname.Text == "" || Bautor.Text == "" || Bpublisher.Text == "" || Bprice.Text == "" || Bnumber.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string quary = "Update  BookTable set  BookAuthor = '" + Bautor.Text + "', publisher = '" + Bpublisher.Text + "', prise = '"+Bprice.Text+"',qty = '"+Bnumber.Text+"' where bookname = '" + Bname.Text + "';";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Data updated successufly!!");
                con.Close();
                populate();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bname.Text == "")
            {
                MessageBox.Show("Enter the  Book name");
            }
            else
            {
                con.Open();
                //string quary = ''"delete from BookTable where bookname = '" + Bname.Text + ";";
                //SqlCommand cmd = new SqlCommand(quary, con);
               // cmd.ExecuteNonQuery();
                MessageBox.Show("Book Deleted successufly!!");
                con.Close();
                populate();
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void BookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Bname.Text = "";
            Bautor.Text = "";
            Bpublisher.Text = "";
            Bprice.Text = "";
            Bnumber.Text = "";
        }
    }
}
