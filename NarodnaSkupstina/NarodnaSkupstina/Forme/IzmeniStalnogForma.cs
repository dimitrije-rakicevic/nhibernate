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
    public partial class IzmeniStalnogForma : Form
    {
        public StalniRadniOdnosBasic poslanik;

        public IzmeniStalnogForma()
        {
            InitializeComponent();
        }

        public IzmeniStalnogForma(StalniRadniOdnosBasic p)
        {
            InitializeComponent();
            this.poslanik = p;
        }

        private void IzmeniStalnogForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE POSLANIKA {poslanik.LicnoIme.ToUpper()} " + poslanik.Prezime.ToUpper();
        }

        public void popuniPodacima()
        {
            tbxJmbg.Text = this.poslanik.Jmbg.ToString();
            tbxIme.Text = this.poslanik.LicnoIme;
            tbxImeRoditelja.Text = this.poslanik.ImeRoditelja;
            tbxPrezime.Text = this.poslanik.Prezime;
            tbxIzbornaLista.Text = this.poslanik.IzbornaLista;
            dtpDatumRodj.Text = this.poslanik.DatumRodj.ToString();
            tbxMestoRodj.Text = this.poslanik.MestoRodj;
            tbxUlica.Text = this.poslanik.Ulica;
            tbxBroj.Text = this.poslanik.Broj.ToString();
            tbxMesto.Text = this.poslanik.Mesto;
            tbxBrojTel.Text = this.poslanik.BrTel;
            tbxBrojMob.Text = this.poslanik.BrMobTel;
            tbxBRK.Text = this.poslanik.BrRadneKnjizice.ToString();
            tbxGodine.Text = this.poslanik.Godine.ToString();
            tbxMeseci.Text = this.poslanik.Meseci.ToString();
            tbxDani.Text = this.poslanik.Dani.ToString();
            tbxImePoslFirme.Text = this.poslanik.ImePoslFirme;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene poslanika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.poslanik.Jmbg = Int64.Parse(tbxJmbg.Text);
                this.poslanik.LicnoIme = tbxIme.Text;
                this.poslanik.ImeRoditelja = tbxImeRoditelja.Text;
                this.poslanik.Prezime = tbxPrezime.Text;
                this.poslanik.IzbornaLista = tbxIzbornaLista.Text;
                this.poslanik.DatumRodj = DateTime.Parse(dtpDatumRodj.Text);
                this.poslanik.MestoRodj = tbxMestoRodj.Text;
                this.poslanik.Ulica = tbxUlica.Text;
                this.poslanik.Broj = int.Parse(tbxBroj.Text);
                this.poslanik.Mesto = tbxMesto.Text;
                this.poslanik.BrTel = tbxBrojTel.Text;
                this.poslanik.BrMobTel = tbxBrojMob.Text;
                this.poslanik.BrRadneKnjizice = int.Parse(tbxBRK.Text);
                this.poslanik.Godine = int.Parse(tbxGodine.Text);
                this.poslanik.Meseci = int.Parse(tbxMeseci.Text);
                this.poslanik.Dani = int.Parse(tbxDani.Text);
                this.poslanik.ImePoslFirme = tbxImePoslFirme.Text;

                DTOManager.IzmeniStalnogPoslanika(this.poslanik);
                MessageBox.Show("Azuriranje poslanika je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
