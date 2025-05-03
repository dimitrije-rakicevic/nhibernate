namespace NarodnaSkupstina.Forme
{
    partial class ClanoviRTForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaClanova = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaClanova);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 440);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista clanova";
            // 
            // listaClanova
            // 
            this.listaClanova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listaClanova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaClanova.FullRowSelect = true;
            this.listaClanova.GridLines = true;
            this.listaClanova.HideSelection = false;
            this.listaClanova.Location = new System.Drawing.Point(3, 16);
            this.listaClanova.Name = "listaClanova";
            this.listaClanova.Size = new System.Drawing.Size(770, 421);
            this.listaClanova.TabIndex = 5;
            this.listaClanova.UseCompatibleStateImageBehavior = false;
            this.listaClanova.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JIBNP";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JMBG";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IME";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IME RODITELJA";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PREZIME";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IZBORNA LISTA";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DATUM RODJ";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MESTO RODJ";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ADRESA";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "BROJ TELEFONA";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "BROJ MOBILNOG";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "STALNI RADNI ODNOS";
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.BackColor = System.Drawing.Color.Tomato;
            this.btnDodajClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajClana.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajClana.Location = new System.Drawing.Point(794, 290);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(134, 78);
            this.btnDodajClana.TabIndex = 11;
            this.btnDodajClana.Text = "Dodaj clana";
            this.btnDodajClana.UseVisualStyleBackColor = false;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.BackColor = System.Drawing.Color.Tomato;
            this.btnObrisiClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClana.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObrisiClana.Location = new System.Drawing.Point(794, 374);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(134, 78);
            this.btnObrisiClana.TabIndex = 10;
            this.btnObrisiClana.Text = "Obrisi clana";
            this.btnObrisiClana.UseVisualStyleBackColor = false;
            this.btnObrisiClana.Click += new System.EventHandler(this.btnObrisiClana_Click);
            // 
            // ClanoviRTForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(940, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajClana);
            this.Controls.Add(this.btnObrisiClana);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ClanoviRTForma";
            this.Text = "ClanoviRTForma";
            this.Load += new System.EventHandler(this.ClanoviRTForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaClanova;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Button btnObrisiClana;
    }
}