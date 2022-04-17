using BlogProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Entities.Concretes
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
