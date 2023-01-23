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
    public partial class UpisKnjige : Form
    {
        static List<Knjige> KnjigeList = new List<Knjige>();
        static string putttt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string Fileee = "Knjige.xml";
        static string put = Path.Combine(putttt, Fileee);
        public UpisKnjige()
        {
            InitializeComponent();
        }

        

        private void UnosButun_Click(object sender, EventArgs e)
        {
            
        }

        private void UpisKnjige_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Knjige KnjigeUpis = new Knjige(Convert.ToInt32(textBoxID.Text), textBoxNaziv.Text, textBoxAutor.Text);
            KnjigeList.Add(KnjigeUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos knjiga?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Knjigee = XDocument.Load(put);
                    foreach (Knjige knjige in KnjigeList)
                    {
                        var Korisnik = new XElement("Knjiga", new XElement("ID", knjige.ID1), new XElement("Naziv", knjige.Naziv1), new XElement("Autor", knjige.Autor1));
                        Knjigee.Root.Add(Korisnik);
                    }
                    Knjigee.Save(put);
                }
                catch (Exception)
                {
                    var Knjigee = new XDocument();
                    Knjigee.Add(new XElement("Knjige"));
                    foreach (Knjige knjige in KnjigeList)
                    {
                        var Korisnik = new XElement("Knjiga",
                        new XElement("ID", knjige.ID1),
                        new XElement("Naziv", knjige.Naziv1),
                        new XElement("Autor", knjige.Autor1));
                        Knjigee.Root.Add(Korisnik);
                    }
                    Knjigee.Save(put);
                }
                KnjigeList.Clear();
                this.Close();
            }
            textBoxID.Text = "";
            textBoxNaziv.Text = "";
            textBoxAutor.Text = "";
        }
    }
}
