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
    public partial class StalniRadniOdnosForma : Form
    {
        public StalniRadniOdnosForma()
        {
            InitializeComponent();
        }

        private void StalniRadniOdnosForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listaStalnoZaposleni.Items.Clear();
            List<StalniRadniOdnosPregled> podaci = DTOManager.vratiSveSRD();

            foreach (StalniRadniOdnosPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.NarPosId.ToString(), p.Jmbg.ToString(), p.LicnoIme,
                    p.ImeRoditelja, p.Prezime, p.IzbornaLista, p.DatumRodj.ToShortDateString().ToString(), p.MestoRodj, p.Ulica + " " + p.Broj.ToString()
                    + " " + p.Mesto, p.BrTel, p.BrMobTel, p.BrRadneKnjizice.ToString(), p.Godine.ToString()
                    + "g " + p.Meseci.ToString() + "m " + p.Dani.ToString() + "d", p.ImePoslFirme});
                listaStalnoZaposleni.Items.Add(item);

            }

            listaStalnoZaposleni.Refresh();
        }
    }
}
