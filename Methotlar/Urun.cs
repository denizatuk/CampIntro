using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    public class Urun
    {
        //property - özellik
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDesc { get; set; }
        public double ProductPrice { get; set; }
        //new Özellik geldi

        public int ProductStock { get; set; }
    }
}
