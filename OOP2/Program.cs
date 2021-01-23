using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "213123123123";


            //Kodlama.io

            CooperateCustomer customer2 = new CooperateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "54321";
            customer2.FirmName = "Kodlama.io";
            customer2.TaxNo = "1233445678";




            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CooperateCustomer();

            CustomerManager customer = new CustomerManager();

            customer.Add(customer1);
            customer.Add(customer2);

            




        }
    }
}
