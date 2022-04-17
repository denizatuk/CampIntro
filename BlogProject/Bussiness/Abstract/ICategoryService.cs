using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
