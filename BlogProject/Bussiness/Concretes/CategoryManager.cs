using BlogProject.Bussiness.Abstract;
using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Concretes
{
    public class CategoryManager : ICategoryService
    {
        public void Add(Category category)
        {
            Console.WriteLine(category.CategoryName + "Adlı Kategori eklendi");
        }

        public void Delete(Category category)
        {
            Console.WriteLine(category.CategoryName + "Adlı Kategori eklendi");
        }

        public void Update(Category category)
        {
            Console.WriteLine(category.CategoryName + "Adlı Kategori eklendi");
        }
    }
}
