using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, IGetSalary

    {
        void IWorker.Work()
        {
            Console.WriteLine("Manager çalıştım");
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
