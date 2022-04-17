using MiraOnline.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiraOnline.Abstract
{
    class BaseGameManager : IGameService
    {
        public void Add(User user)
        {
            Console.WriteLine("Oyuncu Eklendi" + user.FirstName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("Oyuncu Güncellendi" + user.FirstName);
        }

        public void Update(User user)
        {
            Console.WriteLine("Oyuncu Silindi" + user.FirstName);
        }
    }
}
