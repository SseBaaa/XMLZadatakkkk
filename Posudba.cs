using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Posudba
    {
        DateTime datum_posudbe { get; set; }
        DateTime datum_vracanja { get; set; }
        int ID_knjige { get; set; }
        int ID_korisnika { get; set; }

        public Posudba(DateTime datum_posudbe, DateTime datum_vracanja, int iD_knjige, int iD_korisnika)
        {
            this.datum_posudbe = datum_posudbe;
            this.datum_vracanja = datum_vracanja;
            ID_knjige = iD_knjige;
            ID_korisnika = iD_korisnika;
        }
    }
}
