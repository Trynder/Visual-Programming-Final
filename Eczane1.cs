using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Belediye_BP1
{
    public partial class Eczane1 : Form
    {
        Ecz_yon pic = new Ecz_yon();
        public Eczane1()
        {
            InitializeComponent();
           
        }

        private void Eczane1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox2.Visible = true;
            pic.pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox3.Visible = true;
            pic.pictureBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox4.Visible = true;
            pic.pictureBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox5.Visible = true;
            pic.pictureBox4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox6.Visible = true;
            pic.pictureBox5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pic.Show();
            pic.pictureBox1.Visible = true;
            pic.pictureBox6.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}