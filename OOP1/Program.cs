using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //bu şekilde product oluştur.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
                {Id = 2, CategoryId = 5, UnitPrice = 5, ProductName = "Kalem", UnitsInStock = 35}; //bu şekilde de product oluşturulabilir.


            //PascalCase(class)    //camelCase(degisken)      // ProductManager türünde productManager oluşturduk.
            //Stack                         //Heap              //Aynı string isim = "Gorkem"; gibi
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool - değer tip  - yani atamalar sadece değer olarak kalar.
            //diziler, classlar, interfaceler - referans tip yani atamalar referans olarak gider. dolayısı ile method referansı değiştirirse bunlar da değişir

            int toplamaSonucu = productManager.Topla(3, 5); //ProductManager'da public int dediğim için int return edebilrim.
                                                                                //public void deseydim yapamazdım.
            Console.WriteLine(productManager.Topla(3,5));
            Console.WriteLine(productManager.Topla(3,5)*2); //yapabilirim. voidde olmazdı.


        }
    }
}
