namespace Assessments
{
    partial class Assessments
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
            this.lblList = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblAssess = new System.Windows.Forms.Label();
            this.cboAssess = new System.Windows.Forms.ComboBox();
            this.grpbNewAssess = new System.Windows.Forms.GroupBox();
            this.btnAddAssess = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblAssessName = new System.Windows.Forms.Label();
            this.grpNewStu = new System.Windows.Forms.GroupBox();
            this.btnNewStu = new System.Windows.Forms.Button();
            this.txtNewStu = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.grpScore = new System.Windows.Forms.GroupBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAutoFill2 = new System.Windows.Forms.Label();
            this.lblAssessScore = new System.Windows.Forms.Label();
            this.lblAutoFill1 = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpbNewAssess.SuspendLayout();
            this.grpNewStu.SuspendLayout();
            this.grpScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(33, 22);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(128, 17);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "The list of students";
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(31, 51);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(475, 188);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // lblAssess
            // 
            this.lblAssess.AutoSize = true;
            this.lblAssess.Location = new System.Drawing.Point(549, 22);
            this.lblAssess.Name = "lblAssess";
            this.lblAssess.Size = new System.Drawing.Size(157, 17);
            this.lblAssess.TabIndex = 2;
            this.lblAssess.Text = "The list of Assessments";
            // 
            // cboAssess
            // 
            this.cboAssess.FormattingEnabled = true;
            this.cboAssess.Location = new System.Drawing.Point(552, 47);
            this.cboAssess.Name = "cboAssess";
            this.cboAssess.Size = new System.Drawing.Size(196, 24);
            this.cboAssess.TabIndex = 3;
            this.cboAssess.SelectedIndexChanged += new System.EventHandler(this.cboAssess_SelectedIndexChanged);
            // 
            // grpbNewAssess
            // 
            this.grpbNewAssess.Controls.Add(this.btnAddAssess);
            this.grpbNewAssess.Controls.Add(this.txtMax);
            this.grpbNewAssess.Controls.Add(this.txtName);
            this.grpbNewAssess.Controls.Add(this.lblMaxScore);
            this.grpbNewAssess.Controls.Add(this.lblAssessName);
            this.grpbNewAssess.Location = new System.Drawing.Point(552, 100);
            this.grpbNewAssess.Name = "grpbNewAssess";
            this.grpbNewAssess.Size = new System.Drawing.Size(196, 240);
            this.grpbNewAssess.TabIndex = 4;
            this.grpbNewAssess.TabStop = false;
            this.grpbNewAssess.Text = "Adding new Assessment";
            // 
            // btnAddAssess
            // 
            this.btnAddAssess.Location = new System.Drawing.Point(58, 196);
            this.btnAddAssess.Name = "btnAddAssess";
            this.btnAddAssess.Size = new System.Drawing.Size(112, 23);
            this.btnAddAssess.TabIndex = 4;
            this.btnAddAssess.Text = "Add assess.";
            this.btnAddAssess.UseVisualStyleBackColor = true;
            this.btnAddAssess.Click += new System.EventHandler(this.btnAddAssess_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(27, 127);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(143, 22);
            this.txtMax.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(24, 107);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(74, 17);
            this.lblMaxScore.TabIndex = 1;
            this.lblMaxScore.Text = "Max Score";
            // 
            // lblAssessName
            // 
            this.lblAssessName.AutoSize = true;
            this.lblAssessName.Location = new System.Drawing.Point(24, 44);
            this.lblAssessName.Name = "lblAssessName";
            this.lblAssessName.Size = new System.Drawing.Size(123, 17);
            this.lblAssessName.TabIndex = 0;
            this.lblAssessName.Text = "Assessment name";
            // 
            // grpNewStu
            // 
            this.grpNewStu.Controls.Add(this.btnNewStu);
            this.grpNewStu.Controls.Add(this.txtNewStu);
            this.grpNewStu.Controls.Add(this.lblStuName);
            this.grpNewStu.Location = new System.Drawing.Point(33, 256);
            this.grpNewStu.Name = "grpNewStu";
            this.grpNewStu.Size = new System.Drawing.Size(506, 83);
            this.grpNewStu.TabIndex = 5;
            this.grpNewStu.TabStop = false;
            this.grpNewStu.Text = "Adding new Student";
            // 
            // btnNewStu
            // 
            this.btnNewStu.Location = new System.Drawing.Point(361, 36);
            this.btnNewStu.Name = "btnNewStu";
            this.btnNewStu.Size = new System.Drawing.Size(112, 23);
            this.btnNewStu.TabIndex = 5;
            this.btnNewStu.Text = "Add student";
            this.btnNewStu.UseVisualStyleBackColor = true;
            this.btnNewStu.Click += new System.EventHandler(this.btnNewStu_Click);
            // 
            // txtNewStu
            // 
            this.txtNewStu.Location = new System.Drawing.Point(174, 37);
            this.txtNewStu.Name = "txtNewStu";
            this.txtNewStu.Size = new System.Drawing.Size(143, 22);
            this.txtNewStu.TabIndex = 4;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(6, 40);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(73, 17);
            this.lblStuName.TabIndex = 0;
            this.lblStuName.Text = "Full name:";
            // 
            // grpScore
            // 
            this.grpScore.Controls.Add(this.btnScore);
            this.grpScore.Controls.Add(this.txtScore);
            this.grpScore.Controls.Add(this.lblMax);
            this.grpScore.Controls.Add(this.lblScore);
            this.grpScore.Controls.Add(this.lblAutoFill2);
            this.grpScore.Controls.Add(this.lblAssessScore);
            this.grpScore.Controls.Add(this.lblAutoFill1);
            this.grpScore.Controls.Add(this.lblStu);
            this.grpScore.Location = new System.Drawing.Point(36, 348);
            this.grpScore.Name = "grpScore";
            this.grpScore.Size = new System.Drawing.Size(711, 71);
            this.grpScore.TabIndex = 6;
            this.grpScore.TabStop = false;
            this.grpScore.Text = "Add score";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(577, 28);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(112, 23);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "Set score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(466, 29);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(53, 22);
            this.txtScore.TabIndex = 6;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(525, 32);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(32, 17);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "/ 10";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(414, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblAutoFill2
            // 
            this.lblAutoFill2.AutoSize = true;
            this.lblAutoFill2.Location = new System.Drawing.Point(264, 31);
            this.lblAutoFill2.Name = "lblAutoFill2";
            this.lblAutoFill2.Size = new System.Drawing.Size(54, 17);
            this.lblAutoFill2.TabIndex = 3;
            this.lblAutoFill2.Text = "AutoFill";
            // 
            // lblAssessScore
            // 
            this.lblAssessScore.AutoSize = true;
            this.lblAssessScore.Location = new System.Drawing.Point(201, 32);
            this.lblAssessScore.Name = "lblAssessScore";
            this.lblAssessScore.Size = new System.Drawing.Size(57, 17);
            this.lblAssessScore.TabIndex = 2;
            this.lblAssessScore.Text = "Assess:";
            // 
            // lblAutoFill1
            // 
            this.lblAutoFill1.AutoSize = true;
            this.lblAutoFill1.Location = new System.Drawing.Point(73, 32);
            this.lblAutoFill1.Name = "lblAutoFill1";
            this.lblAutoFill1.Size = new System.Drawing.Size(54, 17);
            this.lblAutoFill1.TabIndex = 1;
            this.lblAutoFill1.Text = "AutoFill";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Location = new System.Drawing.Point(6, 32);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(61, 17);
            this.lblStu.TabIndex = 0;
            this.lblStu.Text = "Student:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(42, 434);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show Students";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowScore
            // 
            this.btnShowScore.Location = new System.Drawing.Point(182, 434);
            this.btnShowScore.Name = "btnShowScore";
            this.btnShowScore.Size = new System.Drawing.Size(112, 23);
            this.btnShowScore.TabIndex = 7;
            this.btnShowScore.Text = "Show Score";
            this.btnShowScore.UseVisualStyleBackColor = true;
            this.btnShowScore.Click += new System.EventHandler(this.btnShowScore_Click);
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 536);
            this.Controls.Add(this.btnShowScore);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grpScore);
            this.Controls.Add(this.grpNewStu);
            this.Controls.Add(this.grpbNewAssess);
            this.Controls.Add(this.cboAssess);
            this.Controls.Add(this.lblAssess);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblList);
            this.Name = "Assessments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessments";
            this.Load += new System.EventHandler(this.Assessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpbNewAssess.ResumeLayout(false);
            this.grpbNewAssess.PerformLayout();
            this.grpNewStu.ResumeLayout(false);
            this.grpNewStu.PerformLayout();
            this.grpScore.ResumeLayout(false);
            this.grpScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblAssess;
        private System.Windows.Forms.ComboBox cboAssess;
        private System.Windows.Forms.GroupBox grpbNewAssess;
        private System.Windows.Forms.Button btnAddAssess;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblAssessName;
        private System.Windows.Forms.GroupBox grpNewStu;
        private System.Windows.Forms.Button btnNewStu;
        private System.Windows.Forms.TextBox txtNewStu;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.GroupBox grpScore;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAutoFill2;
        private System.Windows.Forms.Label lblAssessScore;
        private System.Windows.Forms.Label lblAutoFill1;
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowScore;
    }
}

