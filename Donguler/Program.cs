using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç için temel kurs",
                "Java","Python"};


            for (int i = 0; i <kurslar.Length; i++) //bu döngü şart geçerli oldugu sürece çalışır 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-------------FOR BİTTİ--------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
