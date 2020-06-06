using _3_StaticSiniflar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_StaticSiniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal yerCekim = Matematik.YercekimiKuvveti;
            double pi = Matematik.PI;
            int kaldirma = Matematik.KaldirmaKuvveti;
            int sonuc = Matematik.Hesapla(10, 20);

        }
    }
}
