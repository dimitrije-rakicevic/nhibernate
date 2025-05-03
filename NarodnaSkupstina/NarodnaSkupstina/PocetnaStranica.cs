using NarodnaSkupstina.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstina
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnPoslanici_Click(object sender, EventArgs e)
        {
            NarodniPoslaniciForma forma = new NarodniPoslaniciForma();
            forma.ShowDialog();
        }

        private void btnPoslanickeGrupe_Click(object sender, EventArgs e)
        {
            PoslanickeGrupeForma forma = new PoslanickeGrupeForma();
            forma.ShowDialog();
        }

        private void btnRadnaTela_Click(object sender, EventArgs e)
        {
            RadnaTelaForma forma = new RadnaTelaForma();
            forma.ShowDialog();
        }

        private void btnSednice_Click(object sender, EventArgs e)
        {
            SedniceForma forma = new SedniceForma();
            forma.ShowDialog();
        }

        private void btnPravniAkti_Click(object sender, EventArgs e)
        {
            PravniAktiForma forma = new PravniAktiForma();
            forma.ShowDialog();
        }
    }
}
