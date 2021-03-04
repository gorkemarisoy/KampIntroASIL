using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //imzanın aynı olduğu fakat içeriğin farklı olduğu durumalrda 
                        //BASE olan class'ı Interface olarak açarız
    {
        void Calculate();  //eğerki birisi CreditManager interfaceini kullanırsa burdaki metodlardan biriini kullanmak zorunda
        void DoSomething();
        void BlaBla();

    }
}
