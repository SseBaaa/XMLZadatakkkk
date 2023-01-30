using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Posudba
    {
        DateTime datum_posudbe, datum_vracanja;
        int ID_knjige, ID_korisnika;

        public Posudba(DateTime datum_posudbe, DateTime datum_vracanja, int iD_knjige, int iD_korisnika)
        {
            this.datum_posudbe = datum_posudbe;
            this.datum_vracanja = datum_vracanja;
            ID_knjige = iD_knjige;
            ID_korisnika = iD_korisnika;
        }

        public DateTime Datum_posudbe { get => datum_posudbe; set => datum_posudbe = value; }
        public DateTime Datum_vracanja { get => datum_vracanja; set => datum_vracanja = value; }
        public int ID_knjige1 { get => ID_knjige; set => ID_knjige = value; }
        public int ID_korisnika1 { get => ID_korisnika; set => ID_korisnika = value; }
    }
}
