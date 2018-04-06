using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Populair : CD
    {
        private double prijs;
        private int maxLeenDagen;
        private int kortingsPercentage;

        public Populair(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
        {

        }

        public override double GetPrijs()
        {
            return prijs;
        }

        public override int GetLeenDagen()
        {
            return maxLeenDagen;
        }

        public int GetKorting()
        {
            return kortingsPercentage;
        }
    }
}
