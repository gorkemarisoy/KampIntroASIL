using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.FirstName = "Görkem";
            customer1.IdNo = "1";
            customer1.LastName = "ARISOY";
            customer1.CustomerNo = "1";
            customer1.Id = 1;

            Corporate customer2 = new Corporate();
            customer2.CompanyName = "ARISOY";
            customer2.TaxNo = "123456";
            customer2.CustomerNo = "2";
            customer2.Id = 2;

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); //Individual
            customerManager.Add(customer2);        //Inheritance yaptığımız için CustomerManager Individual, Corporate, Customer classlarının hepsini gönderebilriz.
            customerManager.Add(customer3);
            customerManager.Add(customer4); //Corporate






        }
    }
}
