using _11_Events.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Araba arac = new Araba(50, "Mercedes");
            arac.HizAsimi += new HizAsimiEventHandler(HizLimit);

            for (int i = 0; i < 10; i++)
            {
                arac.Hiz += 10;
                listBox1.Items.Add("Arabanın Şuan ki Hızı: " + arac.Hiz);
            }
        }


        public void HizLimit()
        {
            listBox1.Items.Add("Araç Hız Limitini Aştı");
        }
    }
}
