using System;

namespace MyDictiorys
{
    class MyDictiorys<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictiorys()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }


    }
}
