namespace NarodnaSkupstina.Forme
{
    partial class StalniRadniOdnosForma
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
            this.listaStalnoZaposleni = new System.Windows.Forms.ListView();
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
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaStalnoZaposleni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista poslanika sa stalnim radnim odnosom";
            // 
            // listaStalnoZaposleni
            // 
            this.listaStalnoZaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listaStalnoZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaStalnoZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaStalnoZaposleni.FullRowSelect = true;
            this.listaStalnoZaposleni.GridLines = true;
            this.listaStalnoZaposleni.HideSelection = false;
            this.listaStalnoZaposleni.Location = new System.Drawing.Point(3, 16);
            this.listaStalnoZaposleni.Name = "listaStalnoZaposleni";
            this.listaStalnoZaposleni.Size = new System.Drawing.Size(956, 483);
            this.listaStalnoZaposleni.TabIndex = 4;
            this.listaStalnoZaposleni.UseCompatibleStateImageBehavior = false;
            this.listaStalnoZaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JIBNP";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JMBG";
            this.columnHeader2.Width = 51;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LICNO IME";
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
            this.columnHeader7.Text = "DATUM RODJENJA";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MESTO RODJENJA";
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
            this.columnHeader12.Text = "BROJ RADNE KNJIZICE";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "GODINE, MESECI, DANI";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "IME POSLEDNJE FIRME";
            // 
            // StalniRadniOdnosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(987, 527);
            this.Controls.Add(this.groupBox1);
            this.Name = "StalniRadniOdnosForma";
            this.Text = "StalniRadniOdnosForma";
            this.Load += new System.EventHandler(this.StalniRadniOdnosForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaStalnoZaposleni;
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
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}