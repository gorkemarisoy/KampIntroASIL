using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Selin", "Muratoğlu", "Ankara"); //bu yazdığımız ctor çalıştırır, aşağıda yazmasak olmazdı

            Customer customer2 = new Customer{Id = 2, FirstName = "Görkem", LastName = "Arısoy", City = "İstanbul"}; //bu default şekilde kullanabilirim.

            Console.WriteLine(customer1.FirstName); //aşağıda manuel atama yaptığımız için çalıştı. FirstName=firstName gibi
            Console.WriteLine(customer2.FirstName);  //manuel atama yapmadık çünkü atamayı zaten süslü parantez içinde yukarıda yaptık
        }
    }

    class Customer
    {
        //Constructorlar adı üzerinde yapıcı işley görür. yazılmasa bile default olarak çalışır ama amacımıza göre biz de yazabiliriz.

        public Customer()  //default ctor yazılmasa da çalışır
        {
            
        }

        public Customer(int id, string firstName, string lastName, string city)  //buda istediğimiz usulde çalışacak ctor.
        {
            Id = id;
            FirstName = firstName;      //Bunları yazmazsak methoda gelen parametreler işlem görmez.
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
