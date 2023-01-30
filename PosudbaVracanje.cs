using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class PosudbaVracanje : Form
    {
        static List<Posudba> Posudbalista = new List<Posudba>();
        static string putttt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string Fileee = "Posudba.xml";
        static string put = Path.Combine(putttt, Fileee);
        public PosudbaVracanje()
        {
            InitializeComponent();
        }

        private void ZavrsiButun_Click(object sender, EventArgs e)
        {
            Posudba posudba = new Posudba(DateTime.Today, DateTime.Today.AddDays(30), Convert.ToInt32(textBoxKnjiga.Text), Convert.ToInt32(textBoxKorisnik.Text));
            Posudbalista.Add(posudba);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos posudba?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Posudbaaa = XDocument.Load(put);
                    foreach (Posudba posudbaa in Posudbalista)
                    {
                        var Posudivanje = new XElement("Posudba", new XElement("Datum_Posudbe", posudbaa.Datum_posudbe), new XElement("Datum_vracanja", posudbaa.Datum_vracanja), new XElement("ID_knjige", posudbaa.ID_knjige1), new XElement("ID_Korisnika", posudbaa.ID_korisnika1));
                        Posudbaaa.Root.Add(Posudivanje);
                    }
                    Posudbaaa.Save(put);
                }
                catch (Exception)
                {
                    var Posudbaaaa = new XDocument();
                    Posudbaaaa.Add(new XElement("Lista_Posudivanja"));
                    foreach (Posudba posudbaa in Posudbalista)
                    {
                        var Posudivanje = new XElement("Posudba", new XElement("Datum_Posudbe", posudbaa.Datum_posudbe), new XElement("Datum_vracanja", posudbaa.Datum_vracanja), new XElement("ID_knjige", posudbaa.ID_knjige1), new XElement("ID_Korisnika", posudbaa.ID_korisnika1));
                        Posudbaaaa.Root.Add(Posudivanje);
                    }
                    Posudbaaaa.Save(put);
                }
                Posudbalista.Clear();
                this.Close();
            }
            textBoxKnjiga.Clear();
            textBoxKorisnik.Clear();
        }

        private void PosudbaVracanje_Load(object sender, EventArgs e)
        {

        }
    }
}
