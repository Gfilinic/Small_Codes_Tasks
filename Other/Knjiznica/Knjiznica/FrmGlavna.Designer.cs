namespace Knjiznica
{
    partial class FrmGlavna
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
            this.tbxImeAutora = new System.Windows.Forms.TextBox();
            this.lblImeAutora = new System.Windows.Forms.Label();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnDodajAutora = new System.Windows.Forms.Button();
            this.lblPotraziKnjigu = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.tbxPretraga = new System.Windows.Forms.TextBox();
            this.tbxPrezimeAutora = new System.Windows.Forms.TextBox();
            this.tbxGodinaKnjige = new System.Windows.Forms.TextBox();
            this.tbxNazivKnjige = new System.Windows.Forms.TextBox();
            this.lstbKnjige = new System.Windows.Forms.ListBox();
            this.lstbAutori = new System.Windows.Forms.ListBox();
            this.lblNazivKnjige = new System.Windows.Forms.Label();
            this.lblGodinaKnjige = new System.Windows.Forms.Label();
            this.lblPrezimeAutora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxImeAutora
            // 
            this.tbxImeAutora.Location = new System.Drawing.Point(310, 67);
            this.tbxImeAutora.Multiline = true;
            this.tbxImeAutora.Name = "tbxImeAutora";
            this.tbxImeAutora.Size = new System.Drawing.Size(118, 28);
            this.tbxImeAutora.TabIndex = 2;
            // 
            // lblImeAutora
            // 
            this.lblImeAutora.AutoSize = true;
            this.lblImeAutora.Location = new System.Drawing.Point(309, 51);
            this.lblImeAutora.Name = "lblImeAutora";
            this.lblImeAutora.Size = new System.Drawing.Size(24, 13);
            this.lblImeAutora.TabIndex = 5;
            this.lblImeAutora.Text = "Ime";
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(32, 101);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(246, 34);
            this.btnDodajKnjigu.TabIndex = 6;
            this.btnDodajKnjigu.Text = "Unesi knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.DodajKnjigu_Click);
            // 
            // btnDodajAutora
            // 
            this.btnDodajAutora.Location = new System.Drawing.Point(309, 101);
            this.btnDodajAutora.Name = "btnDodajAutora";
            this.btnDodajAutora.Size = new System.Drawing.Size(246, 34);
            this.btnDodajAutora.TabIndex = 7;
            this.btnDodajAutora.Text = "Dodaj autora";
            this.btnDodajAutora.UseVisualStyleBackColor = true;
            this.btnDodajAutora.Click += new System.EventHandler(this.DodajAutora_Click);
            // 
            // lblPotraziKnjigu
            // 
            this.lblPotraziKnjigu.AutoSize = true;
            this.lblPotraziKnjigu.Location = new System.Drawing.Point(32, 315);
            this.lblPotraziKnjigu.Name = "lblPotraziKnjigu";
            this.lblPotraziKnjigu.Size = new System.Drawing.Size(73, 13);
            this.lblPotraziKnjigu.TabIndex = 9;
            this.lblPotraziKnjigu.Text = "Potraži knjigu;";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(308, 338);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(247, 28);
            this.btnPretraga.TabIndex = 12;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(32, 383);
            this.txtRezultat.Multiline = true;
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(522, 54);
            this.txtRezultat.TabIndex = 13;
            this.txtRezultat.Text = "Rezultati pretrage";
            // 
            // tbxPretraga
            // 
            this.tbxPretraga.Location = new System.Drawing.Point(35, 338);
            this.tbxPretraga.Multiline = true;
            this.tbxPretraga.Name = "tbxPretraga";
            this.tbxPretraga.Size = new System.Drawing.Size(243, 28);
            this.tbxPretraga.TabIndex = 14;
            // 
            // tbxPrezimeAutora
            // 
            this.tbxPrezimeAutora.Location = new System.Drawing.Point(434, 67);
            this.tbxPrezimeAutora.Multiline = true;
            this.tbxPrezimeAutora.Name = "tbxPrezimeAutora";
            this.tbxPrezimeAutora.Size = new System.Drawing.Size(121, 28);
            this.tbxPrezimeAutora.TabIndex = 16;
            // 
            // tbxGodinaKnjige
            // 
            this.tbxGodinaKnjige.Location = new System.Drawing.Point(157, 67);
            this.tbxGodinaKnjige.Multiline = true;
            this.tbxGodinaKnjige.Name = "tbxGodinaKnjige";
            this.tbxGodinaKnjige.Size = new System.Drawing.Size(121, 28);
            this.tbxGodinaKnjige.TabIndex = 18;
            // 
            // tbxNazivKnjige
            // 
            this.tbxNazivKnjige.Location = new System.Drawing.Point(32, 67);
            this.tbxNazivKnjige.Multiline = true;
            this.tbxNazivKnjige.Name = "tbxNazivKnjige";
            this.tbxNazivKnjige.Size = new System.Drawing.Size(119, 28);
            this.tbxNazivKnjige.TabIndex = 17;
            // 
            // lstbKnjige
            // 
            this.lstbKnjige.FormattingEnabled = true;
            this.lstbKnjige.Location = new System.Drawing.Point(35, 162);
            this.lstbKnjige.Name = "lstbKnjige";
            this.lstbKnjige.Size = new System.Drawing.Size(243, 134);
            this.lstbKnjige.TabIndex = 22;
            this.lstbKnjige.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstbKnjige_MouseClick);
            // 
            // lstbAutori
            // 
            this.lstbAutori.FormattingEnabled = true;
            this.lstbAutori.Location = new System.Drawing.Point(312, 162);
            this.lstbAutori.Name = "lstbAutori";
            this.lstbAutori.Size = new System.Drawing.Size(243, 134);
            this.lstbAutori.TabIndex = 23;
            // 
            // lblNazivKnjige
            // 
            this.lblNazivKnjige.AutoSize = true;
            this.lblNazivKnjige.Location = new System.Drawing.Point(32, 51);
            this.lblNazivKnjige.Name = "lblNazivKnjige";
            this.lblNazivKnjige.Size = new System.Drawing.Size(34, 13);
            this.lblNazivKnjige.TabIndex = 24;
            this.lblNazivKnjige.Text = "Naziv";
            // 
            // lblGodinaKnjige
            // 
            this.lblGodinaKnjige.AutoSize = true;
            this.lblGodinaKnjige.Location = new System.Drawing.Point(157, 51);
            this.lblGodinaKnjige.Name = "lblGodinaKnjige";
            this.lblGodinaKnjige.Size = new System.Drawing.Size(41, 13);
            this.lblGodinaKnjige.TabIndex = 25;
            this.lblGodinaKnjige.Text = "Godina";
            // 
            // lblPrezimeAutora
            // 
            this.lblPrezimeAutora.AutoSize = true;
            this.lblPrezimeAutora.Location = new System.Drawing.Point(431, 51);
            this.lblPrezimeAutora.Name = "lblPrezimeAutora";
            this.lblPrezimeAutora.Size = new System.Drawing.Size(44, 13);
            this.lblPrezimeAutora.TabIndex = 26;
            this.lblPrezimeAutora.Text = "Prezime";
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 449);
            this.Controls.Add(this.lblPrezimeAutora);
            this.Controls.Add(this.lblGodinaKnjige);
            this.Controls.Add(this.lblNazivKnjige);
            this.Controls.Add(this.lstbAutori);
            this.Controls.Add(this.lstbKnjige);
            this.Controls.Add(this.tbxGodinaKnjige);
            this.Controls.Add(this.tbxNazivKnjige);
            this.Controls.Add(this.tbxPrezimeAutora);
            this.Controls.Add(this.tbxPretraga);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.lblPotraziKnjigu);
            this.Controls.Add(this.btnDodajAutora);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.lblImeAutora);
            this.Controls.Add(this.tbxImeAutora);
            this.Name = "FrmGlavna";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxImeAutora;
        private System.Windows.Forms.Label lblImeAutora;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnDodajAutora;
        private System.Windows.Forms.Label lblPotraziKnjigu;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.TextBox tbxPretraga;
        private System.Windows.Forms.TextBox tbxPrezimeAutora;
        private System.Windows.Forms.TextBox tbxGodinaKnjige;
        private System.Windows.Forms.TextBox tbxNazivKnjige;
        private System.Windows.Forms.ListBox lstbKnjige;
        private System.Windows.Forms.ListBox lstbAutori;
        private System.Windows.Forms.Label lblNazivKnjige;
        private System.Windows.Forms.Label lblGodinaKnjige;
        private System.Windows.Forms.Label lblPrezimeAutora;
    }
}

