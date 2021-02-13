using System;

namespace Methodlar
{   // Methodlar - Doğru uygulama Teknikleri - Temiz Kod Yazma Teknikleri
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun() ;
            urun1.fiyat = 7.5 ;
            urun1.Urunadı = "Elma";
            urun1.Id = 1 ;
            urun1.Aciklama = " Amasya Elması" ;

            Urun urun2 = new Urun();
            urun2.Urunadı = "Çilek";
            urun2.Id = 2;
            urun2.fiyat = 9;
            urun2.Aciklama = "Dağ Çileği";

            Urun urun3 = new Urun();
            urun3.Urunadı = "Muz";
            urun3.Id = 3;
            urun3.fiyat = 8;
            urun3.Adet = 20 ;
            urun3.Aciklama = "Yerli Muz";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun ListeUrunu in urunler)
            {
                Console.WriteLine(ListeUrunu.Urunadı);
                Console.WriteLine(ListeUrunu.Id);
                Console.WriteLine(ListeUrunu.fiyat);
                Console.WriteLine(ListeUrunu.Aciklama);
                Console.WriteLine(ListeUrunu.Adet);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("------------------METODLAR-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("elma", 3 , 11);
        }
    }
}
