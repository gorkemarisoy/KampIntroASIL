using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ResidenceCreditManager:ICreditManager  //her kredi mutlaka interface içindeki metodları içermek zorunda
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hazırlandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public void BlaBla()
        {
            throw new NotImplementedException();
        }
    }
}
