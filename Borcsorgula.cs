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
    public partial class Borcsorgula : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dataReader;


        public Borcsorgula()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=belediye1;Uid=root;Pwd='05528493835'");
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select su_borc,elektrik_borc,dgz_borc from borc where tel_no="+textBox1.Text+"", con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listBox1.Items.Add(dataReader["su_borc"].ToString());
                listBox2.Items.Add(dataReader["elektrik_borc"].ToString());
                listBox3.Items.Add(dataReader["dgz_borc"].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
