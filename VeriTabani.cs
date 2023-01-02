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
    internal class VeriTabani
    {
      public  MySqlConnection con = new MySqlConnection("Server=localhost;Database=belediye1;Uid=root;Pwd='05528493835'");
        MySqlCommand cmd;

        public void kayitol(string kadi,string sifre,string sifretekrar)
        {
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            if (kadi != "" && sifre != "")
            {
                if (sifre == sifretekrar)
                {
                    cmd.CommandText = "insert into login(tel_no , sifre) values (" + kadi + ",'" + sifre + "')";
                    cmd.ExecuteNonQuery();  
                    MessageBox.Show("Kayıt başarıyla yapıldı", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Şifreleriniz Uyuşmuyor!");
            }
            else
                MessageBox.Show("Hatalı Bilgiler");
            con.Close();
        }

        public void vefat_ekle(string a,string b,string c,string d)
        {

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;

            if (a != "" && b != "")
            {
                if (c == "")
                {
                    cmd.CommandText = "insert into vefat(isim , soyisim , tarih) values ('" + a + "' , '" + b + "' , '" + d + "')";
                    MessageBox.Show(d);
                }
                else
                {
                    cmd.CommandText = "insert into vefat(isim , soyisim , tarih) values ('" + a + "' , '" + b + "' , '" + c + "')";
                    MessageBox.Show("Vefat Başarıyla Eklendi", "Başsağlığı Dileriz", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("alanları doldurunuz (ölüm tarihini doldurmadığınız durumda bugünün tarihini otomatik alacaktır)");
            }

            //cmd.CommandText = "insert into vefat(isim , soyisim) values ('"+textBox1.Text + "' , '" + textBox2.Text +"')";
            cmd.ExecuteNonQuery();



            con.Close();
        }

        public string a, b, c, d;
        public void haber_cek()
        {

            con.Open();
            MySqlDataReader dataReader;
            MySqlDataReader rdr;
            MySqlCommand bur = new MySqlCommand("SELECT * FROM haberler WHERE haber_id=1", con);
            dataReader = bur.ExecuteReader();
            while (dataReader.Read())
            {
                a = dataReader["haber_baslik"].ToString();
                b = dataReader["haber_text"].ToString();


            }
            dataReader.Close();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM haberler WHERE haber_id=2",con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                c = rdr["haber_baslik"].ToString();
               d = rdr["haber_text"].ToString();
            }
            con.Close();
        }
       

    }
}
