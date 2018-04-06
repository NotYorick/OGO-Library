using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class B : DVD
    {

        private double prijs;
        private int maxLeenDagen;

        public B(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
