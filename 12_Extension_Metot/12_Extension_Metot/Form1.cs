using _12_Extension_Metot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Extension_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime yarin = DateTime.Now.Tomorrow();
            string sifre = "123".ToMD5();
            string gelenSayi = (123).ToS();
            decimal gelenTutar = (123.456789).ToMoney();
            int sayi = "123".ToInt();


        }
    }
}
