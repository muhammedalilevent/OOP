using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ReferanceType_ValueType.Model
{
    public class Ogrenci
    {
        private string _Adi;

        public string Adi
        {
            get { return _Adi; }
            set { _Adi = value; }
        }

        private string _SoyAdi;

        public string SoyAdi
        {
            get { return _SoyAdi; }
            set { _SoyAdi = value; }
        }

    }
}
