using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cikart(int sayi1,int sayi2)
        {
            int cikart = sayi1 - sayi2;
            Console.WriteLine(cikart);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine(bolme);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine(carpma);
        }

    }
}
