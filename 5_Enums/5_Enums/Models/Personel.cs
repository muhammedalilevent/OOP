using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enums.Models
{
    public class Personel
    {
        private string _Adi;

        public string Adi
        {
            get { return _Adi; }
            set { _Adi = value; }
        }

        private Departmanlar _Departman;

        public Departmanlar Departman
        {
            get { return _Departman; }
            set { _Departman = value; }
        }

    }
}
