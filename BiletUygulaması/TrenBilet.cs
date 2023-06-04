using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletUygulaması
{
    internal class TrenBilet:Bilet
    {
        public TrenBilet(string YolculukNereye, int KalanBiletSayısı, int BiletFiyat, int KasaToplamPara, int ToplamBiletSayısı)
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
            Console.WriteLine($"Tren Bilet Fiyatları  {this.BiletFiyat} tl dir");
            Console.WriteLine($"Kalan Bilet Sayısı {this.KalanBiletSayısı} tane dir");
            Console.WriteLine($"Firmanın Toplam Tren Biletinden Kazandığı Para : {KasaToplamPara} ");
            Console.WriteLine();
            Console.WriteLine("Eğer 4 den Fazla Bilet Alırsanız 1 Biletiniz Ücretsiz Olacaktır");
            Console.Write("Almak istediğiniz Bilet Sayısı giriniz :");
            int TrenBiletSayı = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (TrenBiletSayı > this.KalanBiletSayısı)
            {
                Console.WriteLine("Yeterli Bilet Bulunmamaktadır...");
            }


            else
            {
                if (TrenBiletSayı > 4)
                {
                    Console.WriteLine("1 Biletiniz Ücretsiz Olacaktır");
                    Console.WriteLine($"Normalde Ödemeniz Gereken Tutar  : {TrenBiletSayı * 800} tl dir");
                    Console.WriteLine($"İndirimli Fiyat : {(TrenBiletSayı - 1) * 800} tl dir");
                    Console.WriteLine("Ödemeyi Onaylıyormusunuz ? E\tH");
                    string biletFiyatOnay = Console.ReadLine().ToUpper();
                    if (biletFiyatOnay == "E")
                    {
                        Console.WriteLine("İşleminiz Gerçekleşiyor...");
                        int YeniBiletSayısı = this.KalanBiletSayısı - TrenBiletSayı;
                        this.KalanBiletSayısı = YeniBiletSayısı;

                        this.KasaToplamPara = this.KasaToplamPara + ((TrenBiletSayı - 1) * 800);
                        Console.WriteLine($"Kalan Bilet Sayısı {YeniBiletSayısı} tanedir ");
                        Console.WriteLine($"Firmanın Tren Biletinden Kazandığı Toplam Para : {KasaToplamPara}");
                        Console.WriteLine();

                        Console.WriteLine($"************************BİLET BİLGİLERİ ********************************** \n" +
                            $"Bilet Adediniz : {TrenBiletSayı}\n" +
                            $"Güzergahınız : {this.YolculukNereye}\n" +
                            $"Seyahat Saati : 09.00 - 11.00 Arasında Gerçekleşecektir.\n" +
                            $"Toplam Bilet Fiyatınız : {this.BiletFiyat * (TrenBiletSayı - 1)}\n" +
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
                    Console.WriteLine($"Ödemeniz Gereken Tutar {this.BiletFiyat * TrenBiletSayı}");
                    Console.WriteLine("Ödemeyi Onaylıyormusunuz ? E\tH");
                    string biletFiyatOnay1 = Console.ReadLine().ToUpper();
                    if (biletFiyatOnay1 == "E")
                    {
                        Console.WriteLine("İşleminiz Gerçekleşiyor...");
                        int YeniBiletSayısı = this.KalanBiletSayısı - TrenBiletSayı;
                        this.KalanBiletSayısı = YeniBiletSayısı;

                        this.KasaToplamPara = this.KasaToplamPara + (TrenBiletSayı * 800);
                        Console.WriteLine($"Kalan Bilet Sayısı {YeniBiletSayısı} tanedir ");
                        Console.WriteLine($"Firmanın Tren Biletinden Kazandığı Toplam Para : {KasaToplamPara}");
                        Console.WriteLine();

                        Console.WriteLine($"************************BİLET BİLGİLERİ ********************************** \n" +
                            $"Bilet Adediniz : {TrenBiletSayı}\n" +
                            $" Güzergahınız : {this.YolculukNereye}\n" +
                            $"Seyahat Saati : 09.00 - 11.00 Arasında Gerçekleşecektir.\n" +
                            $"Toplam Bilet Fiyatınız : {this.BiletFiyat * TrenBiletSayı}\n" +
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
            int iadeBiletSayısı = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("İşleminiz Başarıyla Gerçekleşiyor....");
            Console.WriteLine();
            Console.WriteLine("İade işlemi Tamamlandı");
            Console.WriteLine($"Hesabınıza {iadeBiletSayısı * this.BiletFiyat} tl yatırıldı.");
            this.KalanBiletSayısı = this.KalanBiletSayısı + iadeBiletSayısı;
            this.KasaToplamPara = this.KasaToplamPara - (iadeBiletSayısı * 1000);
            Console.WriteLine($"Kalan Bilet Sayısı : {KalanBiletSayısı}");
            Console.WriteLine($"Firmanın Tren Biletinden Kazandığı para : {KasaToplamPara}");
            Console.WriteLine();
            Console.WriteLine("***************** Yine Bekleriz ***********************");
        }



    }
}
