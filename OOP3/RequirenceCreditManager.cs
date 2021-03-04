using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequirenceCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı");
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
