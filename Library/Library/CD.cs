using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library
{
    class CD : Artikel
    {
        private int artikelNr;
        private String naam;
        private int jaar;
        private ArrayList reserveringen;
        enum status
        {
            Aanwezig,
            Afwezig
        };

        protected CD(String naam, int artikelNr, int jaar)
        {
            this.naam = naam;
            this.artikelNr = artikelNr;
            this.jaar = jaar;
        }

        public String getName()
        {
            return naam;
        }

        public void setName(String set)
        {
            naam = set;
        }

        public void SetYear(int set)
        {
            jaar = set;
        }

        public int GetYear()
        {
            return jaar;
        }

        public int GetArtikelNr()
        {
            return artikelNr;
        }

        //enum GetStatus();
        public void ChangeStatus()
        {

        }
        public void AddReserveringen()
        {

        }
    }
}
