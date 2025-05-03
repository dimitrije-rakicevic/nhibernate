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
    public partial class DodajClanaRTForma : Form
    {
        int idRT;

        public DodajClanaRTForma(int idRT)
        {
            InitializeComponent();
            this.idRT = idRT;
        }

        private void btnDodajClana_Click_1(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate clana u radno telo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int idNP = int.Parse(tbxJibnp.Text);

                DTOManager.dodajClanaRT(idNP, idRT);

                MessageBox.Show("Uspesno ste dodali clana u radno telo!");
                this.Close();
            }
        }
    }
}
