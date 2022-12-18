using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaBiblioteku
{
    public partial class PosudbaVracanje : Form
    {
        public PosudbaVracanje()
        {
            InitializeComponent();
        }

        private void ZavrsiButun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
