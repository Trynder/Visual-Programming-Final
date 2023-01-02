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
    public partial class Form1 : Form
    {

        //public MySqlConnection con = new MySqlConnection("Server=localhost;Database=belediye;Uid=root;Pwd='';");
        VeriTabani veri = new VeriTabani(); 
        MySqlCommand cmd;
        MySqlDataReader dr;
        AnaSayfa ana = new AnaSayfa();



        public Form1()
        {
        InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
           // MySqlConnection con = new MySqlConnection("Server=localhost;Database=belediye;Uid=root;Pwd='';");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new MySqlCommand();
            veri.con.Open();
            cmd.Connection = veri.con;
            cmd.CommandText = "SELECT * FROM login where tel_no='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                MessageBox.Show("Giriş Başarılı!","Giriş Yapıldı",MessageBoxButtons.OK);



                ana.label9.Text = textBox1.Text;

                ana.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            veri.con.Close();

            //MySqlCommand gun = new MySqlCommand("", con);
            // gun.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            button2.Visible=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible =false;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cmd = new MySqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //if (textBox3.Text != "" && textBox4.Text != "")
            //{
            //    if (textBox4.Text == textBox5.Text)
            //    {
            //        cmd.CommandText = "insert into login(tel_no , sifre) values (" + textBox3.Text + ",'" + textBox4.Text + "')";
            //        cmd.ExecuteNonQuery();
            //        panel1.Visible = false;
            //        MessageBox.Show("Kayıt başarıyla yapıldı","",MessageBoxButtons.OK);
            //    }
            //    else
            //        MessageBox.Show("Şifreleriniz Uyuşmuyor!");
            //}
            //else
            //    MessageBox.Show("Hatalı Bilgiler");
            //con.Close();
            veri.kayitol(textBox3.Text,textBox4.Text,textBox5.Text);
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
