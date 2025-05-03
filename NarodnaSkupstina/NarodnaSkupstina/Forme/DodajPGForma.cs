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
    public partial class DodajPGForma : Form
    {
        PoslanickaGrupaBasic pg;

        public DodajPGForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu poslanicku grupu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            { 
                pg = new PoslanickaGrupaBasic();

                this.pg.JedinstvenoIme = tbxIme.Text;
                this.pg.Predsednik = DTOManager.postaviPredsednikaPG(int.Parse(tbxPredsednik.Text));
                this.pg.Zamenik = DTOManager.postaviZamenikaPG(int.Parse(tbxZamenik.Text));
                this.pg.Clanovi.Add(DTOManager.postaviZamenikaPG(int.Parse(tbxZamenik.Text)));
                this.pg.Clanovi.Add(DTOManager.postaviPredsednikaPG(int.Parse(tbxPredsednik.Text)));

                DTOManager.dodajPG(pg);

                MessageBox.Show("Uspesno ste dodali novu poslanicku grupu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
