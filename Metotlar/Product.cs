using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product  //engin demirog ürünler diye oluşturdu bu klasoru
    {
        //property - özellik
        public int Id { get; set; }   // bir datayı diğerlerindeen ayırt etmek için kullanılan eşsiz değer tc no örnek 
        public string Adi { get; set; }
        public double Fiyati { get; set; } // clasın sonunda manager service dal date access gibi ifadeler görürsek bunlar bir 
        //operasyon tutuyordur 
        public string Aciklama { get; set; } 


    }
}
