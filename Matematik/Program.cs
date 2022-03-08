using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); //benim toplama işlemini yapan metotum var 
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);
        }
    }
}
