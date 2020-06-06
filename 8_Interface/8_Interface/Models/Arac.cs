using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interface.Models
{
    public class Arac : IAracOzellikleri
    {
        public Arac(string marka,string model)
        {
            this.Marka = marka;
            this.Model = model;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Hiz { get; set; }
        public double Fiyat { get; set; }
        public void ToBilgiler()
        {
            System.Windows.Forms.MessageBox.Show($"Marka:{this.Marka},\nModel:{this.Model}");
        }

    }
}
