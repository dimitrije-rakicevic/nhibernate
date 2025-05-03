namespace NarodnaSkupstina
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSednice = new System.Windows.Forms.Button();
            this.btnRadnaTela = new System.Windows.Forms.Button();
            this.btnPoslanickeGrupe = new System.Windows.Forms.Button();
            this.btnPoslanici = new System.Windows.Forms.Button();
            this.btnPravniAkti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::NarodnaSkupstina.Properties.Resources.narskup;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // btnSednice
            // 
            resources.ApplyResources(this.btnSednice, "btnSednice");
            this.btnSednice.BackColor = System.Drawing.Color.Tomato;
            this.btnSednice.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSednice.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSednice.Name = "btnSednice";
            this.btnSednice.UseVisualStyleBackColor = false;
            this.btnSednice.Click += new System.EventHandler(this.btnSednice_Click);
            // 
            // btnRadnaTela
            // 
            resources.ApplyResources(this.btnRadnaTela, "btnRadnaTela");
            this.btnRadnaTela.BackColor = System.Drawing.Color.Tomato;
            this.btnRadnaTela.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRadnaTela.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRadnaTela.Name = "btnRadnaTela";
            this.btnRadnaTela.UseVisualStyleBackColor = false;
            this.btnRadnaTela.Click += new System.EventHandler(this.btnRadnaTela_Click);
            // 
            // btnPoslanickeGrupe
            // 
            resources.ApplyResources(this.btnPoslanickeGrupe, "btnPoslanickeGrupe");
            this.btnPoslanickeGrupe.BackColor = System.Drawing.Color.Tomato;
            this.btnPoslanickeGrupe.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPoslanickeGrupe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPoslanickeGrupe.Name = "btnPoslanickeGrupe";
            this.btnPoslanickeGrupe.UseVisualStyleBackColor = false;
            this.btnPoslanickeGrupe.Click += new System.EventHandler(this.btnPoslanickeGrupe_Click);
            // 
            // btnPoslanici
            // 
            resources.ApplyResources(this.btnPoslanici, "btnPoslanici");
            this.btnPoslanici.BackColor = System.Drawing.Color.Tomato;
            this.btnPoslanici.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPoslanici.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPoslanici.Name = "btnPoslanici";
            this.btnPoslanici.UseVisualStyleBackColor = false;
            this.btnPoslanici.Click += new System.EventHandler(this.btnPoslanici_Click);
            // 
            // btnPravniAkti
            // 
            resources.ApplyResources(this.btnPravniAkti, "btnPravniAkti");
            this.btnPravniAkti.BackColor = System.Drawing.Color.Tomato;
            this.btnPravniAkti.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPravniAkti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPravniAkti.Name = "btnPravniAkti";
            this.btnPravniAkti.UseVisualStyleBackColor = false;
            this.btnPravniAkti.Click += new System.EventHandler(this.btnPravniAkti_Click);
            // 
            // PocetnaStranica
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.btnPravniAkti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSednice);
            this.Controls.Add(this.btnRadnaTela);
            this.Controls.Add(this.btnPoslanickeGrupe);
            this.Controls.Add(this.btnPoslanici);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "PocetnaStranica";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSednice;
        private System.Windows.Forms.Button btnRadnaTela;
        private System.Windows.Forms.Button btnPoslanickeGrupe;
        private System.Windows.Forms.Button btnPoslanici;
        private System.Windows.Forms.Button btnPravniAkti;
    }
}