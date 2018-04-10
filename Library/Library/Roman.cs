using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Roman : Boek
    {
        private const double prijs = 0;
        private const int maxLeenDagen = 21;
        private const double boete = 0.25;

        public Roman(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
