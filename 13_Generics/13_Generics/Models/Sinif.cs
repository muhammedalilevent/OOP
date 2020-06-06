using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Generics.Models
{
    public class Sinif : Repository<Sinif>
    {
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public string Egitmen { get; set; }
        public string SinifNo { get; set; }

    }
}
