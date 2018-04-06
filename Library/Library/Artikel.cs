using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface Artikel
    {
        String getName();
        void setName( String set);
        void SetYear(int set);
        int GetYear();
        //enum GetStatus();
        void ChangeStatus();
        void AddReserveringen();
        int GetArtikelNr();

    }
}
