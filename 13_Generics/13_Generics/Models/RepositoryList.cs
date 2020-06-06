using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Generics.Models
{
    public class RepositoryList<O, S> where O : Ogrenci where S : Sinif
    {
        public static List<O> ogrenciList = new List<O>();
        public S sinif { get; set; }

        public bool Ekle(O ogrenci)
        {
            ogrenciList.Add(ogrenci);
            return true;
        }

        public Dictionary<S, List<O>> Listele()
        {
            Dictionary<S, List<O>> list = new Dictionary<S, List<O>>();
            list.Add(sinif, ogrenciList);
            return list;
        }
    }
}
