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
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (!Directory.Exists(Environment.SpecialFolder.MyDocuments + "Knjige.xml"))
            {
                var Knjige = new XDocument();
                Knjige.Add(new XElement("Knjige"));
                Knjige.Save(Environment.SpecialFolder.MyDocuments + "Knjige.xml");
            }
            
            if (!Directory.Exists(Environment.SpecialFolder.MyDocuments + "PosudbeIVracanja.xml"))
            {
                var PosudbeIVracanja = new XDocument();
                PosudbeIVracanja.Add(new XElement("PosudbeIVracanja"));
                PosudbeIVracanja.Save(Environment.SpecialFolder.MyDocuments + "PosudbeIVracanja.xml");
            }
            InitializeComponent();
        }

        private void UpisKorisnikaButton_Click(object sender, EventArgs e)
        {
            UpisKorisnika Korisnik = new UpisKorisnika();
            Korisnik.ShowDialog();
        }

        private void PVButton_Click(object sender, EventArgs e)
        {
            PosudbaVracanje PV = new PosudbaVracanje();
            PV.ShowDialog();
        }

        private void UpisKnjigeButton_Click(object sender, EventArgs e)
        {
            UpisKnjige Knjiga = new UpisKnjige();
            Knjiga.ShowDialog();
        }

        private void DBBrowserButun_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            pretraga.ShowDialog();
        }

        private void ZatvoriButun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
