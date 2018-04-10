using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Klasiek : CD
    {
        private const double prijs = 2.00;
        private const int maxLeenDagen = 10;
        private int kortingsPercentage;
        private const double boete = 2.00;

        public Klasiek(String naam, int artikelNr, int jaar) : base(naam,artikelNr,jaar)
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
            double temp;
            if (dagen % 7 == 0)
            {
                temp = dagen * boete;
                return temp;
            }
            else
            {
                for (int i = dagen; dagen > 0; dagen--)
                {
                    if (dagen % 7 == 0)
                    {
                        temp = dagen * boete;
                        return temp;
                    }
                }

            }
            return 0;
        }
    }
}
