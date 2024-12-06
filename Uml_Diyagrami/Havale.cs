using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    public class Havale :Odeme
    {
        public string havaleAdi {  get; set; }
        public string havaleAciklama { get; set; }

        public bool Onaylandi()
        {
            return true;
        }


    }
}
