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
    public partial class PoslanickeGrupeForma : Form
    {
        public PoslanickeGrupeForma()
        {
            InitializeComponent();
        }

        private void PoslanickeGrupeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            List<PoslanickaGrupaPregled> podaci = DTOManager.vratiSvePG();

            foreach (PoslanickaGrupaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.JedinstvenoIme }); ;
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPGForma forma = new DodajPGForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnPrikaziClanove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte poslanicku grupu cije clanove zelite da vidite!");
                return;
            }

            int idPG = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            ClanoviPGForma forma = new ClanoviPGForma(idPG);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte poslanicku grupu koju zelite da obrisete!");
                return;
            }

            int idPG = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete ovu poslanicku grupu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPG(idPG);
                MessageBox.Show("Brisanje poslanicke grupe je uspesno obavljeno!");
                this.popuniPodacima();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte poslanicku grupu cije prostorije zelite da vidite!");
                return;
            }

            int idPG = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            List<ProstorijaPregled> podaci = new List<ProstorijaPregled>();

            podaci = DTOManager.vratiProstorije(idPG);

            foreach(ProstorijaPregled p in podaci)
            {
                MessageBox.Show("BROJ PROSTORIJE: " + p.Id + ", SPRAT: " + p.Sprat);
            }
        }
    }
}
