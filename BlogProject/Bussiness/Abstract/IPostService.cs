using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Abstract
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
