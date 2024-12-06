using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diyagrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun u = new Urun();

            SiparisDetay sd1 = new SiparisDetay()
            {
                Adres = "sd1"
            };

            SiparisDetay sd2 = new SiparisDetay()
            {
                Adres = "sd2"
            };


            List<SiparisDetay> listeSd = new List<SiparisDetay>();
            listeSd.Add(sd1);
            listeSd.Add(sd2);
            u.SiparisDetaylari = listeSd;

            Console.WriteLine($"sd1: {u.SiparisDetaylari[0].Adres}");
            Console.WriteLine($"sd2: {u.SiparisDetaylari[1].Adres}");
            Console.WriteLine($"X: {u.X.Aciklama}");

            u = null;

        }
    }
}
