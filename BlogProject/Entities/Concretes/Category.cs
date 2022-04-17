using BlogProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Entities.Concretes
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public int MenuStatus { get; set; }

    }
}
