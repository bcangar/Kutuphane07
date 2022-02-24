using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class Kitap
    {


        /*

        Kitap
        Id Guid (contructor'da otomaik değer atansın.)
        Ad string
        BasimTarihi DateTimee
        KitapTurEnum KitapTuru
        YazarAd string
        SayfaSayisi int
        Aciklama string


        */
        public Kitap (Guid Id)
        {
            Id =Guid.NewGuid();
        }


        public Guid Id { get; set; }

        public string Ad { get; set; }

        public DateTime BasimTarihi { get; set; }

        public KitapTurEnum KitapTuru { get; set; }

        public string YazarAd { get; set; }

        public int SayfaSayisi { get; set; }

        public string Aciklama { get; set; }

       

    }
}
