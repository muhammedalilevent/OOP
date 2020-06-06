using _6_Inheritance_Abstract.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Inheritance_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InsanKaynaklari ik = new InsanKaynaklari();
            ik.Calis();

            Muhasebe mhs = new Muhasebe();
            mhs.Calis();

            Pazarlama pzr = new Pazarlama();
            pzr.Calis();

            TeknikServis ts = new TeknikServis();
            ts.Calis();

            
        }
    }
}
