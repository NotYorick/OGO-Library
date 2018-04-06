using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library
{
    class Boek : Artikel
    {

        private int ArtikelNr;
        private String Naam;
        private int Jaar;
        private ArrayList Reserveringen;
        private enum Status
        {
            Aanwezig,
            Afwezig
        };

        protected Boek(String naam, int artikelNr, int jaar)
        {
            this.Naam = naam;
            this.ArtikelNr = artikelNr;
            this.Jaar = jaar;
        }

        public String getName()
        {
            return Naam;
        }

        public void setName(String set)
        {
            Naam = set;
        }

        public void SetYear(int set)
        {
            Jaar = set;
        }

        public int GetYear()
        {
            return Jaar;
        }

        public Status ChooseCase()
        {
            return Stat;
        }

        public void ChangeStatus()
        {

        }
        public void AddReserveringen()
        {

        }
    }
}
