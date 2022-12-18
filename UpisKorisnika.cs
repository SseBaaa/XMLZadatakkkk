using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Collections;

namespace AplikacijaZaBiblioteku
{
    public partial class UpisKorisnika : Form
    {
        static List<Korisnici> KorisniciList = new List<Korisnici>();
        static string putttt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string Fileee = "Korisnici.xml";
        static string put = Path.Combine(putttt, Fileee);
        public UpisKorisnika()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnosButun_Click(object sender, EventArgs e)
        {
            Korisnici KorisnikUpis = new Korisnici(Convert.ToInt32(OIBKorisnika.Text), ImeKorisnika.Text, PrezimeKorisnika.Text);
            KorisniciList.Add(KorisnikUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos korisnika?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Korisnici = XDocument.Load(put);
                    foreach (Korisnici korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik", new XElement("OIB", korisnik.OIB1), new XElement("Ime", korisnik.Ime1), new XElement("Prezime", korisnik.Prezime1));
                        Korisnici.Root.Add(Korisnik);
                    }
                    Korisnici.Save(put);
                }
                catch (Exception)
                {
                    var Korisnici = new XDocument();
                    Korisnici.Add(new XElement("Korisnici"));
                    foreach (Korisnici korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik",
                        new XElement("OIB", korisnik.OIB1),
                        new XElement("Ime", korisnik.Ime1),
                        new XElement("Prezime", korisnik.Prezime1));
                        Korisnici.Root.Add(Korisnik);
                    }
                    Korisnici.Save(put);
                }
                KorisniciList.Clear();
                this.Close();
            }
            OIBKorisnika.Text = "";
            ImeKorisnika.Text = "";
            PrezimeKorisnika.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpisKorisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
