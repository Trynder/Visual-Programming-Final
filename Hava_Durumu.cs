using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Belediye_BP1
{
    public partial class Hava_Durumu : Form
    {
        public Hava_Durumu()
        {
           
            //Api Aktifleşecek
            InitializeComponent();
           
        }

        private void Hava_Durumu_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();

            //string api = "6f4491d559f902b3ae10d2aae25e1501";
            //string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            //XDocument weather = XDocument.Load(connection);
            //var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //var havadurum = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;

            string api = "223a06e07cb68aa19c9689e30362abe7";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var havadurum = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            label5.Text = temp.ToString();
            label6.Text = havadurum.ToString();
            label8.Text = "m/s" + ruzgar.ToString();
            label10.Text = nem.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }

