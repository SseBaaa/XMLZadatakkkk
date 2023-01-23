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
    public partial class Pretraga : Form
    {
        public Pretraga()
        {
            InitializeComponent();
        }

        private void PretragaButun_Click(object sender, EventArgs e)
        {
            string putttt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string Fileee = "Korisnici.xml";
            string Fileeee = "Knjige.xml";
            string put = Path.Combine(putttt, Fileee);
            string putt = Path.Combine(putttt, Fileeee);
            PretragaRichTextbox.Clear();
            if(textBox2.Text != "")
            {
                XDocument doc = XDocument.Load(put);
                XElement root = doc.Root;
                var id = root.Elements("Korisnik").FirstOrDefault(m => m.Element("OIB").Value == textBox2.Text);
                PretragaRichTextbox.AppendText(id.ToString() + Environment.NewLine);
            }
            if (textBox3.Text != "")
            {
                XDocument doc = XDocument.Load(putt);
                XElement root = doc.Root;
                var id = root.Elements("Knjiga").FirstOrDefault(m => m.Element("ID").Value == textBox3.Text);
                PretragaRichTextbox.AppendText(id.ToString() + Environment.NewLine);
            }




        }

        

        private void Pretraga_Load(object sender, EventArgs e)
        {

        }
    }
}
