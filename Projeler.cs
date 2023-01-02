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
    public partial class Projeler : Form
    {
        VeriTabani veri = new VeriTabani();
        public Projeler()
        {
            InitializeComponent();
        }

        private void Projeler_Load(object sender, EventArgs e)
        {
            veri.con.Open();
            MySqlCommand bur = new MySqlCommand("SELECT * FROM projeler WHERE proje_id=1", veri.con);
            MySqlDataReader dataReader = bur.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader["devameden"].ToString();
                label5.Text = dataReader["tamamlanmıs"].ToString();
                
            }
            dataReader.Close();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM projeler WHERE proje_id=2", veri.con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                label6.Text = rdr["devameden"].ToString();
                label7.Text = rdr["tamamlanmıs"].ToString();
            }
            veri.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
