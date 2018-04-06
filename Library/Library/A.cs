using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class A : DVD
    {
        private double prijs;
        private int maxLeenDagen;

        public A(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
        {

        }

        public double GetPrijs()
        {
            return prijs;
        }

        public int GetLeenDagen()
        {
            return maxLeenDagen;
        }
    }
}
