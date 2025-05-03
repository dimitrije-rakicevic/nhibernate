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
    public partial class SedniceForma : Form
    {
        public SedniceForma()
        {
            InitializeComponent();
        }

        private void SedniceForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<SednicaPregled> sednice = DTOManager.vratiSednice();

            foreach (SednicaPregled c in sednice)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.BrojSednice.ToString(),
                c.BrojSaziva.ToString(), c.DatumPocetka.ToString(), c.DatumZavrsetka.ToString()});
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnVanredne_Click(object sender, EventArgs e)
        {
            VanredneSedniceForma forma = new VanredneSedniceForma();
            forma.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajSednicuForma forma = new DodajSednicuForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnDani_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektuj sednicu cije radne dane zelis da vidis!");
                return;
            }

            int idSednice = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            RadniDaniForma forma = new RadniDaniForma(idSednice);
            forma.ShowDialog();
        }

        private void btnDodajVanrednu_Click(object sender, EventArgs e)
        {
            DodajVanrednuForma forma = new DodajVanrednuForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
