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
    public partial class DodajVanrednuForma : Form
    {
        public DodajVanrednuForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int BrojSednice = int.Parse(tbxBrojSednice.Text);
            int BrojSaziva = int.Parse(tbxBrojSaziva.Text);
            DateTime datumOd = DateTime.Parse(dtpOd.Text);
            DateTime datumDo = DateTime.Parse(dtpDo.Text);
            string inicijator = comboBox1.Text;

            VanrednaSednicaBasic sednica = new VanrednaSednicaBasic();
            sednica.BrojSednice = BrojSednice;
            sednica.BrojSaziva = BrojSaziva;
            sednica.DatumPocetka = datumOd;
            sednica.DatumZavrsetka = datumDo;
            sednica.Inicijator = inicijator;

            DTOManager.dodajSednicu(sednica);
        }
    }
}
