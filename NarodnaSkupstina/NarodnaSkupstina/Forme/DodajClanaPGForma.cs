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
    public partial class DodajClanaPGForma : Form
    {
        int idPG;

        public DodajClanaPGForma(int idPG)
        {
            InitializeComponent();
            this.idPG = idPG;
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate clana u poslanicku grupu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int idNP = int.Parse(tbxJibnp.Text);

                DTOManager.dodajClanaPG(idNP, idPG);

                MessageBox.Show("Uspesno ste dodali clana u poslanicku grupu!");
                this.Close();
            }
        }

    }
}
