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
    public partial class RadnaTelaForma : Form
    {
        public RadnaTelaForma()
        {
            InitializeComponent();
        }

        private void RadnaTelaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            List<RadnoTeloPregled> podaci = DTOManager.vratiSvaRadnaTela();

            foreach (RadnoTeloPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipRadnogTela, p.BrojProstorije.ToString() });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRTForma forma = new DodajRTForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte radno telo koje zelite da obrisete!");
                return;
            }

            int idRT = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete ovo radno telo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRT(idRT);
                MessageBox.Show("Brisanje poslanicke grupe je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnPrikaziClanove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte radno telo cije clanove zelite da vidite!");
                return;
            }

            int idPG = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            ClanoviRTForma forma = new ClanoviRTForma(idPG);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
