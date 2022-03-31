using System;

namespace WhyArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studends = { "Deniz", "Ahmet", "Doğa" };
            foreach (var student in studends)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
