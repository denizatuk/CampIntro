using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAll();
            Console.WriteLine("----------------kategoriye gore getir---------------");
            GetProductsByCategoryId(1);
        }

        private static void GetAll()
        {
            NortwindContext nortwindContext = new NortwindContext();
            foreach (var product in nortwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByCategoryId(int categoryId) 
        {
            NortwindContext nortwindContext = new NortwindContext();
            var result = nortwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
}
