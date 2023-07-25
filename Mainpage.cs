using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarysystem
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book bk = new Book();
            bk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Isuebook ib = new Isuebook();
            ib.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibririanForm lf = new LibririanForm();
            lf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
