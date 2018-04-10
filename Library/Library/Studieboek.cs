using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Studieboek : Boek
    {
        private const double prijs = 0;
        private const double boete = 1.00;
        private const int maxLeenDagen = 30;

        public Studieboek(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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

        public override double BerekenBoete(int dagen)
        {
            decimal weeks;

            //Voor elke week of een deel daarvan moet €1,00 extra worden betaald
            decimal temp = dagen / 7;
            weeks = Math.Ceiling(temp);

            int total = Convert.ToInt32(weeks);
            
            return total * boete;
        }
    }
}
