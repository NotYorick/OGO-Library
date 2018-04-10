using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class A : DVD
    {
        private const double prijs = 2.00;
        private const int maxLeenDagen = -1;
        private const double boete = 0.00;

        public A(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
            //No extra kosten gespecificeerdvoor A-Films
            return boete;
            
        }
    }
}
