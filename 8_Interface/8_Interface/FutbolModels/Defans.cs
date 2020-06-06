using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Interface.FutbolModels
{
    public class Defans : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }

        private byte _SutGucu;

        public byte SutGucu
        {
            get { return _SutGucu; }
            set {
                try
                {
                    if (value < 60)
                    {
                        this._SutGucu = value;
                    }
                    else
                    {
                        throw new Exception("Defans Oyuncusunun şut gücü 60'tan büyük olamaz!...");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }


        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public bool MilliMi { get; set; }

        public void SutCek()
        {
            
        }
        public void TopKurtar()
        {
            throw new Exception("Ben Kaleci Değilim!...");
        }
        public override string ToString()
        {
            return this.AdiSoyadi;
        }
    }
}
