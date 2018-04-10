using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Klassiek : CD
    {
        private const double prijs = 2.00;
        private const int maxLeenDagen = 10;
        private int kortingsPercentage;
        private const double boete = 3.50;

        public Klassiek(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
            decimal weeks;

            //Voor elke week of een deel daarvan moet €1,00 worden betaald
            decimal temp = dagen / 7;
            weeks = Math.Ceiling(temp);

            int total = Convert.ToInt32(weeks);

            return total * boete;
        }
    }
}
