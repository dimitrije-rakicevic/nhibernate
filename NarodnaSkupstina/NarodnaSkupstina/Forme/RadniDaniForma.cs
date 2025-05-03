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
    public partial class RadniDaniForma : Form
    {
        int id;

        public RadniDaniForma(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void RadniDaniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<RadniDanPregled> podaci = DTOManager.vratiRadneDane(id);

            foreach(RadniDanPregled c in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.VremPeriodRadaOd.ToString(),
                    c.VremPeriodRadaDo.ToString(), c.BrojPrisutnih.ToString() });
                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void btnDodajDan_Click(object sender, EventArgs e)
        {
            DateTime vremeOd = DateTime.Parse(dtpOd.Text);
            DateTime vremeDo = DateTime.Parse(dtpDo.Text);
            int brojPrisutnih = int.Parse(tbxBrojPrisutnih.Text);
            RadniDanBasic c = new RadniDanBasic();
            c.VremPeriodRadaOd = vremeOd;
            c.VremPeriodRadaDo = vremeDo;
            c.BrojPrisutnih = brojPrisutnih;
            DTOManager.dodajRadniDan(c, id);

            ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.VremPeriodRadaOd.ToString(),
                    c.VremPeriodRadaDo.ToString(), c.BrojPrisutnih.ToString() });
            listView1.Items.Add(item);

            this.popuniPodacima();
        }
    }
}
