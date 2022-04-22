using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {

                new Category {CategoryId = 1,CategoryName="Bilgisayar"},
                new Category {CategoryId=2,CategoryName="Telefon"}
                
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Casper laptop",QuantityPerUnit="32GB RAM",UnitPrice=1000,UnitInStock=5 },
                new Product{ProductId=2,CategoryId=1,ProductName="Asus laptop",QuantityPerUnit="32GB RAM",UnitPrice=13220,UnitInStock=2 },
                new Product{ProductId=3,CategoryId=2,ProductName="Acer Telefon",QuantityPerUnit="32GB RAM",UnitPrice=4999,UnitInStock=1 },
                new Product{ProductId=4,CategoryId=2,ProductName="Casper Telefon",QuantityPerUnit="32GB RAM",UnitPrice=3999,UnitInStock=6 },
                new Product{ProductId=5,CategoryId=1,ProductName="Oppo Telefon",QuantityPerUnit="32GB RAM",UnitPrice=1587,UnitInStock=8 },
            };

            
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }


            Console.WriteLine("--------linq--------");

            var result = products.Where(p => p.UnitPrice > 4000 && p.UnitInStock<3);
            //liste dönmek için
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------linq--------");


            static List<Product> GetProductsLinq(List<Product> products)
            {
                return products.Where(p => p.UnitPrice > 4000 && p.UnitInStock < 3).ToList();
            }
        }
        

        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }

        }
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
