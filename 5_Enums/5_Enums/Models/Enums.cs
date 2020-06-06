using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enums.Models
{
    /*
     * ENUM 
     * Kişilere sabit sseçenekler sunmak için kullanılan değer tipleridir. Seçenekleri kontrol altında tutup, uygulamanızda kendi kontrolünüz çerçevesinde yönetebilirsiniz. Böylelikle daha performanslı ve güvenli bir yapı kurabilirsiniz.
     * 
     * Enumlar sadece ve sadece gelişrtiriciye yöneliktir.
     * 
     * Bir Enum'un yazılı değerini teslim alabilmek için kullanılan metot, Enum.GetNames() metodudur.
     */
    public enum Departmanlar {
        Yazılım = 1,
        Sistem = 2,
        Muhasebe = 3,
        IK = 4,
        Pazarlama = 5,
        Üretim = 6
    }
    public enum Messagetype {
        Saved = 1,
        Updated = 2,
        Deleted = 3,
        Found = 4,
        NotSaved = 5,
        NotUpdated = 6,
        NotDeleted = 7,
        NotFound = 8,
        Validation = 9,
        Exception = 10
    }
}
