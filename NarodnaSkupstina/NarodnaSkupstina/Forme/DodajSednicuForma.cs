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
    public partial class DodajSednicuForma : Form
    {
        public DodajSednicuForma()
        {
            InitializeComponent();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            int BrojSednice = int.Parse(tbxBrojSednice.Text);
            int BrojSaziva = int.Parse(tbxBrojSaziva.Text);
            DateTime datumOd = DateTime.Parse(dtpOd.Text);
            DateTime datumDo = DateTime.Parse(dtpDo.Text);

            SednicaBasic sednica = new SednicaBasic();
            sednica.BrojSednice = BrojSednice;
            sednica.BrojSaziva = BrojSaziva;
            sednica.DatumPocetka = datumOd;
            sednica.DatumZavrsetka = datumDo;

            DTOManager.dodajSednicu(sednica);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
