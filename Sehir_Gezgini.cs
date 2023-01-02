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
   
    public partial class Sehir_Gezgini : Form
    {
        VeriTabani veri = new VeriTabani();
        

        MySqlDataReader dr;
        MySqlDataReader dr1;
        MySqlDataReader dr2;

        public Sehir_Gezgini()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void Sehir_Gezgini_Load(object sender, EventArgs e)
        {
            //Labellara veri tabanından gelen verileri çekiyoruz.
            veri.con.Open();
            MySqlCommand cmd= new MySqlCommand("select * from sehir where sehir_id=1");
            cmd.Connection = veri.con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr["yer"].ToString();
                label3.Text = dr["ozellik"].ToString();
            }
            dr.Close();
            MySqlCommand cmd1 = new MySqlCommand("select * from sehir where sehir_id=2");
            cmd1.Connection = veri.con;
            dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                label4.Text = dr1["yer"].ToString();
                label5.Text = dr1["ozellik"].ToString();
            }
            dr1.Close();
            MySqlCommand cmd2 = new MySqlCommand("select * from sehir where sehir_id=3");
            cmd2.Connection = veri.con;
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                label6.Text = dr2["yer"].ToString();
                label7.Text = dr2["ozellik"].ToString();
            }
            dr.Close();
            veri.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
