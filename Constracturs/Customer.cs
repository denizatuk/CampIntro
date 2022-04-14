using System;
using System.Collections.Generic;
using System.Text;

namespace Constracturs
{
    class Customer
    {
        //Default Constructur
        public Customer()
        {
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }

        //Parametreli constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Parametreli Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
