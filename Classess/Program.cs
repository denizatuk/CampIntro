using System;

namespace Classess
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Edit();
            customerManager.Delete();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Edit();
            productManager.Delete();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.CustomerId = "12312";
            customer.FirstName = "Deniz";
            customer.LastName = "Atuk";

            Console.WriteLine(customer.LastName);
            
            Console.WriteLine("Hello World!");
        }
    }
}
