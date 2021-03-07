using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker:IWorker, IEat, IGetSalary      //çoklu interface ataması
    {
        public void Work()
        {
            Console.WriteLine("Worker çalıştım");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
