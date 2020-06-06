using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorphisim_CokBicimlilik.Models
{
    public class Notebook : Bilgisayar
    {
        public bool Wifi { get; set; }

        public override string OzellikYazdir()
        {
            return $"Marka: {base.Marka},\nCPU: {base.CPU},\n Ram: {base.Ram},\nHDD: {base.HDD},\nWifi: {this.Wifi}";
        }
    }
}
