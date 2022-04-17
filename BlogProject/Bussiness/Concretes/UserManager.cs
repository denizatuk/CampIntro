using BlogProject.Bussiness.Abstract;
using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Concretes
{
    public class UserManager : IUserService
    {
        public void Add(User user)
        {

            Console.WriteLine("Kullanıcı eklendi");

        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı Düzenlendi");
        }
    }
}
