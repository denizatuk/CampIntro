using MiraOnline.Abstract;
using MiraOnline.Entities;
using System;

namespace MiraOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() 
            {
                UserName = "denizatuk",
                FirstName = "Deniz",
                LastName = "Atuk",
                Email = "dnz.atk96@gmail.com",
                Password = "1112221110",
                DateOfBirth = new DateTime(01, 09, 1996)
            };

            IGameService userService = new BaseGameManager();
            userService.Add(user);
            Console.WriteLine("Hello World!");
        }
    }
}
