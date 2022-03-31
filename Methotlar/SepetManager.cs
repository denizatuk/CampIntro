using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    public class SepetManager
    {
        private String Message = "Sepete Eklendi.";
        //naming convension
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(Message + "  " + urun.ProductName);
        }
        public void Ekle2(string ProductName,string ProductDescription,double ProductPrice,int ProductStock)
        {
            Console.WriteLine(Message);
        }
        public void Listele()
        {

        }
    }
}
