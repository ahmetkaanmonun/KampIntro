using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requiredCreditManager = new RequiredCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();


            ApplicationManager applicationManager = new ApplicationManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            applicationManager.Apply(vehicleCreditManager,fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {requiredCreditManager,houseCreditManager };

            // applicationManager.KrediOnBilgilendirmesiYap(credits);

           

        }
    }
}
