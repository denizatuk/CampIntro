using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Manisa");
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
        }   
    }
    class MyList<T>//Generic Class
    {
        T[] items;

        public MyList()
        {   
            //yapıcı method
            items = new T[0];
        }

        public void Add(T item)
        {   
            //Geçiçi liste olustur items içindekileri oraya ekle
            T[] tempItems = items;
            //listeme yeni yer oluştur { }
            items = new T[items.Length + 1];
            //Eski listemi geri getir ne kadar eleman varsa dön
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            //yeni oluşturduğum elemanları eskiye ekle bitir.
            items[items.Length - 1] = item;
            //cooldown
        }

    }
}
