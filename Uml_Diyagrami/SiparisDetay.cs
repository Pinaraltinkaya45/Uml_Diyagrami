using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    public class SiparisDetay
    {
        public Siparis siparisi {  get; set; }

        List<Urun> urunler { get; set; }
        public string VergiDurumu {  get; set; }
        public string Adres {  get; set; }

    }
}
