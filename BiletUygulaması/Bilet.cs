using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletUygulaması
{
    internal class Bilet
    {
        public string YolculukNereye { get; set; }
        public int KalanBiletSayısı { get; set; }
        public int BiletFiyat { get; set; }

        public int KasaToplamPara { get; set; }

        public int ToplamBiletSayısı { get; set; }

        virtual public void Biletİslemleri()
        {
            Console.WriteLine(" Bilet Alım İşlemleri");
        }

        virtual public void Biletİadeİslemi()
        {
            Console.WriteLine("Bilet İade İşlemleri");
        }

    }
}
