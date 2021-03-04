using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void TakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) //ICreditManager türünde creditManager gelecek
        {
            // başvuran bilgilerini alma
            //ResidenceCreditManager residenceCreditManager = new ResidenceCreditManager(); //Bu yanlış çünkü tüm başvurular konut kredisi gibi olur
            //residenceCreditManager.Calculate();// yanlışş

            creditManager.Calculate();  //ne kredisi gönderirsem onun hesaplası çalışır. residence gelirse residence, vehicle gelrise vehicle.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();    //hangi loglama türleri seçildiyse öyle yokla
            }
            

        }

        public void CreditPreInformation(List<ICreditManager> credits)//müşteri karşılaştırabilsin diye birden fazla kredi hesaplaması yaptırmak için
        {
            foreach (var credit in credits)     //gönderilen credits listesi için herbiri ayrı ayrı hesaplandı.
            {
              credit.Calculate();  
            }
        }
        
    }
}
