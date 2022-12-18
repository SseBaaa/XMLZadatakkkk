using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Korisnici
    {
        
        public Korisnici(int oIB, string ime, string prezime)
        {
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
        }

        int OIB;
        string Ime;
        string Prezime;

        public int OIB1 { get => OIB; set => OIB = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
    }
}
