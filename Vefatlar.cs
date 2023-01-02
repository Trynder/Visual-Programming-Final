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
    
    public partial class Vefatlar : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        VeriTabani veri = new VeriTabani(); 

        public Vefatlar()
        {
            InitializeComponent();
        }

        private void Vefatlar_Load(object sender, EventArgs e)
        {
          
            veri.con.Open();

            MySqlCommand co = new MySqlCommand("SELECT * FROM vefat", veri.con);
            MySqlDataReader dataReader = co.ExecuteReader();

            while (dataReader.Read())
            {
                string ad =  dataReader["isim"].ToString();
                string sad = dataReader["soyisim"].ToString();
                string date = dataReader["tarih"].ToString();
                listBox1.Items.Add(ad+"     -       "+sad+"      -     "+date);
            }
            if (label10.Text == "1")
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
            veri.con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string starih = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            veri.vefat_ekle(textBox1.Text,textBox2.Text,textBox3.Text,starih);
           // cmd = new MySqlCommand();
           // veri.con.Open();
           // cmd.Connection = veri.con;

           // if (textBox1.Text != "" && textBox2.Text != "")
           // {
           //     if (textBox3.Text == "")
           //     {
           //         cmd.CommandText = "insert into vefat(isim , soyisim , tarih) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + starih + "')";
           //         MessageBox.Show(starih);
           //     }
           //     else
           //     {
           //         cmd.CommandText = "insert into vefat(isim , soyisim , tarih) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "')";
           //         MessageBox.Show("Vefat Başarıyla Eklendi","Başsağlığı Dileriz",MessageBoxButtons.OK);
           //     }
           // }
           // else
           // {
           //     MessageBox.Show("alanları doldurunuz (ölüm tarihini doldurmadığınız durumda bugünün tarihini otomatik alacaktır)");
           // }

           // //cmd.CommandText = "insert into vefat(isim , soyisim) values ('"+textBox1.Text + "' , '" + textBox2.Text +"')";
           // cmd.ExecuteNonQuery();



           //veri.con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

 
    }
}
