using BlogProject.Bussiness.Abstract;
using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Concretes
{
    public class CommentManager : ICommentService
    {
        public void Add(User user, Comment comment)
        {
            Console.WriteLine(user.FirstName + " adlı kullanıcı yorum ekledi ");
        }

        public void Delete(User user, Comment comment)
        {
            Console.WriteLine(user.FirstName + " adlı kullanıcı yorum ekledi ");
        }

        public void Update(User user, Comment comment)
        {
            Console.WriteLine(user.FirstName + " adlı kullanıcı yorum ekledi ");
        }
    }
}
