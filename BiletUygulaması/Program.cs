using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************   Bilet Satın Alma Uygulamasına HoşGeldiniz   *****************************");
            Console.WriteLine();
            Random rondomU = new Random();
            Random randomT= new Random();   
            int rondomUcakBiletSayı = rondomU.Next(0,120);
            int rondomTrenBiletSayı = randomT.Next(0, 100);
           
            UcakBilet ucakBilet = new UcakBilet("istanbul-Diyarbakır", rondomUcakBiletSayı, 1000,((120- rondomUcakBiletSayı) *1000),120);
            TrenBilet trenBilet = new TrenBilet("İstanbul-İzmir", rondomTrenBiletSayı, 800, ((100 - rondomTrenBiletSayı) * 800), 100);
            
            
            while (true)
            {
                Console.WriteLine("1-Uçak Yolculuğu İçin Bilet Alın\n" +
                              "2-Tren Yolculuğu İçin Bilet Alın\n" +
                              "3-Uçak Bilet İade İşlemleri\n" +
                              "4-Tren Bilet İade İşlemleri\n" +
                              "5-Çıkış Yapmak için 5 e basınız ");
                Console.WriteLine();
                Console.Write("Almak İstediğiniz Bilet Türünü Seçiniz : ");
                int BiletSeçimTür = int.Parse(Console.ReadLine());
                if (BiletSeçimTür == 1)
                {

                    ucakBilet.Biletİslemleri();
                    Console.ReadLine ();
                    Console.Clear();
                }
                else if (BiletSeçimTür == 2)
                {
                    trenBilet.Biletİslemleri();
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (BiletSeçimTür == 3)
                {
                    ucakBilet.Biletİadeİslemi();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (BiletSeçimTür == 4)
                {

                    trenBilet.Biletİadeİslemi();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (BiletSeçimTür == 5)
                {
                    Console.WriteLine("****************************  Hoşça Kalın  *****************************");
                    Console.ReadLine();
                    return;
                }

            }



        }
    }
}
