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
    public partial class İletisim : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataReader dataReader;
        public İletisim()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=belediye1;Uid=root;Pwd='05528493835'");
        }

        private void İletisim_Load(object sender, EventArgs e)
        {
            if (label6.Text=="0")
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
            con.Open();

            MySqlCommand co = new MySqlCommand("SELECT * FROM iletisim", con);
            MySqlDataReader dataReader = co.ExecuteReader();

            while (dataReader.Read())
            {
                label4.Text = dataReader["gsm"].ToString();
                label5.Text = dataReader["adres"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           
            MySqlCommand co = new MySqlCommand();
            co.Connection = con;
            co.CommandText = "update iletisim set gsm='" + textBox1.Text + "', adres='" + textBox2.Text + "'";
            dataReader = co.ExecuteReader();
            while (dataReader.Read())
            {
                MessageBox.Show("Başarıyla güncellendi");
            }
            con.Close();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
