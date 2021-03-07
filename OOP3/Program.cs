 using System;
using System.Collections.Generic;
 using System.Drawing;

 namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //RequirenceCreditManager requirenceCreditManager = new RequirenceCreditManager();
            //requirenceCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager residenceCreditManager = new ResidenceCreditManager();
            ICreditManager requirenceCreditManager = new RequirenceCreditManager();   //Interface ile requirenceCreditManager da çağrılabiliyor.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SMSLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.TakeApplication(vehicleCreditManager, fileLoggerService);    //Burda hangi tip krediyi girdiğinde onu hesaplayacaktır. ve seçilen türde loglama yapacak
            //applicationManager.TakeApplication(vehicleCreditManager); //Bu durumda istediğimiz kadar yeni kredi tipi ekleyip çıkarabiliriz.

            applicationManager.TakeApplication(new EsnafKredisiManager(), new List<ILoggerService>(){smsLoggerService, databaseLoggerService});  //Yeni eklenen esnaf kredisi ve SMS loglama yöntemlerini böyle de newleyebiliriz.

            List<ICreditManager> credits = new List<ICreditManager>() {requirenceCreditManager, vehicleCreditManager}; //kredi karşılaştırması için seçilen krediler listesi {} içine yazılır
            applicationManager.CreditPreInformation(credits);
        }

    }
}
