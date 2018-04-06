using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Lening
    {
        private int aantalDagenGeleend;
        public Artikel artikel;
        private double boete;

        public Lening(Artikel artikel)
        {

            aantalDagenGeleend = 0;
            this.artikel = artikel;
        }

        public void IncrementDagen()
        {
            aantalDagenGeleend = aantalDagenGeleend + 1;
        }

        public double BerekenBoetes()
        {
            if (aantalDagenGeleend > artikel.GetLeenDagen())
            {
                // voeg bereken boete toe aan alle classes...
                boete = 0;
                
            }
            return boete;
        }

        public double BerekenLeengeld()
        {
            return artikel.GetPrijs();
        }

        public Artikel GetArtikel()
        {
            return artikel;
        }

    }
}
