using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library
{
    abstract class Boek : Artikel
    {

        private int artikelNr;
        private String naam;
        private int jaar;
        private ArrayList reserveringen;
        private status stat;
        public enum status
        {
            Aanwezig,
            Afwezig
        };

        protected Boek(String naam, int artikelNr, int jaar)
        {
            this.naam = naam;
            this.artikelNr = artikelNr;
            this.jaar = jaar;
            stat = status.Aanwezig;
            
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

        public String GetStatus()
        {
            return stat.ToString();
        }

        public abstract double BerekenBoete(int dagen);

        public void ChangeStatus()
        {
            if (stat == status.Aanwezig)
            {
                stat = status.Afwezig;
            }
            else if (stat == status.Afwezig)
            {
                stat = status.Aanwezig; ;
            }
        }

        public abstract double GetPrijs();
        

        public void AddReserveringen()
        {

        }

        public abstract int GetLeenDagen();

    }
}
