using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class MyDict<TK1,TV2>
        {
            TK1[] _arry1;
            TK1[] _temp1;
            TV2[] _arry2;
            TV2[] _temp2;
            public MyDict()
            {
                _arry1 = new TK1[0];
                _arry2 = new TV2[0];

                //yapıcı method
            }

            public void Add(TK1 Id,TV2 Name)
            {

            }
            public int Id { get; }
            public string Name { get;}
        }
        
    }

    
}
