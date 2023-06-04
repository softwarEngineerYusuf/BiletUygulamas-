using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletUygulaması
{
    internal class UcakBilet :Bilet
    {

        public UcakBilet(string YolculukNereye, int KalanBiletSayısı, int BiletFiyat, int KasaToplamPara, int ToplamBiletSayısı)
        {
            this.BiletFiyat = BiletFiyat;
            this.KalanBiletSayısı = KalanBiletSayısı;
            this.YolculukNereye = YolculukNereye;
            this.KasaToplamPara = KasaToplamPara;
            this.ToplamBiletSayısı = ToplamBiletSayısı;

            

        }

          override public void Biletİslemleri()
          {
            Console.WriteLine();
            Console.WriteLine($"Uçak Bilet Fiyatları  {this.BiletFiyat} tl dir");
            Console.WriteLine($"Kalan Bilet Sayısı {this.KalanBiletSayısı} tanedir");
            Console.WriteLine($"Firmanın Toplam Uçak Biletinden Kazandığı Para : {KasaToplamPara} ");
            Console.WriteLine();
            Console.WriteLine("Eğer 5 den Fazla Bilet Alırsanız 1 Biletiniz Ücretsiz Olacaktır");
            Console.Write("Almak istediğiniz Bilet Sayısı giriniz :");
            int UcakBiletSayı = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (UcakBiletSayı > this.KalanBiletSayısı)
            {
                Console.WriteLine("Yeterli Bilet Bulunmamaktadır...");
            }
            
            
            else
            {
                if (UcakBiletSayı > 5)
                {
                    Console.WriteLine("1 Biletiniz Ücretsiz Olacaktır");
                    Console.WriteLine($"Normalde Ödemeniz Gereken Tutar  : {UcakBiletSayı*1000} tl dir");
                    Console.WriteLine($"İndirimli Fiyat : {(UcakBiletSayı-1) * 1000} tl dir");
                    Console.WriteLine("Ödemeyi Onaylıyormusunuz ? E\tH");
                    string biletFiyatOnay = Console.ReadLine().ToUpper();
                    if (biletFiyatOnay == "E")
                    {
                        Console.WriteLine("İşleminiz Gerçekleşiyor...");
                        int YeniBiletSayısı = this.KalanBiletSayısı - UcakBiletSayı;
                        this.KalanBiletSayısı = YeniBiletSayısı;

                        this.KasaToplamPara = this.KasaToplamPara + ((UcakBiletSayı-1) * 1000);
                        Console.WriteLine($"Kalan Bilet Sayısı {YeniBiletSayısı} tanedir ");
                        Console.WriteLine($"Firmanın Uçak Biletinden Kazandığı Toplam Para : {KasaToplamPara}");
                        Console.WriteLine();

                        Console.WriteLine($"************************BİLET BİLGİLERİ ********************************** \n" +
                            $"Bilet Adediniz : {UcakBiletSayı}\n" +
                            $"Güzergahınız : {this.YolculukNereye}\n" +
                            $"Seyahat Saati : 09.00 - 11.00 Arasında Gerçekleşecektir.\n" +
                            $"Toplam Bilet Fiyatınız : {this.BiletFiyat * (UcakBiletSayı-1)}\n" +
                            $"*******************İyi Yolculuklar Dileriz ***************************");
                    }

                    else
                    {
                        Console.WriteLine("Bilet Alım Safasına Yönlendiriliyorsunuz...");
                        Console.WriteLine();
                    }
                   

                }

                else
                {
                    Console.WriteLine($"Ödemeniz Gereken Tutar {this.BiletFiyat * UcakBiletSayı}");
                    Console.WriteLine("Ödemeyi Onaylıyormusunuz ? E\tH");
                    string biletFiyatOnay1 = Console.ReadLine().ToUpper();
                    if (biletFiyatOnay1 == "E")
                    {
                        Console.WriteLine("İşleminiz Gerçekleşiyor...");
                        int YeniBiletSayısı = this.KalanBiletSayısı - UcakBiletSayı;
                        this.KalanBiletSayısı = YeniBiletSayısı;

                        this.KasaToplamPara = this.KasaToplamPara + (UcakBiletSayı * 1000);
                        Console.WriteLine($"Kalan Bilet Sayısı {YeniBiletSayısı} tanedir ");
                        Console.WriteLine($"Firmanın Uçak Biletinden Kazandığı Toplam Para : {KasaToplamPara}");
                        Console.WriteLine();

                        Console.WriteLine($"************************BİLET BİLGİLERİ ********************************** \n" +
                            $"Bilet Adediniz : {UcakBiletSayı}\n" +
                            $"Güzergahınız : {this.YolculukNereye}\n" +
                            $"Seyahat Saati : 09.00 - 11.00 Arasında Gerçekleşecektir.\n" +
                            $"Toplam Bilet Fiyatınız : {this.BiletFiyat * UcakBiletSayı}\n" +
                            $"*******************İyi Yolculuklar Dileriz ***************************");
                    }

                    else
                    {
                        Console.WriteLine("Bilet Alım Safasına Yönlendiriliyorsunuz...");
                        Console.WriteLine();
                    }
                }
               
            }

        }

       override public void Biletİadeİslemi()
        {
            Console.WriteLine("İade Etmek İstediğiniz Bilet Sayısını Giriniz : ");
            int iadeBiletSayısı =int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("İşleminiz Başarıyla Gerçekleşiyor....");
            Console.WriteLine();
            Console.WriteLine("İade işlemi Tamamlandı");
            Console.WriteLine($"Hesabınıza {iadeBiletSayısı*this.BiletFiyat} tl yatırıldı.");
            this.KalanBiletSayısı = this.KalanBiletSayısı + iadeBiletSayısı;
            this.KasaToplamPara = this.KasaToplamPara - (iadeBiletSayısı * 1000);
            Console.WriteLine($"Kalan Bilet Sayısı : {KalanBiletSayısı}");
            Console.WriteLine($"Firmanın Uçak Biletinden Kazandığı para : {KasaToplamPara}");
            Console.WriteLine();
            Console.WriteLine("***************** Yine Bekleriz ***********************");





        }

    }
}
