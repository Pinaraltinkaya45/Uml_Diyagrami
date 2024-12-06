using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    public class Siparis
    {
        public DateTime Tarih{get; set;}
        public string Durum { get; set;}
        List<Odeme> OdemeList { get; set;}
        public Musteri Musteri { get; set;}
        public Siparis(Musteri m)
        {
            this.Musteri = m;
        }
        List<SiparisDetay> SiparisDetaylari { get; set;}
        public int ToplamFiyat()
        {
            return 1000;
        }

        public int Vergi()
        { 
            return 500;
        }

    }
}
