using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    public class KrediKarti : Odeme,IKart
    {
        public string SahibininAdi { get; set; }
        public DateTime Gecerlilik { get; set; }

        public bool Onaylandi { get; set; }

        public bool Taksitlendir(int TakSay)
        {
            return true;
        }


    }
}
