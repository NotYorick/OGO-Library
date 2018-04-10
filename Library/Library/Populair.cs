using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Populair : CD
    {
        private const double prijs = 1.00;
        private const int maxLeenDagen = 10;
        private int kortingsPercentage;
        private const double boete = 2;

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

        public override double BerekenBoete(int dagen)
        {
            return dagen * boete;
        }

    }
}
