using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Deniz";
            musteri1.Age = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Ahmet";
            musteri2.Age = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Remzi";
            musteri3.Age = 35;



            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("-----------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("---------------- Müşteri Listesi -----------------");
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Name);
            }

        }
    }
}
