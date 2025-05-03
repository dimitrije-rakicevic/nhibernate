namespace NarodnaSkupstina.Forme
{
    public partial class NarodniPoslaniciForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaPoslanika = new System.Windows.Forms.ListView();
            this.columnJibnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLicnoIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImeRoditelja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIzbornaLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumRodj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMestoRodj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrMobTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStalRadOdnos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStalniRadniOdnos = new System.Windows.Forms.Button();
            this.btnObrisiPoslanika = new System.Windows.Forms.Button();
            this.btnIzmeniPoslanika = new System.Windows.Forms.Button();
            this.btnDodajPoslanika = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaPoslanika
            // 
            this.listaPoslanika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnJibnp,
            this.columnJmbg,
            this.columnLicnoIme,
            this.columnImeRoditelja,
            this.columnPrezime,
            this.columnIzbornaLista,
            this.columnDatumRodj,
            this.columnMestoRodj,
            this.columnAdresa,
            this.columnBrTel,
            this.columnBrMobTel,
            this.columnStalRadOdnos});
            this.listaPoslanika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPoslanika.FullRowSelect = true;
            this.listaPoslanika.GridLines = true;
            this.listaPoslanika.HideSelection = false;
            this.listaPoslanika.Location = new System.Drawing.Point(3, 16);
            this.listaPoslanika.Name = "listaPoslanika";
            this.listaPoslanika.Size = new System.Drawing.Size(913, 442);
            this.listaPoslanika.TabIndex = 4;
            this.listaPoslanika.UseCompatibleStateImageBehavior = false;
            this.listaPoslanika.View = System.Windows.Forms.View.Details;
            // 
            // columnJibnp
            // 
            this.columnJibnp.Text = "JIBNP";
            // 
            // columnJmbg
            // 
            this.columnJmbg.Text = "JMBG";
            this.columnJmbg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJmbg.Width = 64;
            // 
            // columnLicnoIme
            // 
            this.columnLicnoIme.Text = "LICNO IME";
            this.columnLicnoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLicnoIme.Width = 72;
            // 
            // columnImeRoditelja
            // 
            this.columnImeRoditelja.Text = "IME RODITELJA";
            this.columnImeRoditelja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnImeRoditelja.Width = 94;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "PREZIME";
            this.columnPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnIzbornaLista
            // 
            this.columnIzbornaLista.Text = "IZBORNA LISTA";
            this.columnIzbornaLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnIzbornaLista.Width = 103;
            // 
            // columnDatumRodj
            // 
            this.columnDatumRodj.Text = "DATUM RODJENJA";
            this.columnDatumRodj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDatumRodj.Width = 112;
            // 
            // columnMestoRodj
            // 
            this.columnMestoRodj.Text = "MESTO RODJENJA";
            this.columnMestoRodj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMestoRodj.Width = 114;
            // 
            // columnAdresa
            // 
            this.columnAdresa.Text = "ADRESA";
            this.columnAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAdresa.Width = 106;
            // 
            // columnBrTel
            // 
            this.columnBrTel.Text = "BROJ TELEFONA";
            this.columnBrTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBrTel.Width = 99;
            // 
            // columnBrMobTel
            // 
            this.columnBrMobTel.Text = "BROJ MOBILNOG";
            this.columnBrMobTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBrMobTel.Width = 103;
            // 
            // columnStalRadOdnos
            // 
            this.columnStalRadOdnos.Text = "STALNI RADNI ODNOS";
            this.columnStalRadOdnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStalRadOdnos.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaPoslanika);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista poslanika";
            // 
            // btnStalniRadniOdnos
            // 
            this.btnStalniRadniOdnos.BackColor = System.Drawing.Color.Tomato;
            this.btnStalniRadniOdnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStalniRadniOdnos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStalniRadniOdnos.Location = new System.Drawing.Point(939, 28);
            this.btnStalniRadniOdnos.Name = "btnStalniRadniOdnos";
            this.btnStalniRadniOdnos.Size = new System.Drawing.Size(139, 78);
            this.btnStalniRadniOdnos.TabIndex = 2;
            this.btnStalniRadniOdnos.Text = "Poslanici sa stalnim radnim odnosom";
            this.btnStalniRadniOdnos.UseVisualStyleBackColor = false;
            this.btnStalniRadniOdnos.Click += new System.EventHandler(this.btnStalniRadniOdnos_Click);
            // 
            // btnObrisiPoslanika
            // 
            this.btnObrisiPoslanika.BackColor = System.Drawing.Color.Tomato;
            this.btnObrisiPoslanika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPoslanika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObrisiPoslanika.Location = new System.Drawing.Point(939, 395);
            this.btnObrisiPoslanika.Name = "btnObrisiPoslanika";
            this.btnObrisiPoslanika.Size = new System.Drawing.Size(139, 78);
            this.btnObrisiPoslanika.TabIndex = 3;
            this.btnObrisiPoslanika.Text = "Obrisi poslanika";
            this.btnObrisiPoslanika.UseVisualStyleBackColor = false;
            this.btnObrisiPoslanika.Click += new System.EventHandler(this.btnObrisiPoslanika_Click);
            // 
            // btnIzmeniPoslanika
            // 
            this.btnIzmeniPoslanika.BackColor = System.Drawing.Color.Tomato;
            this.btnIzmeniPoslanika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPoslanika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzmeniPoslanika.Location = new System.Drawing.Point(939, 311);
            this.btnIzmeniPoslanika.Name = "btnIzmeniPoslanika";
            this.btnIzmeniPoslanika.Size = new System.Drawing.Size(140, 78);
            this.btnIzmeniPoslanika.TabIndex = 4;
            this.btnIzmeniPoslanika.Text = "Izmeni poslanika";
            this.btnIzmeniPoslanika.UseVisualStyleBackColor = false;
            this.btnIzmeniPoslanika.Click += new System.EventHandler(this.btnIzmeniPoslanika_Click);
            // 
            // btnDodajPoslanika
            // 
            this.btnDodajPoslanika.BackColor = System.Drawing.Color.Tomato;
            this.btnDodajPoslanika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPoslanika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajPoslanika.Location = new System.Drawing.Point(939, 227);
            this.btnDodajPoslanika.Name = "btnDodajPoslanika";
            this.btnDodajPoslanika.Size = new System.Drawing.Size(140, 78);
            this.btnDodajPoslanika.TabIndex = 5;
            this.btnDodajPoslanika.Text = "Dodaj poslanika";
            this.btnDodajPoslanika.UseVisualStyleBackColor = false;
            this.btnDodajPoslanika.Click += new System.EventHandler(this.btnDodajPoslanika_Click);
            // 
            // NarodniPoslaniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1088, 485);
            this.Controls.Add(this.btnDodajPoslanika);
            this.Controls.Add(this.btnIzmeniPoslanika);
            this.Controls.Add(this.btnObrisiPoslanika);
            this.Controls.Add(this.btnStalniRadniOdnos);
            this.Controls.Add(this.groupBox1);
            this.Name = "NarodniPoslaniciForma";
            this.Text = "NarodniPoslaniciForma";
            this.Load += new System.EventHandler(this.NarodniPoslaniciForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaPoslanika;
        private System.Windows.Forms.ColumnHeader columnJibnp;
        private System.Windows.Forms.ColumnHeader columnJmbg;
        private System.Windows.Forms.ColumnHeader columnLicnoIme;
        private System.Windows.Forms.ColumnHeader columnImeRoditelja;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnIzbornaLista;
        private System.Windows.Forms.ColumnHeader columnDatumRodj;
        private System.Windows.Forms.ColumnHeader columnMestoRodj;
        private System.Windows.Forms.ColumnHeader columnAdresa;
        private System.Windows.Forms.ColumnHeader columnBrTel;
        private System.Windows.Forms.ColumnHeader columnBrMobTel;
        private System.Windows.Forms.ColumnHeader columnStalRadOdnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStalniRadniOdnos;
        private System.Windows.Forms.Button btnObrisiPoslanika;
        private System.Windows.Forms.Button btnIzmeniPoslanika;
        private System.Windows.Forms.Button btnDodajPoslanika;
    }
}