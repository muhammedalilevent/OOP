using _1_ClassObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_ClassObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba arb = new Araba();
            arb.Marka = "Merco";
            arb.Model = "E250";
            arb.Motor = 2.00M;
            MessageBox.Show(arb.ToString());
        }
    }
}
