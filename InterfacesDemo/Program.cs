using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]   //müdür , çalışan ve robot çalışır
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();  //tüm çalışanlar çalışsın
            }

            IEat[] eats = new IEat[]     //robot yemez
            {
                new Manager(),
                new Worker()    //robot gelmez çünkü yemez IEat olarak tanımlamadık.
            };
        }
    }
}
