using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Knjige
    {
        public Knjige(int iD, string naziv, string autor, int kolicina)
        {
            ID = iD;
            Naziv = naziv;
            Autor = autor;
            this.kolicina = kolicina;
        }

        int ID { get; set; }
        string Naziv { get; set; }
        string Autor { get; set; }
        int kolicina { get; set; }
    }
}
