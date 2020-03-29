namespace archive
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.ReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportData = new archive.ReportData();
            this.ChkBxImportExport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ChkBxExport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ChkBxImport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatepickerStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DatepickerEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDataBindingSource
            // 
            this.ReportDataBindingSource.DataMember = "ReportData";
            this.ReportDataBindingSource.DataSource = this.ReportData;
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChkBxImportExport
            // 
            this.ChkBxImportExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImportExport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxImportExport.Checked = true;
            this.ChkBxImportExport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImportExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxImportExport.ForeColor = System.Drawing.Color.White;
            this.ChkBxImportExport.Location = new System.Drawing.Point(1329, 84);
            this.ChkBxImportExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxImportExport.Name = "ChkBxImportExport";
            this.ChkBxImportExport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxImportExport.TabIndex = 69;
            this.ChkBxImportExport.OnChange += new System.EventHandler(this.ChkBxImportExport_OnChange);
            // 
            // ChkBxExport
            // 
            this.ChkBxExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxExport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxExport.Checked = false;
            this.ChkBxExport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxExport.ForeColor = System.Drawing.Color.White;
            this.ChkBxExport.Location = new System.Drawing.Point(970, 83);
            this.ChkBxExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxExport.Name = "ChkBxExport";
            this.ChkBxExport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxExport.TabIndex = 70;
            this.ChkBxExport.OnChange += new System.EventHandler(this.ChkBxExport_OnChange);
            // 
            // ChkBxImport
            // 
            this.ChkBxImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxImport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxImport.Checked = false;
            this.ChkBxImport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxImport.ForeColor = System.Drawing.Color.White;
            this.ChkBxImport.Location = new System.Drawing.Point(1142, 82);
            this.ChkBxImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxImport.Name = "ChkBxImport";
            this.ChkBxImport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxImport.TabIndex = 71;
            this.ChkBxImport.OnChange += new System.EventHandler(this.ChkBxImport_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1016, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 34);
            this.label3.TabIndex = 72;
            this.label3.Text = "مكاتبات وارد فقط";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1178, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 73;
            this.label1.Text = "مكاتبات وارد / صادر ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(841, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 34);
            this.label2.TabIndex = 74;
            this.label2.Text = "مكاتبات صادر فقط";
            // 
            // DatepickerStart
            // 
            this.DatepickerStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.DatepickerStart.BorderRadius = 0;
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerStart.ForeColor = System.Drawing.Color.White;
            this.DatepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerStart.FormatCustom = "dd-MM-yyyy";
            this.DatepickerStart.Location = new System.Drawing.Point(382, 82);
            this.DatepickerStart.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerStart.Size = new System.Drawing.Size(146, 22);
            this.DatepickerStart.TabIndex = 66;
            this.DatepickerStart.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.BackColor = System.Drawing.Color.Turquoise;
            this.DatepickerEnd.BorderRadius = 0;
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerEnd.ForeColor = System.Drawing.Color.White;
            this.DatepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerEnd.FormatCustom = "dd-MM-yyyy";
            this.DatepickerEnd.Location = new System.Drawing.Point(158, 79);
            this.DatepickerEnd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerEnd.Size = new System.Drawing.Size(149, 23);
            this.DatepickerEnd.TabIndex = 65;
            this.DatepickerEnd.Value = new System.DateTime(2019, 4, 2, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(336, 77);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(32, 24);
            this.bunifuCustomLabel15.TabIndex = 63;
            this.bunifuCustomLabel15.Text = "الى";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(541, 82);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(30, 24);
            this.bunifuCustomLabel16.TabIndex = 64;
            this.bunifuCustomLabel16.Text = "من";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(586, 82);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(101, 22);
            this.bunifuCustomLabel7.TabIndex = 62;
            this.bunifuCustomLabel7.Text = "تاريخ المكاتبات";
            // 
            // ReportViewerFollowing
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportDataBindingSource;
            this.ReportViewerFollowing.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerFollowing.LocalReport.ReportEmbeddedResource = "archive.Report3.rdlc";
            this.ReportViewerFollowing.Location = new System.Drawing.Point(193, 159);
            this.ReportViewerFollowing.Name = "ReportViewerFollowing";
            this.ReportViewerFollowing.ServerReport.BearerToken = null;
            this.ReportViewerFollowing.Size = new System.Drawing.Size(992, 525);
            this.ReportViewerFollowing.TabIndex = 75;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Location = new System.Drawing.Point(602, 111);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(246, 42);
            this.BtnSearch.TabIndex = 76;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(486, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(454, 64);
            this.btnReport.TabIndex = 92;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 741);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Controls.Add(this.ChkBxImportExport);
            this.Controls.Add(this.ChkBxExport);
            this.Controls.Add(this.ChkBxImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatepickerStart);
            this.Controls.Add(this.DatepickerEnd);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox ChkBxImportExport;
        private Bunifu.Framework.UI.BunifuCheckbox ChkBxExport;
        private Bunifu.Framework.UI.BunifuCheckbox ChkBxImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerStart;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerEnd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
        private System.Windows.Forms.BindingSource ReportDataBindingSource;
        private ReportData ReportData;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnReport;
    }
}