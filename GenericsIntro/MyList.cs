using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        T[] tempArray;
        public MyList()
        {
            //yapıcı method
            //ürünler diye bir array aç 0 elemanlı olsun
            items = new T[0];
        }
        public void Add(T item)
        {
            //ürünleri silme benim için bir yere cut/copy
            tempArray = items;
            //ürünlere 1 eleman daha ekle
            items = new T[items.Length + 1];
            //eski ürünlerim kaç taneyse dön liste olarak ver 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //eski ürünlerimin yanlarına ekle bitir.
            items[items.Length - 1] = item;
        }
    }
}
