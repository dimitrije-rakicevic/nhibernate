namespace NarodnaSkupstina.Forme
{
    partial class DodajClanaRTForma
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
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxJibnp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.BackColor = System.Drawing.Color.Tomato;
            this.btnDodajClana.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDodajClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajClana.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajClana.Location = new System.Drawing.Point(29, 51);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(134, 61);
            this.btnDodajClana.TabIndex = 10;
            this.btnDodajClana.Text = "Dodaj clana";
            this.btnDodajClana.UseVisualStyleBackColor = false;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "JIBNP clana kojeg zelite da dodate";
            // 
            // tbxJibnp
            // 
            this.tbxJibnp.Location = new System.Drawing.Point(45, 25);
            this.tbxJibnp.Name = "tbxJibnp";
            this.tbxJibnp.Size = new System.Drawing.Size(100, 20);
            this.tbxJibnp.TabIndex = 8;
            // 
            // DodajClanaRTForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(196, 132);
            this.Controls.Add(this.btnDodajClana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxJibnp);
            this.Name = "DodajClanaRTForma";
            this.Text = "DodajClanaRTForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxJibnp;
    }
}