using BlogProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Bussiness.Abstract
{
    public interface ICommentService
    {
        void Add(User user, Comment comment);
        void Update(User user, Comment comment);
        void Delete(User user, Comment comment);
    }
}
