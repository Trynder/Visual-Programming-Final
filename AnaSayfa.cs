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
using Google.Protobuf.WellKnownTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Belediye_BP1
{
    public partial class AnaSayfa : Form
    {
        VeriTabani veri = new VeriTabani();
        MySqlCommand cmd;
        MySqlDataReader dr;

        Vefatlar veft = new Vefatlar();
        Borcsorgula borc = new Borcsorgula();
        Projeler projeler= new Projeler();
        Otobus oto = new Otobus();
        Eczane1 ecz = new Eczane1();
        Hava_Durumu hava = new Hava_Durumu();
        Duyurular duyu = new Duyurular();
        Baskan bskn = new Baskan();
        İletisim iletisim = new İletisim();
        Haberler haber = new Haberler();
        Sehir_Gezgini gez = new Sehir_Gezgini();

        public AnaSayfa()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ecz.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veft.label10.Text = label7.Text;
            veft.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            borc.ShowDialog();
            borc.label2.Text= label9.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            projeler.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            oto.label24.Text = label7.Text;
            oto.ShowDialog();
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            veri.con.Open();
            MySqlCommand co = new MySqlCommand("select * from login where tel_no='" + label9.Text + "'", veri.con);
            MySqlDataReader dataReader = co.ExecuteReader();
            while (dataReader.Read())
            {

                label7.Text = dataReader["yetki"].ToString();
            }
            veri.con.Close();
            veri.con.Open();

            MySqlCommand ekrn = new MySqlCommand("select * from anaekran", veri.con);
            MySqlDataReader drd = ekrn.ExecuteReader();
            while (drd.Read())
            {
                label10.Text = drd["asfalt"].ToString();
                label11.Text = drd["alan"].ToString();
                label12.Text = drd["proje"].ToString();
                
            }
            veri.con.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            hava.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            duyu.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bskn.label9.Text = label7.Text;
            bskn.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            iletisim.label6.Text = label7.Text;
            iletisim.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            haber.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gez.ShowDialog();
        }
    }
}
