using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();

            urun1.ProductName = "Elma";
            urun1.ProductPrice = 10;
            urun1.ProductDesc = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.ProductName = "Karpuz";
            urun2.ProductPrice = 10;
            urun2.ProductDesc = "Karpuz Elması";



            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.ProductName);
                Console.WriteLine(urun.ProductPrice);
                Console.WriteLine(urun.ProductPrice);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------METHOTLAR---------");
            //instance örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //encapsulition
            //sepetManager.Ekle2("Armut", "Yeşil Armut", 10); Ekle2 yeni özellik geldi->StockAmount
            sepetManager.Ekle2("Armut", "Yeşil Armut", 10,1);

            


        }
    }
}
