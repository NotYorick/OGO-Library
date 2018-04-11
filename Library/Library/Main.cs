using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Library
{
    class Main
    {

        private ArrayList leden;
        private ArrayList artikelen;
        private ArrayList ingeleverdeArtikelen;

        public Main()
        {
            leden = new ArrayList();
            artikelen = new ArrayList();
            ingeleverdeArtikelen = new ArrayList();

            leden.Add(new Lid("HENK", "Sts", 0));
            leden.Add(new Lid("Daan", "Smits", 1));
            leden.Add(new Lid("sjaak", "Ss", 2));

            artikelen.Add(new Roman("Harry potter",1,2003));
            artikelen.Add(new Roman("Flash", 2, 2012));
            artikelen.Add(new Roman("Verri", 3, 2000));
            artikelen.Add(new Roman("hoff", 4, 2001));
            artikelen.Add(new Studieboek("ingepakt", 5, 1993));
            artikelen.Add(new Populair("top4", 5, 1998));
            artikelen.Add(new Klassiek("topoud", 6, 1999));


        }

        public void ArtikelVerwerken(Artikel artikel)
        {
            artikel.ChangeStatus();
            //reservering
            ingeleverdeArtikelen.Remove(artikel);
        }

        public void ArtikelVerwijderen(Artikel artikel)
        {
            artikelen.Remove(artikel);
        }

        public void ArtikelToevoegen(String naam, int jaar, String soort)
        {
            Artikel art = new A(null,0,0);
            switch (soort)
            {
                case "a":
                    art = new A(naam, artikelen.Count, jaar);
                    break;
                case "b":
                    art = new B(naam, artikelen.Count, jaar);
                    break;
                case "populair":
                    art = new Populair(naam, artikelen.Count, jaar);
                    break;
                case "klassiek":
                    art = new Klassiek(naam, artikelen.Count, jaar);
                    break;
                case "roman":
                    art = new Roman(naam, artikelen.Count, jaar);
                    break;
                case "studieboek":
                    art = new Studieboek(naam, artikelen.Count, jaar);
                    break;

            }
            artikelen.Add(art);
        }

        public void LidToevoegen(String voornaam, String achternaam)
        {
            Lid lid = new Lid(voornaam,achternaam,leden.Count + 1);
            leden.Add(lid);
        }

        public void LidVerwijderen(Lid lid)
        {
            leden.Remove(lid);
        }

        public double GetBoetes()
        {
            return 0;
        }

        public double GetLeengeld()
        {
            return 0;

        }

        public double GetTotaleInkomsten()
        {
            return 0;
        }

        public void NextDay()
        {
            foreach (Lid lid in leden)
            {
                List<Lening> temp =  lid.GetLeenArtikelen();
                foreach (Lening len in temp)
                {
                    len.IncrementDagen();
                }
                
            }
        }

        public void StuurBericht(String klantNr)
        {
            
        }

        public Artikel GetArtikel(int artNr)
        {
            foreach(Artikel art in artikelen)
            {
                if (art.GetArtikelNr() == artNr)
                {
                    return art;
                }
            }
            return null;

        }

        public Lid GetLid(int lidNr)
        {
            foreach (Lid lid in leden)
                    {
                        if (lid.GetKlantNr() == lidNr)
                        {
                            
                            return lid;
                        }
                    }
            return null;
        } 

        public List<Artikel> GetAllArtikelen()
        {
           
            List<Artikel> lijst = artikelen.Cast<Artikel>().ToList();
         
            return lijst;
        }

        public List<Artikel> GetAllIngeleverdeArtikelen()
        {

            List<Artikel> lijst = ingeleverdeArtikelen.Cast<Artikel>().ToList();

            return lijst;
        }

        public void ArtikelInleveren(Artikel artikel)
        {
            ingeleverdeArtikelen.Add(artikel);
        }

        public List<Lid> GetLeden()
        {
            List<Lid> lijst = leden.Cast<Lid>().ToList();
            return lijst;
        }



    }
}
