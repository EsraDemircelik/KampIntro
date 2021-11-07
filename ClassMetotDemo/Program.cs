using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Ali";
            customer1.Soyad = "Kaya";
            customer1.Sehir = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Ad = "Elif";
            customer2.Soyad = "Yılmaz";
            customer2.Sehir = "Ankara";

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Ad);
                Console.WriteLine(customer.Soyad);
                Console.WriteLine(customer.Sehir);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer2);
        }
    }
}
