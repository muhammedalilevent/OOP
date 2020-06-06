using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Generics.Models
{
    public class Ogrenci : Repository<Ogrenci>
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
