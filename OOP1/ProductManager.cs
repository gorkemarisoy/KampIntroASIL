using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //CRUD operations Create, Read, Update, Delete
        public void Add(Product product)    //Product türünde product ver //String Ad gibi
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)  //bu methodu çalıştırırsan sana int değerinde bi sonuç geri gönderirim.
        {
            return sayi1 + sayi2;   
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
              //return kullanamıyoruz, void olduğu zaman sonucu yazdırabiliriz ekrana
                                    //ama o sonucu alıp başka işlemde kullanamayız
        }
    }
}
