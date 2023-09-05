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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.CmbBxOrgName = new System.Windows.Forms.ComboBox();
            this.ChkBxExport = new System.Windows.Forms.CheckBox();
            this.ChkBxImport = new System.Windows.Forms.CheckBox();
            this.ChkBxImportExport = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtIdFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DatepickerStart = new System.Windows.Forms.DateTimePicker();
            this.DatepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.ReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportData = new archive.ReportData();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerFollowing
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ReportDataBindingSource;
            this.ReportViewerFollowing.LocalReport.DataSources.Add(reportDataSource2);
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
            this.BtnSearch.Location = new System.Drawing.Point(114, 111);
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
            // CmbBxOrgName
            // 
            this.CmbBxOrgName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxOrgName.FormattingEnabled = true;
            this.CmbBxOrgName.Location = new System.Drawing.Point(375, 124);
            this.CmbBxOrgName.Name = "CmbBxOrgName";
            this.CmbBxOrgName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbBxOrgName.Size = new System.Drawing.Size(316, 27);
            this.CmbBxOrgName.TabIndex = 93;
            // 
            // ChkBxExport
            // 
            this.ChkBxExport.AutoSize = true;
            this.ChkBxExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxExport.Location = new System.Drawing.Point(881, 64);
            this.ChkBxExport.Name = "ChkBxExport";
            this.ChkBxExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxExport.Size = new System.Drawing.Size(146, 38);
            this.ChkBxExport.TabIndex = 99;
            this.ChkBxExport.Text = "مكاتبات صادر فقط";
            this.ChkBxExport.UseVisualStyleBackColor = true;
            this.ChkBxExport.CheckedChanged += new System.EventHandler(this.ChkBxExport_OnChange);
            // 
            // ChkBxImport
            // 
            this.ChkBxImport.AutoSize = true;
            this.ChkBxImport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkBxImport.Location = new System.Drawing.Point(1033, 63);
            this.ChkBxImport.Name = "ChkBxImport";
            this.ChkBxImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxImport.Size = new System.Drawing.Size(141, 38);
            this.ChkBxImport.TabIndex = 98;
            this.ChkBxImport.Text = "مكاتبات وارد فقط";
            this.ChkBxImport.UseVisualStyleBackColor = true;
            this.ChkBxImport.CheckedChanged += new System.EventHandler(this.ChkBxImport_OnChange);
            // 
            // ChkBxImportExport
            // 
            this.ChkBxImportExport.AutoSize = true;
            this.ChkBxImportExport.Checked = true;
            this.ChkBxImportExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBxImportExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxImportExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ChkBxImportExport.Location = new System.Drawing.Point(1178, 63);
            this.ChkBxImportExport.Name = "ChkBxImportExport";
            this.ChkBxImportExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxImportExport.Size = new System.Drawing.Size(170, 38);
            this.ChkBxImportExport.TabIndex = 97;
            this.ChkBxImportExport.Text = "مكاتبات وارد / صادر ";
            this.ChkBxImportExport.UseVisualStyleBackColor = true;
            this.ChkBxImportExport.CheckedChanged += new System.EventHandler(this.ChkBxImportExport_OnChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(282, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 100;
            this.label8.Text = "تاريخ المكاتبات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(525, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 101;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(310, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 101;
            this.label2.Text = "الى";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Location = new System.Drawing.Point(998, 124);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilter.Size = new System.Drawing.Size(187, 29);
            this.txtFilter.TabIndex = 102;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_OnValueChanged);
            // 
            // txtIdFilter
            // 
            this.txtIdFilter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdFilter.ForeColor = System.Drawing.Color.Black;
            this.txtIdFilter.Location = new System.Drawing.Point(822, 124);
            this.txtIdFilter.Name = "txtIdFilter";
            this.txtIdFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIdFilter.Size = new System.Drawing.Size(118, 29);
            this.txtIdFilter.TabIndex = 103;
            this.txtIdFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdFilter.TextChanged += new System.EventHandler(this.txtIdFilter_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(703, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 100;
            this.label3.Text = "اسم الجهة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(818, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "بحث ب كود الجهة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1033, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 100;
            this.label5.Text = "بحث ب اسم الجهة";
            // 
            // DatepickerStart
            // 
            this.DatepickerStart.CalendarForeColor = System.Drawing.Color.Blue;
            this.DatepickerStart.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.DatepickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DatepickerStart.CustomFormat = "dd/MM/yyyy";
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerStart.Location = new System.Drawing.Point(351, 76);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerStart.RightToLeftLayout = true;
            this.DatepickerStart.Size = new System.Drawing.Size(165, 29);
            this.DatepickerStart.TabIndex = 104;
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.CalendarForeColor = System.Drawing.Color.Blue;
            this.DatepickerEnd.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.DatepickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DatepickerEnd.CustomFormat = "dd/MM/yyyy";
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerEnd.Location = new System.Drawing.Point(143, 74);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerEnd.RightToLeftLayout = true;
            this.DatepickerEnd.Size = new System.Drawing.Size(160, 29);
            this.DatepickerEnd.TabIndex = 104;
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
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 741);
            this.Controls.Add(this.DatepickerEnd);
            this.Controls.Add(this.DatepickerStart);
            this.Controls.Add(this.txtIdFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChkBxExport);
            this.Controls.Add(this.ChkBxImport);
            this.Controls.Add(this.ChkBxImportExport);
            this.Controls.Add(this.CmbBxOrgName);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormReports_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
        private System.Windows.Forms.BindingSource ReportDataBindingSource;
        private ReportData ReportData;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox CmbBxOrgName;
        private System.Windows.Forms.CheckBox ChkBxExport;
        private System.Windows.Forms.CheckBox ChkBxImport;
        private System.Windows.Forms.CheckBox ChkBxImportExport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtIdFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatepickerStart;
        private System.Windows.Forms.DateTimePicker DatepickerEnd;
    }
}