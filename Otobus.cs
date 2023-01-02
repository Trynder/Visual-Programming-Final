using MySql.Data.MySqlClient;
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
    public partial class Otobus : Form
    {
        VeriTabani veri = new VeriTabani();
        
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Otobus()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible= false;
        }

        private void Otobus_Load(object sender, EventArgs e)
        {
            //string a = label17.Text;
            //string b = label18.Text;
           // string c = label19.Text;
           button2.Visible= false;
            panel2.Visible= false;
            if (label24.Text=="1")
            {
                button2.Visible = true;
                
            }

                

            panel1.Visible = false;
            veri.con.Open();

            MySqlCommand co = new MySqlCommand("SELECT * FROM oto_saat", veri.con);
            MySqlDataReader dataReader = co.ExecuteReader();
            while (dataReader.Read())
            {
                string a = dataReader["saat1"].ToString();
                string b = dataReader["saat2"].ToString();
                string c = dataReader["saat3"].ToString();
                label17.Text= a;
                label18.Text= b;   
                label19.Text= c;
     

            }
            veri.con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                veri.con.Open();

                MySqlCommand co = new MySqlCommand();
                co.Connection = veri.con;
                co.CommandText = "update oto_saat set saat1='" + textBox1.Text + "', saat2='" + textBox2.Text + "', saat3='"+textBox3.Text+"'";
                dr = co.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show("Başarıyla güncellendi");
                }
                veri.con.Close();

            }
            else
            {
                MessageBox.Show("Lütfen boş kısımları doldurunuz", "", MessageBoxButtons.OK);
            }
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
