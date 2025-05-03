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
    public partial class ClanoviPGForma : Form
    {
        private ListViewGroup predsednikGroup = new ListViewGroup("Predsednik", HorizontalAlignment.Left);
        private ListViewGroup zamenikGroup = new ListViewGroup("Zamenik", HorizontalAlignment.Left);
        private ListViewGroup clanoviGroup = new ListViewGroup("Clanovi", HorizontalAlignment.Left);

        int idPG;

        public ClanoviPGForma()
        {
            InitializeComponent();
        }

        public ClanoviPGForma(int idPG)
        {
            InitializeComponent();
            this.idPG = idPG;
        }

        private void ClanoviPGForma_Load(object sender, EventArgs e)
        {
            listaClanova.Groups.Add(predsednikGroup);
            listaClanova.Groups.Add(zamenikGroup);
            listaClanova.Groups.Add(clanoviGroup);
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaClanova.Items.Clear();

            List<NarodniPoslanikPregled> clanovi = DTOManager.vratiClanovePG(idPG);
            NarodniPoslanikPregled p = DTOManager.vratiPredsednikaPG(idPG);
            NarodniPoslanikPregled z = DTOManager.vratiZamenikaPG(idPG);

            ListViewItem itemP = new ListViewItem(new string[] { p.NarPosId.ToString(), p.Jmbg.ToString(), p.LicnoIme,
                p.ImeRoditelja, p.Prezime, p.IzbornaLista, p.DatumRodj.ToString(), p.MestoRodj, p.Ulica + " " + p.Broj.ToString()
                + " " + p.Mesto, p.BrTel, p.BrMobTel, p.StalniRadniOdnosFlag.ToString() }, predsednikGroup);
            listaClanova.Items.Add(itemP);

            ListViewItem itemZ = new ListViewItem(new string[] { z.NarPosId.ToString(), z.Jmbg.ToString(), z.LicnoIme,
                z.ImeRoditelja, z.Prezime, z.IzbornaLista, z.DatumRodj.ToString(), z.MestoRodj, z.Ulica + " " + z.Broj.ToString()
                + " " + z.Mesto, z.BrTel, z.BrMobTel, z.StalniRadniOdnosFlag.ToString() }, zamenikGroup);
            listaClanova.Items.Add(itemZ);

            foreach (NarodniPoslanikPregled c in clanovi)
            {
                ListViewItem itemC = new ListViewItem(new string[] { c.NarPosId.ToString(), c.Jmbg.ToString(), c.LicnoIme,
                c.ImeRoditelja, c.Prezime, c.IzbornaLista, c.DatumRodj.ToString(), c.MestoRodj, c.Ulica + " " + c.Broj.ToString()
                + " " + c.Mesto, c.BrTel, c.BrMobTel, c.StalniRadniOdnosFlag.ToString() }, clanoviGroup);
                listaClanova.Items.Add(itemC);
            }

            listaClanova.Refresh();
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            DodajClanaPGForma forma = new DodajClanaPGForma(idPG);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            if (listaClanova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte clana kojeg zelite da obrisete!");
                return;
            }

            int idClanaPG = Int32.Parse(listaClanova.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete ovog clana?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiClanaPG(idClanaPG);
                MessageBox.Show("Brisanje poslanicke grupe je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
