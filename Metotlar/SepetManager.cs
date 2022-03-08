using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)  //hangi ürünü sepete ekleyeceğiz  sadece ekle yazmanın bir anlamı yok 
            //biz ürün ekleyeceğimiz için parametremiz ürün oldu 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }


        public void Ekle2(string urunAdi , string aciklama , double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
