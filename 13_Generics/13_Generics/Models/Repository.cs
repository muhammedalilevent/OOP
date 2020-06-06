using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Generics.Models
{
    //Repository Class'ın bir (T = TYPE) tip alacak
    //1.Kullanım
    //public class Repository<T> -> her türlü tipi buraya gönderebiliriz.
    //2.Kullanım 
    //public class Repository<T> where T : class -> burada ise sadece class gönderebiliriz.
    public class Repository<T> where T : class
    {
        public static List<T> db = new List<T>();

        public bool Ekle(T item)
        {
            db.Add(item);
            return true;
        }

        public bool Ekle(int index, T item)
        {
            db.Insert(index, item);
            return true;
        }

        public bool Sil(T item)
        {
            db.Remove(item);
            return true;
        }
        public List<T> Listele()
        {
            return db.ToList();
        }
    }
}
