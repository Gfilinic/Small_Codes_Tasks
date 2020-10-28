namespace Reporting
{
    partial class FrmProducts
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose supplier:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 5);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(110, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(320, 7);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(110, 21);
            this.cmbSupplier.TabIndex = 1;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(454, 7);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(120, 20);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ProductDataSet";
            reportDataSource1.Value = this.ProductBindingSource;
            reportDataSource2.Name = "SupplierDataSet";
            reportDataSource2.Value = this.SupplierBindingSource;
            reportDataSource3.Name = "CategoryDataSet";
            reportDataSource3.Value = this.CategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporting.Report.Products Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 391);
            this.reportViewer1.TabIndex = 3;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataSource = typeof(Reporting.Product);
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataSource = typeof(Reporting.Supplier);
            // 
            // CategoryBindingSource
            // 
            this.CategoryBindingSource.DataSource = typeof(Reporting.Category);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 436);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProducts";
            this.Text = "Products Report";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnShowReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private System.Windows.Forms.BindingSource CategoryBindingSource;
    }
}

