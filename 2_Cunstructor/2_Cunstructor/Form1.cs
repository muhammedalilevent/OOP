using _2_Cunstructor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Cunstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba arb = new Araba("BMW","5.20",2.00M);
            MessageBox.Show(arb.ToString());

            Araba arb2 = new Araba("BMW", "5.20", 2.00M, "Sedan");
            MessageBox.Show(arb2.ToString());
        }
    }
}
