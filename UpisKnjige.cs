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

namespace AplikacijaZaBiblioteku
{
    public partial class UpisKnjige : Form
    {
        public UpisKnjige()
        {
            InitializeComponent();
        }

        

        private void UnosButun_Click(object sender, EventArgs e)
        {
            var s = XDocument.Load(Environment.SpecialFolder.MyDocuments + "Biblioteka.xml");
            s.Element("Korisnici").Add(new XElement("Knjiga"));
            this.Close();
        }

        private void UpisKnjige_Load(object sender, EventArgs e)
        {

        }
    }
}
