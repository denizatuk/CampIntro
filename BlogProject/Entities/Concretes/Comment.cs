using BlogProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Entities.Concretes
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostID { get; set; }
        public int Rating { get; set; }
        public string Commend { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
