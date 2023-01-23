using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Knjige
    {
        int ID;
        string Naziv, Autor;

        public Knjige(int iD, string naziv, string autor)
        {
            ID = iD;
            Naziv = naziv;
            Autor = autor;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
    }
}
