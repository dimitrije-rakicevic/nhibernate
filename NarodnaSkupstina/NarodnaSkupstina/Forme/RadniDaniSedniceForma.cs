using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstina.Forme
{
    public partial class RadniDaniSedniceForma : Form
    {
        int idSednice;

        public RadniDaniSedniceForma(int idSednice)
        {
            InitializeComponent();
            this.idSednice = idSednice;
        }

        private void RadniDaniSedniceForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

        }
    }
}
