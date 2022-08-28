using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Zeynep";
            customer1.LastName = "Mirzooğlu";
            customer1.IdentityNumber = "1111111111";

            Customer customer2= new Customer();
            customer2.FirstName = "Gani";
            customer2.LastName = "Mirzooğlu";
            customer2.IdentityNumber = "118989891";

            Customer customer3 = new Customer();
            customer3.FirstName = "Muhammed";
            customer3.LastName = "Mirzooğlu";
            customer3.IdentityNumber = "1236565911";

            Customer customer4 = new Customer();
            customer4.FirstName = "Duygu";
            customer4.LastName = "Ağaoğlu";
            customer4.IdentityNumber = "1112221111";

            Customer[] customers= new Customer[] { customer1, customer2,customer3,customer4 };

            foreach (var customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("Müşteri Adı - Soyadı : " + customer.FirstName+" "+ customer.LastName + " ");
            }

            Console.WriteLine("*************************");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Console.WriteLine("*************************");

            customerManager.Update(customer1);
            customerManager.Update(customer2);
            customerManager.Update(customer3);
            customerManager.Update(customer4);

            Console.WriteLine("*************************");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);
        }
    }
}