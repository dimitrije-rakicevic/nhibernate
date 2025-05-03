namespace NarodnaSkupstina.Forme
{
    partial class SedniceForma
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
            this.btnDani = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVanredne = new System.Windows.Forms.Button();
            this.btnDodajVanrednu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDani
            // 
            this.btnDani.BackColor = System.Drawing.Color.Tomato;
            this.btnDani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDani.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDani.Location = new System.Drawing.Point(509, 12);
            this.btnDani.Name = "btnDani";
            this.btnDani.Size = new System.Drawing.Size(122, 78);
            this.btnDani.TabIndex = 3;
            this.btnDani.Text = "Prikazi radne dane za sednicu";
            this.btnDani.UseVisualStyleBackColor = false;
            this.btnDani.Click += new System.EventHandler(this.btnDani_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 426);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "BROJ SEDNICE";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BROJ SAZIVA";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DATUM POCETKA";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DATUM ZAVRSETKA";
            this.columnHeader5.Width = 146;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Tomato;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodaj.Location = new System.Drawing.Point(509, 360);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(122, 78);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj sednicu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVanredne
            // 
            this.btnVanredne.BackColor = System.Drawing.Color.Tomato;
            this.btnVanredne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVanredne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVanredne.Location = new System.Drawing.Point(509, 96);
            this.btnVanredne.Name = "btnVanredne";
            this.btnVanredne.Size = new System.Drawing.Size(122, 78);
            this.btnVanredne.TabIndex = 8;
            this.btnVanredne.Text = "Prikazi vanredne sednice";
            this.btnVanredne.UseVisualStyleBackColor = false;
            this.btnVanredne.Click += new System.EventHandler(this.btnVanredne_Click);
            // 
            // btnDodajVanrednu
            // 
            this.btnDodajVanrednu.BackColor = System.Drawing.Color.Tomato;
            this.btnDodajVanrednu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVanrednu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajVanrednu.Location = new System.Drawing.Point(509, 276);
            this.btnDodajVanrednu.Name = "btnDodajVanrednu";
            this.btnDodajVanrednu.Size = new System.Drawing.Size(122, 78);
            this.btnDodajVanrednu.TabIndex = 10;
            this.btnDodajVanrednu.Text = "Dodaj vanrednu sednicu";
            this.btnDodajVanrednu.UseVisualStyleBackColor = false;
            this.btnDodajVanrednu.Click += new System.EventHandler(this.btnDodajVanrednu_Click);
            // 
            // SedniceForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.btnDodajVanrednu);
            this.Controls.Add(this.btnVanredne);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDani);
            this.Name = "SedniceForma";
            this.Text = "SedniceForma";
            this.Load += new System.EventHandler(this.SedniceForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDani;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnVanredne;
        private System.Windows.Forms.Button btnDodajVanrednu;
    }
}