using System;

namespace SartBloklari
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

             if (number == 10)
             {
                 Console.WriteLine("Number is 10");
             }
             else if (number == 20)
            {
               Console.WriteLine("Number is 20");
             }
             else
              {
                  Console.WriteLine("Number is not 10 or 20");
             }

            //yada tek satırda yazabilirdik
            //Console.WriteLine(number == 10 ? "Number is 10 : "Number is not 10"); //resharper yüklü olsaydı

            //Switch
            //switch (number) //resharper ile olacaktı
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //    case 20:
            //        Console.WriteLine("number is 20");
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            //ÇOKLU ŞART
            if (number >= 0 && number <=100) // && VE 
            {
                Console.WriteLine("Number is between 0 - 100");
            }
            else if (number > 100 || number < 0) //  || Veya demek 
            {
                Console.WriteLine("Number is less than 0 OR greater than 100");
            }

        }
    }
}
