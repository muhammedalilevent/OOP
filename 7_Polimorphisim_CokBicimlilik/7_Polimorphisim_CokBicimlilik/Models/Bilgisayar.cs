using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorphisim_CokBicimlilik.Models
{
    public class Bilgisayar
    {
        public string Marka { get; set; }
        public string CPU { get; set; }
        public string Ram { get; set; }
        public string HDD { get; set; }

        public virtual string OzellikYazdir()
        {
           return $"Marka: {this.Marka},\nCPU: {this.CPU},\n Ram: {this.Ram},\nHDD: {this.HDD}";
        }
    }
}
