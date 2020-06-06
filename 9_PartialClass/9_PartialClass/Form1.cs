using _9_PartialClass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_PartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Adi = "Ayşe";
            p.SoyAdi = "İlhanlı";
            MessageBox.Show(p.AdGetir() + " " + p.SoyAdGetir());
        }
    }
}
