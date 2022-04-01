using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        static String Message = "Müşteri Kayıt Edildi.";
        

        public void Add(Musteri musteri)
        {
            Console.WriteLine(Message + " " + musteri.Name);
        }
        public void Listele()
        {
            
        }

    }
}
