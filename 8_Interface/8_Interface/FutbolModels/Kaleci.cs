using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interface.FutbolModels
{
    public class Kaleci : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public bool MilliMi { get; set; }

        public void SutCek()
        {
            throw new Exception("Ben Şut Çekmem!...");
        }
        public void TopKurtar()
        {

        }
        public override string ToString()
        {
            return this.AdiSoyadi;
        }
    }
}
