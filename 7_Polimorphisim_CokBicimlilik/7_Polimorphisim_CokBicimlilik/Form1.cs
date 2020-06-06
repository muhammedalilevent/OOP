using _7_Polimorphisim_CokBicimlilik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Polimorphisim_CokBicimlilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bilgisayar pc = new Bilgisayar();
            //pc.Marka = "Toshiba";
            //pc.CPU = "I7";
            //pc.Ram = "8GB";
            //pc.HDD = "256GB";
            //MessageBox.Show(pc.OzellikYazdir());

            //Notebook nt = new Notebook();
            //nt.Marka = "Apple";
            //nt.CPU = "I7";
            //nt.Ram = "8GB";
            //nt.HDD = "256GB";
            //nt.Wifi = true;
            //MessageBox.Show(nt.OzellikYazdir());

            Bilgisayar bb = new Notebook();
            bb.Marka = "Casper";
            bb.CPU = "Intel I7";
            bb.Ram = "32 GB DDR5";
            bb.HDD = "1TB";
            Notebook ntt = (Notebook)bb;
            ntt.Wifi = true;
            MessageBox.Show(ntt.OzellikYazdir());


        }
    }
}
