namespace Kamate
{
    partial class Kamate
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
            this.grpbGlavna = new System.Windows.Forms.GroupBox();
            this.lblGlavnica = new System.Windows.Forms.Label();
            this.lblKamStopa = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblOtpPlan = new System.Windows.Forms.Label();
            this.txtGlavnica = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtKamStopa = new System.Windows.Forms.TextBox();
            this.txtOtpPlan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbGlavna.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbGlavna
            // 
            this.grpbGlavna.Controls.Add(this.button1);
            this.grpbGlavna.Controls.Add(this.txtOtpPlan);
            this.grpbGlavna.Controls.Add(this.txtKamStopa);
            this.grpbGlavna.Controls.Add(this.txtTrajanje);
            this.grpbGlavna.Controls.Add(this.txtGlavnica);
            this.grpbGlavna.Controls.Add(this.lblOtpPlan);
            this.grpbGlavna.Controls.Add(this.lblTrajanje);
            this.grpbGlavna.Controls.Add(this.lblKamStopa);
            this.grpbGlavna.Controls.Add(this.lblGlavnica);
            this.grpbGlavna.Location = new System.Drawing.Point(61, 69);
            this.grpbGlavna.Name = "grpbGlavna";
            this.grpbGlavna.Size = new System.Drawing.Size(378, 282);
            this.grpbGlavna.TabIndex = 0;
            this.grpbGlavna.TabStop = false;
            // 
            // lblGlavnica
            // 
            this.lblGlavnica.AutoSize = true;
            this.lblGlavnica.Location = new System.Drawing.Point(39, 40);
            this.lblGlavnica.Name = "lblGlavnica";
            this.lblGlavnica.Size = new System.Drawing.Size(67, 17);
            this.lblGlavnica.TabIndex = 0;
            this.lblGlavnica.Text = "Glavnica:";
            // 
            // lblKamStopa
            // 
            this.lblKamStopa.AutoSize = true;
            this.lblKamStopa.Location = new System.Drawing.Point(39, 87);
            this.lblKamStopa.Name = "lblKamStopa";
            this.lblKamStopa.Size = new System.Drawing.Size(109, 17);
            this.lblKamStopa.TabIndex = 1;
            this.lblKamStopa.Text = "Kamatna Stopa:";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(39, 128);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(113, 17);
            this.lblTrajanje.TabIndex = 2;
            this.lblTrajanje.Text = "Trajanje Kredita:";
            // 
            // lblOtpPlan
            // 
            this.lblOtpPlan.AutoSize = true;
            this.lblOtpPlan.Location = new System.Drawing.Point(39, 220);
            this.lblOtpPlan.Name = "lblOtpPlan";
            this.lblOtpPlan.Size = new System.Drawing.Size(93, 17);
            this.lblOtpPlan.TabIndex = 3;
            this.lblOtpPlan.Text = "Otplatni Plan:";
            // 
            // txtGlavnica
            // 
            this.txtGlavnica.Location = new System.Drawing.Point(154, 40);
            this.txtGlavnica.Name = "txtGlavnica";
            this.txtGlavnica.Size = new System.Drawing.Size(185, 22);
            this.txtGlavnica.TabIndex = 4;
            this.txtGlavnica.Enter += new System.EventHandler(this.txtGlavnica_Enter);
            this.txtGlavnica.Leave += new System.EventHandler(this.txtGlavnica_Leave);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(154, 123);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(185, 22);
            this.txtTrajanje.TabIndex = 5;
            this.txtTrajanje.Enter += new System.EventHandler(this.txtTrajanje_Enter);
            this.txtTrajanje.Leave += new System.EventHandler(this.txtTrajanje_Leave);
            // 
            // txtKamStopa
            // 
            this.txtKamStopa.Location = new System.Drawing.Point(154, 87);
            this.txtKamStopa.Name = "txtKamStopa";
            this.txtKamStopa.Size = new System.Drawing.Size(185, 22);
            this.txtKamStopa.TabIndex = 6;
            this.txtKamStopa.Enter += new System.EventHandler(this.txtKamStopa_Enter);
            this.txtKamStopa.Leave += new System.EventHandler(this.txtKamStopa_Leave);
            // 
            // txtOtpPlan
            // 
            this.txtOtpPlan.Location = new System.Drawing.Point(154, 215);
            this.txtOtpPlan.Name = "txtOtpPlan";
            this.txtOtpPlan.Size = new System.Drawing.Size(185, 22);
            this.txtOtpPlan.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Kamate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 457);
            this.Controls.Add(this.grpbGlavna);
            this.Name = "Kamate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredit";
            this.grpbGlavna.ResumeLayout(false);
            this.grpbGlavna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbGlavna;
        private System.Windows.Forms.Label lblOtpPlan;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblKamStopa;
        private System.Windows.Forms.Label lblGlavnica;
        private System.Windows.Forms.TextBox txtOtpPlan;
        private System.Windows.Forms.TextBox txtKamStopa;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtGlavnica;
        private System.Windows.Forms.Button button1;
    }
}

