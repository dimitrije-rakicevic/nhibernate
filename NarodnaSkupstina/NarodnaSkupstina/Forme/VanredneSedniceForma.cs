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
    public partial class VanredneSedniceForma : Form
    {
        public VanredneSedniceForma()
        {
            InitializeComponent();
        }

        private void VanredneSedniceForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<VanrednaSednicaPregled> sednice = DTOManager.vratiVanredne();

            foreach (VanrednaSednicaPregled c in sednice)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.BrojSednice.ToString(),
                c.BrojSaziva.ToString(), c.DatumPocetka.ToString(), c.DatumZavrsetka.ToString(), c.Inicijator});
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnZahtevi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte sednicu cije zahteve zelite da vidite!");
                return;
            }

            string inicijator = listView1.SelectedItems[0].SubItems[5].Text;

            if(inicijator == "VLADA")
            {
                MessageBox.Show(inicijator);
            }
            else
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                ZahtevPoslanikaForma forma = new ZahtevPoslanikaForma(id);
                forma.ShowDialog();
            }
        }
    }
}
