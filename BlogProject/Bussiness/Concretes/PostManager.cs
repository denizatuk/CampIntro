using BlogProject.Bussiness.Abstract;
using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Concretes
{
    public class PostManager : IPostService
    {
        

        public void Add(Post post)
        {
            Console.WriteLine("Post Ekledi");
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
