using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interface.Models
{
    public interface IAracOzellikleri
    {
        string Marka { get; set; }
        string Model { get; set; }
        int Hiz { get; set; }
        double Fiyat { get; set; }
        void ToBilgiler();
    }
}
