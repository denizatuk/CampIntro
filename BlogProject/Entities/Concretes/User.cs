using BlogProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Entities.Concretes
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
