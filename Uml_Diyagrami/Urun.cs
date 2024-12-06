using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    public class Urun
    {
        public string UrunAdi{get;set;}
        public string Aciklama { get;set;}
        public int Stok { get;set;}

        List<SiparisDetay> siparisDetay {  get;set;}

        public X x {get;set;}

        public Urun()
        {
            X x = new X();
            x.adi = "asdas";
            x.Aciklama = "deneme";
            this.x = x;
        }
        public double FiyatiHesapla(int adet)
        {
            return adet;
        }

        public bool StokDurumu()
        {
            return true;
        }


    }
}
