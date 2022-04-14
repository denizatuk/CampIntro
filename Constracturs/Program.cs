using System;

namespace Constracturs
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer(2, "Deniz", "Atuk", "İstanbul");
            Customer customer2 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);

        }
    }
}
