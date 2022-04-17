using MiraOnline.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiraOnline.Abstract
{
    interface IGameService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
