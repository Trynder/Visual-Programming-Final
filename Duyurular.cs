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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }

        private void Duyurular_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.balikesir.bel.tr/duyuru-liste");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
