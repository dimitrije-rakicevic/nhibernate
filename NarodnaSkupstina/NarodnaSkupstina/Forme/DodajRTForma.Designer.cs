namespace NarodnaSkupstina.Forme
{
    partial class DodajRTForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTip = new System.Windows.Forms.TextBox();
            this.tbxPredsednik = new System.Windows.Forms.TextBox();
            this.tbxZamenik = new System.Windows.Forms.TextBox();
            this.tbxProstorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip radnog tela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jibnp predsednika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jibnp zamenika";
            // 
            // tbxTip
            // 
            this.tbxTip.Location = new System.Drawing.Point(111, 6);
            this.tbxTip.Name = "tbxTip";
            this.tbxTip.Size = new System.Drawing.Size(100, 20);
            this.tbxTip.TabIndex = 3;
            // 
            // tbxPredsednik
            // 
            this.tbxPredsednik.Location = new System.Drawing.Point(111, 32);
            this.tbxPredsednik.Name = "tbxPredsednik";
            this.tbxPredsednik.Size = new System.Drawing.Size(100, 20);
            this.tbxPredsednik.TabIndex = 4;
            // 
            // tbxZamenik
            // 
            this.tbxZamenik.Location = new System.Drawing.Point(111, 58);
            this.tbxZamenik.Name = "tbxZamenik";
            this.tbxZamenik.Size = new System.Drawing.Size(100, 20);
            this.tbxZamenik.TabIndex = 5;
            // 
            // tbxProstorija
            // 
            this.tbxProstorija.Location = new System.Drawing.Point(111, 84);
            this.tbxProstorija.Name = "tbxProstorija";
            this.tbxProstorija.Size = new System.Drawing.Size(100, 20);
            this.tbxProstorija.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj prostorije";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Tomato;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodaj.Location = new System.Drawing.Point(235, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 78);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajRTForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(351, 121);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxProstorija);
            this.Controls.Add(this.tbxZamenik);
            this.Controls.Add(this.tbxPredsednik);
            this.Controls.Add(this.tbxTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DodajRTForma";
            this.Text = "DodajRTForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTip;
        private System.Windows.Forms.TextBox tbxPredsednik;
        private System.Windows.Forms.TextBox tbxZamenik;
        private System.Windows.Forms.TextBox tbxProstorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
    }
}