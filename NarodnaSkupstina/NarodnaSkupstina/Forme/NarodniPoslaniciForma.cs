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
    public partial class NarodniPoslaniciForma : Form
    {
        public NarodniPoslaniciForma()
        {
            InitializeComponent();
        }

        private void NarodniPoslaniciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaPoslanika.Items.Clear();
            List<NarodniPoslanikPregled> podaci = DTOManager.vratiSvePoslanike();

            foreach (NarodniPoslanikPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.NarPosId.ToString(), p.Jmbg.ToString(), p.LicnoIme,
                    p.ImeRoditelja, p.Prezime, p.IzbornaLista, p.DatumRodj.ToString(), p.MestoRodj, p.Ulica + " " + p.Broj.ToString()
                    + " " + p.Mesto, p.BrTel, p.BrMobTel, p.StalniRadniOdnosFlag.ToString() });
                listaPoslanika.Items.Add(item);

            }

            listaPoslanika.Refresh();
        }

        private void btnStalniRadniOdnos_Click(object sender, EventArgs e)
        {
            StalniRadniOdnosForma forma = new StalniRadniOdnosForma();
            forma.ShowDialog();
        }

        private void btnDodajPoslanika_Click(object sender, EventArgs e)
        {
            DodajPoslanikaForma formaDodaj = new DodajPoslanikaForma();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniPoslanika_Click(object sender, EventArgs e)
        {
            if (listaPoslanika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite poslanika cije podatke zelite da izmenite!");
                return;
            }

            int idPoslanika = Int32.Parse(listaPoslanika.SelectedItems[0].SubItems[0].Text);
            char stalniRadniOdnos = char.Parse(listaPoslanika.SelectedItems[0].SubItems[11].Text);      

            if (stalniRadniOdnos == 'Y')
            {
                StalniRadniOdnosBasic ob = DTOManager.vratiStalnogPoslanika(idPoslanika);
                IzmeniStalnogForma formaUpdate = new IzmeniStalnogForma(ob);
                formaUpdate.ShowDialog();
            }
            else
            {
                NarodniPoslanikBasic ob = DTOManager.vratiPoslanika(idPoslanika);
                IzmeniPoslanikaForma formaUpdate = new IzmeniPoslanikaForma(ob);
                formaUpdate.ShowDialog();
            }
            this.popuniPodacima();
        }

        private void btnObrisiPoslanika_Click(object sender, EventArgs e)
        {
            if (listaPoslanika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite poslanika kojeg zelite da obrisete!");
                return;
            }

            int idPoslanika = Int32.Parse(listaPoslanika.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete ovog poslanika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPoslanika(idPoslanika);
                MessageBox.Show("Brisanje poslanika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
