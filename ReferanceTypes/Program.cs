using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }



    }
    class Customer:Person
    {
        public string CreditCartNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }
}
