using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Events.Models
{
    public delegate void HizAsimiEventHandler();
    public class Araba
    {
        public Araba(int hiz, string model)
        {
            this.Hiz = hiz;
            this.Model = model;
        }

        public event HizAsimiEventHandler HizAsimi;

        private int _Hiz;

        public int Hiz
        {
            get { return _Hiz; }
            set
            {
                _Hiz = value;
                if (value > 120)
                {
                    HizAsimi();
                }
            }
        }
        public string Model { get; set; }

    }
}
