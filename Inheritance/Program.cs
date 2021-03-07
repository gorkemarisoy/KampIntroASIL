using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person(),   //Interface olsaydı diğerleri ile beraber tanımlanamazdı.
                new Customer(), //Customer Person'un mirasçısı (inheritance) ama person interface olmadığı için onlar gibi tanımlanabilir.
                new Student()
            };

        }
    }

    interface IPerson2
    {
        
   

    }

    class Worker:Person,IPerson2    //yani bir classın hem mirasçısı hem de interface'i olabilir.
                                    //fakat önce inheritance yazılır.
    {                                  //Interface mi yoksa Inheritance mı kullanmamız gerektiği konusunda kararsız kalırsak
                                        // interface kullanmak mümkünse interface kullanmalıyız

    }
}
