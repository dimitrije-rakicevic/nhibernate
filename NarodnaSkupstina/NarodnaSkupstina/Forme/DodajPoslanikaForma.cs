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
    public partial class DodajPoslanikaForma : Form
    {
        public NarodniPoslanikBasic poslanik;
        public StalniRadniOdnosBasic stalniPoslanik;

        public DodajPoslanikaForma()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSRD.Checked)
            {
                gbxSRD.Enabled = true;

            }
            else
            {
                gbxSRD.Enabled = false;
            }
        }

        private void btnDodajPoslanika_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog poslanika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (!cbxSRD.Checked)
                {
                    poslanik = new NarodniPoslanikBasic();

                    this.poslanik.Jmbg = Int64.Parse(tbxJmbg.Text);
                    this.poslanik.LicnoIme = tbxIme.Text;
                    this.poslanik.ImeRoditelja = tbxImeRoditelja.Text;
                    this.poslanik.Prezime = tbxPrezime.Text;
                    this.poslanik.IzbornaLista = tbxIzbornaLista.Text;
                    this.poslanik.DatumRodj = dtpDatumRodj.Value;
                    this.poslanik.MestoRodj = tbxMestoRodj.Text;
                    this.poslanik.Ulica = tbxUlica.Text;
                    this.poslanik.Broj = Int32.Parse(tbxBroj.Text);
                    this.poslanik.Mesto = tbxMesto.Text;
                    this.poslanik.BrTel = tbxBrojTel.Text;
                    this.poslanik.BrMobTel = tbxBrojMob.Text;
                    this.poslanik.StalniRadniOdnosFlag = 'N';

                    DTOManager.dodajPoslanika(this.poslanik);                    
                }
                else
                {
                    stalniPoslanik = new StalniRadniOdnosBasic();

                    this.stalniPoslanik.Jmbg = Int64.Parse(tbxJmbg.Text);
                    this.stalniPoslanik.LicnoIme = tbxIme.Text;
                    this.stalniPoslanik.ImeRoditelja = tbxImeRoditelja.Text;
                    this.stalniPoslanik.Prezime = tbxPrezime.Text;
                    this.stalniPoslanik.IzbornaLista = tbxIzbornaLista.Text;
                    this.stalniPoslanik.DatumRodj = dtpDatumRodj.Value;
                    this.stalniPoslanik.MestoRodj = tbxMestoRodj.Text;
                    this.stalniPoslanik.Ulica = tbxUlica.Text;
                    this.stalniPoslanik.Broj = Int32.Parse(tbxBroj.Text);
                    this.stalniPoslanik.Mesto = tbxMesto.Text;
                    this.stalniPoslanik.BrTel = tbxBrojTel.Text;
                    this.stalniPoslanik.BrMobTel = tbxBrojMob.Text;
                    this.stalniPoslanik.StalniRadniOdnosFlag = 'Y';
                    this.stalniPoslanik.BrRadneKnjizice = Int32.Parse(tbxBRK.Text);
                    this.stalniPoslanik.Godine = Int32.Parse(tbxGodine.Text);
                    this.stalniPoslanik.Meseci = Int32.Parse(tbxMeseci.Text);
                    this.stalniPoslanik.Dani = Int32.Parse(tbxDani.Text);
                    this.stalniPoslanik.ImePoslFirme = tbxImePoslFirme.Text;

                    DTOManager.dodajPoslanika(this.stalniPoslanik);
                }

                MessageBox.Show("Uspesno ste dodali novog poslanika!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
