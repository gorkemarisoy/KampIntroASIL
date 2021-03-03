using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);

            var sayi1 = 6;
            dortIslem.Cikar(ref sayi1); //default olarak ikinci parametreyi 30 aldı

            dortIslem.Carp(2, 4);
            dortIslem.Carp(2, 4, 2);
            dortIslem.Topla2(1, 2, 3, 4, 5, 6);
        }
    }
}
