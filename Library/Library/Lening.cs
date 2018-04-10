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
        private bool betaald;

        public Lening(Artikel artikel)
        {
            betaald = false;
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
                boete = artikel.BerekenBoete(aantalDagenGeleend - artikel.GetLeenDagen());
            }
            return boete;
        }

        public double BerekenLeengeld()
        {
            if (!betaald)
            {
                betaald = true;
                Debug.WriteLine("Leen:" + artikel.GetPrijs());
                return artikel.GetPrijs();
            }
            return 0;
        }

        public Artikel GetArtikel()
        {
            return artikel;
        }

    }
}
