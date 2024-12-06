using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    internal interface IKart
    {
        string SahibininAdi { get; set; }
        DateTime Gecerlilik { get; set; }

        bool Onaylandi { get; set; }
    }
}
