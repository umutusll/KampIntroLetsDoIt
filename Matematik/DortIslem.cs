using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem //dort işlemi metot haline getiricez  mesela matematik öğreten bi web projesi yaptık 
                    //10 sayfanın 5 inde bu sayfayı kullanacagız bu yüzden sürekli her sayfaya dört işlemi ayrı ayrı yapmak yerine 
                    //bi kere yazarız metot haline getiririz o kodu yazarız 
    {
        public void Topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
