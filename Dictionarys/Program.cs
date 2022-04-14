using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(112, "ahmet");
            ogrenciler.Add(132, "mehmet");
            ogrenciler.Add(223, "ayşe");

            Console.WriteLine("öğrenci no giriniz: ");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(ogrenciler[No]);

            }
            catch
            {
                Console.WriteLine("ogrenci bulunamadi");
            }
        }
        

        
    }
}
