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
    public partial class Baskan : Form
    {
        VeriTabani veri = new VeriTabani();
        
        public Baskan()
        {
            InitializeComponent();
        }

        private void Baskan_Load(object sender, EventArgs e)
        {
            groupBox1.Visible=false;
            veri.con.Open();
            MySqlCommand bur = new MySqlCommand("SELECT * FROM baskan", veri.con);
            MySqlDataReader dataReader = bur.ExecuteReader();
            while (dataReader.Read())
            {
                label2.Text = dataReader["baskan_ad"].ToString();
                label3.Text = dataReader["baskan_soyad"].ToString();
                label4.Text = dataReader["baskan_bilgiler"].ToString();
            }
            veri.con.Close();

            if (label9.Text=="1")
            {
                groupBox1.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri.con.Open();
            MySqlCommand gun = new MySqlCommand("update baskan set baskan_ad='" + textBox1.Text + "',baskan_soyad='" + textBox2.Text + "',baskan_bilgiler='" +textBox3.Text + "'",veri.con);
            gun.ExecuteNonQuery();
            veri.con.Close();
            veri.con.Open();
            MySqlCommand co = new MySqlCommand("SELECT * FROM baskan", veri.con);
            MySqlDataReader dataReader = co.ExecuteReader();
            while (dataReader.Read())
            {
                label2.Text = dataReader["baskan_ad"].ToString();
                label3.Text = dataReader["baskan_soyad"].ToString();
                label4.Text = dataReader["baskan_bilgiler"].ToString();
            }
            veri.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
