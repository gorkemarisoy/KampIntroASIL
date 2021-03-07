using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService   //şablonu oluşturduk. ve ilgili classlarda bu şablonu işleyeceğiz
    {
        void Log();     //loglama işlemi tüm class için geçerçi ama her classın çalıştırdığı kod farklı olabilir.(unimplemented operation)
                        //inheritance(implemented operation) olsaydı eğer tüm classlar aynı kodu çalıştıracaktı
    }
}
