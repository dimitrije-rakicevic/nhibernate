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
    public partial class DodajRTForma : Form
    {
        RadnoTeloBasic rt;

        public DodajRTForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo radno telo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                rt = new RadnoTeloBasic();

                this.rt.TipRadnogTela = tbxTip.Text;
                this.rt.Predsednik = DTOManager.postaviPredsednikaRT(int.Parse(tbxPredsednik.Text));
                this.rt.Zamenik = DTOManager.postaviZamenikaRT(int.Parse(tbxZamenik.Text));
                this.rt.Clanovi.Add(DTOManager.postaviZamenikaRT(int.Parse(tbxZamenik.Text)));
                this.rt.Clanovi.Add(DTOManager.postaviPredsednikaRT(int.Parse(tbxPredsednik.Text)));
                this.rt.Prostorija = DTOManager.vratiProstoriju(int.Parse(tbxProstorija.Text));

                DTOManager.dodajRT(rt);

                MessageBox.Show("Uspesno ste dodali novo radno telo!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
