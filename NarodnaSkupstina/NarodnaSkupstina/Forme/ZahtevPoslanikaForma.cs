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
    public partial class ZahtevPoslanikaForma : Form
    {
        int idSednice;

        public ZahtevPoslanikaForma(int idSednice)
        {
            InitializeComponent();
            this.idSednice = idSednice;
        }

        private void ZahtevPoslanikaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<NarodniPoslanikPregled> poslanici;

            poslanici = DTOManager.vratiZahtevePoslanika(idSednice);

            foreach (NarodniPoslanikPregled c in poslanici)
            {
                ListViewItem item = new ListViewItem(new string[] { c.NarPosId.ToString(), c.Jmbg.ToString(), c.LicnoIme,
                c.ImeRoditelja, c.Prezime, c.IzbornaLista, c.DatumRodj.ToString(), c.MestoRodj, c.Ulica + " " + c.Broj.ToString()
                + " " + c.Mesto, c.BrTel, c.BrMobTel, c.StalniRadniOdnosFlag.ToString() });
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }
    }
}
