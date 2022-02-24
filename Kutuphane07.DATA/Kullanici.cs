using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class Kullanici
    {

        /*
        Id Guid (contructor'da otomaik değer atansın.)
        AdSoyad string
        KullaniciAdi string
        Parola string
        List< Kitap > OduncAlinanKitaplar

        */


        public Kullanici(Guid Id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string AdSoyad { get; set; }

        public string KullaniciAdi { get; set; }

        public string Parola { get; set; }

        public List<Kitap> OduncAlinanKitaplar { get; set; }


    }
}
