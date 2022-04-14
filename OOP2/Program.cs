using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deniz atk
            InvidualCustomer muster1 = new InvidualCustomer();
            muster1.Id = 2;
            muster1.CustomerNumber = "12345";
            muster1.FirstName = "Deniz";
            muster1.LastName = "Atuk";
            muster1.IdentityNumber = "38272072258";


            //kodlama.io

            CoorprateCustomer muster2 = new CoorprateCustomer();
            muster2.Id = 1;
            muster2.CompanyName = "kodlamaio";
            muster2.CustomerNumber = "12231";
            muster2.TaxNumber = "1231231";

            //gerçk müsteri - tüzel msteri
            //solid

            Console.WriteLine("Hello World!");
            Customer customer3 = new InvidualCustomer();
            
            Customer customer4 = new CoorprateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(muster1);
            customerManager.Add(muster2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
