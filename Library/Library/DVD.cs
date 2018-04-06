using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Library
{
    abstract class DVD : Artikel
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

        protected DVD(String naam, int artikelNr, int jaar)
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
        //enum GetStatus();
        public void ChangeStatus()
        {
            
        }
        public void AddReserveringen()
        {
            
        }

    }
}
