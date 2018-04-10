using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class B : DVD
    {

        private const double prijs = 2.00;
        private const int maxLeenDagen = 3;
        private const double boete = 3.00;

        public B(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
            return dagen * boete;
        }
    }
}
