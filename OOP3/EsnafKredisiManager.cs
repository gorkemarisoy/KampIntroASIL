using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager:ICreditManager
{
    public void Calculate()
    {
        Console.WriteLine("Esnaf Kredisi Hesaplandı");
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
