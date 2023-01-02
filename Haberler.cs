using MySql.Data.MySqlClient;
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
using MySql.Data;

namespace Belediye_BP1
{
    public partial class Haberler : Form
    {
        VeriTabani veri = new VeriTabani();
        public Haberler()
        {
            InitializeComponent();
        }

        private void Haberler_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            veri.haber_cek();
            label3.Text = veri.a;
            label4.Text= veri.b;
            label5.Text=veri.c;
            label6.Text=veri.d;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }
    }
}
