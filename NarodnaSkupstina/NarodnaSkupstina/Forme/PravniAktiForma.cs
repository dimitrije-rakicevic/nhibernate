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
    public partial class PravniAktiForma : Form
    {
        private ListViewGroup vladaGroup = new ListViewGroup("Predlog vlade", HorizontalAlignment.Left);
        private ListViewGroup biraciGroup = new ListViewGroup("Predlog biraca", HorizontalAlignment.Left);
        private ListViewGroup poslaniciGroup = new ListViewGroup("Predlog poslanika", HorizontalAlignment.Left);

        public PravniAktiForma()
        {
            InitializeComponent();
        }

        private void PravniAktiForma_Load(object sender, EventArgs e)
        {
            listView1.Groups.Add(vladaGroup);
            listView1.Groups.Add(biraciGroup);
            listView1.Groups.Add(poslaniciGroup);
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<PredlogVladePregled> vlada = DTOManager.vratiPredlogeVlade();
            List<PredlogBiracaPregled> biraci = DTOManager.vratiPredlogeBiraca();
            List<PredlogPoslanikaPregled> poslanici = DTOManager.vratiPredlogePoslanika();

            foreach (PredlogVladePregled c in vlada)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.TipPravnogAkta, null }, vladaGroup);
                listView1.Items.Add(item);
            }

            foreach (PredlogBiracaPregled c in biraci)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.TipPravnogAkta, c.BrojBiraca.ToString() }, biraciGroup);
                listView1.Items.Add(item);
            }

            foreach (PredlogPoslanikaPregled c in poslanici)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.TipPravnogAkta, null }, poslaniciGroup);
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnPredlagaci_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberi pravni akt da vidis predlagace!");
                return;
            }

            //int idPA = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            if (listView1.SelectedItems[0].Group == poslaniciGroup)
            {
                List<NarodniPoslanikPregled> podaci = DTOManager.vratiPredlagace
                    (int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                foreach (NarodniPoslanikPregled p in podaci)
                    MessageBox.Show(p.NarPosId + " " + p.LicnoIme + " " + p.Prezime);
            }
            else if(listView1.SelectedItems[0].Group == biraciGroup)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[2].Text + " biraca!");
            }
            else
            {
                MessageBox.Show("Vlada!");
            }
        }
    }
}
