using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PartialClass.Models
{
    public partial class Personel
    {
        public string Adi { get; set; }
        public string AdGetir()
        {
            return this.Adi;
        }
    }
}
