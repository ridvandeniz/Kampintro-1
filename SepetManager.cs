using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(urun.Urunadı + "'yi Sipariş Verdiniz" );
           }
 
        public void Ekle2(string urunAdi, double urunFiyat, int urunAdet)
        {
            Console.WriteLine("sepete Eklendi:" + urunAdi);
        }
    }
}
