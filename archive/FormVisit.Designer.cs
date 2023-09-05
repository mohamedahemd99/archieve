namespace archive
{
    partial class FormVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisit));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReportDataVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtImportID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDeleteVisit = new System.Windows.Forms.Button();
            this.BtnEditVisit = new System.Windows.Forms.Button();
            this.BtnAddVisit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReportViewerVisit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtExportID = new System.Windows.Forms.TextBox();
            this.TxtOrg = new System.Windows.Forms.TextBox();
            this.TxtorgVisit = new System.Windows.Forms.TextBox();
            this.Txtsubject = new System.Windows.Forms.TextBox();
            this.DateStartVisit = new System.Windows.Forms.DateTimePicker();
            this.DateEndVisit = new System.Windows.Forms.DateTimePicker();
            this.DatepickerStart = new System.Windows.Forms.DateTimePicker();
            this.DatepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.DgvVisit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataVisitBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDataVisitBindingSource
            // 
            this.ReportDataVisitBindingSource.DataMember = "ReportDataVisit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.DateEndVisit);
            this.panel1.Controls.Add(this.DateStartVisit);
            this.panel1.Controls.Add(this.TxtExportID);
            this.panel1.Controls.Add(this.Txtsubject);
            this.panel1.Controls.Add(this.TxtorgVisit);
            this.panel1.Controls.Add(this.TxtOrg);
            this.panel1.Controls.Add(this.TxtImportID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDeleteVisit);
            this.panel1.Controls.Add(this.BtnEditVisit);
            this.panel1.Controls.Add(this.BtnAddVisit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 244);
            this.panel1.TabIndex = 2;
            // 
            // TxtImportID
            // 
            this.TxtImportID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtImportID.ForeColor = System.Drawing.Color.Black;
            this.TxtImportID.Location = new System.Drawing.Point(740, 58);
            this.TxtImportID.Name = "TxtImportID";
            this.TxtImportID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtImportID.Size = new System.Drawing.Size(87, 29);
            this.TxtImportID.TabIndex = 83;
            this.TxtImportID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtImportID.TextChanged += new System.EventHandler(this.TxtImportID_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1238, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 82;
            this.label1.Text = "جهة الزيارة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(843, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 82;
            this.label5.Text = "رقم الصادر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(851, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 82;
            this.label4.Text = "رقم الوارد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(766, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 82;
            this.label7.Text = "تاريخ نهاية الزيارة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1185, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 27);
            this.label6.TabIndex = 82;
            this.label6.Text = "تاريخ بداية الزيارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1256, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "الموضوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(1267, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 27);
            this.label10.TabIndex = 82;
            this.label10.Text = "الجهة";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClear.BackgroundImage")));
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClear.Location = new System.Drawing.Point(32, 199);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(155, 43);
            this.BtnClear.TabIndex = 79;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDeleteVisit
            // 
            this.BtnDeleteVisit.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDeleteVisit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteVisit.BackgroundImage")));
            this.BtnDeleteVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteVisit.Location = new System.Drawing.Point(32, 142);
            this.BtnDeleteVisit.Name = "BtnDeleteVisit";
            this.BtnDeleteVisit.Size = new System.Drawing.Size(155, 48);
            this.BtnDeleteVisit.TabIndex = 70;
            this.BtnDeleteVisit.UseVisualStyleBackColor = false;
            this.BtnDeleteVisit.Click += new System.EventHandler(this.BtnDeleteVisit_Click);
            // 
            // BtnEditVisit
            // 
            this.BtnEditVisit.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditVisit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditVisit.BackgroundImage")));
            this.BtnEditVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditVisit.Location = new System.Drawing.Point(28, 78);
            this.BtnEditVisit.Name = "BtnEditVisit";
            this.BtnEditVisit.Size = new System.Drawing.Size(159, 49);
            this.BtnEditVisit.TabIndex = 69;
            this.BtnEditVisit.UseVisualStyleBackColor = false;
            this.BtnEditVisit.Click += new System.EventHandler(this.BtnEditVisit_Click);
            // 
            // BtnAddVisit
            // 
            this.BtnAddVisit.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAddVisit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddVisit.BackgroundImage")));
            this.BtnAddVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddVisit.Location = new System.Drawing.Point(28, 12);
            this.BtnAddVisit.Name = "BtnAddVisit";
            this.BtnAddVisit.Size = new System.Drawing.Size(159, 54);
            this.BtnAddVisit.TabIndex = 68;
            this.BtnAddVisit.UseVisualStyleBackColor = false;
            this.BtnAddVisit.Click += new System.EventHandler(this.BtnAddVisit_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(516, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 48);
            this.panel2.TabIndex = 67;
            // 
            // ReportViewerVisit
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportDataVisitBindingSource;
            this.ReportViewerVisit.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerVisit.LocalReport.ReportEmbeddedResource = "archive.Report2.rdlc";
            this.ReportViewerVisit.Location = new System.Drawing.Point(12, 311);
            this.ReportViewerVisit.Name = "ReportViewerVisit";
            this.ReportViewerVisit.ServerReport.BearerToken = null;
            this.ReportViewerVisit.Size = new System.Drawing.Size(1338, 24);
            this.ReportViewerVisit.TabIndex = 58;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Location = new System.Drawing.Point(274, 259);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(184, 45);
            this.BtnSearch.TabIndex = 78;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(958, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 82;
            this.label8.Text = "تاريخ الزيارة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(913, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 22);
            this.label9.TabIndex = 82;
            this.label9.Text = "من";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(670, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 22);
            this.label11.TabIndex = 82;
            this.label11.Text = "الى";
            // 
            // TxtExportID
            // 
            this.TxtExportID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtExportID.ForeColor = System.Drawing.Color.Black;
            this.TxtExportID.Location = new System.Drawing.Point(740, 102);
            this.TxtExportID.Name = "TxtExportID";
            this.TxtExportID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtExportID.Size = new System.Drawing.Size(87, 29);
            this.TxtExportID.TabIndex = 83;
            this.TxtExportID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtExportID.TextChanged += new System.EventHandler(this.TxtExportID_OnValueChanged);
            this.TxtExportID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtImportID_OnValueChanged);
            // 
            // TxtOrg
            // 
            this.TxtOrg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtOrg.ForeColor = System.Drawing.Color.Black;
            this.TxtOrg.Location = new System.Drawing.Point(997, 56);
            this.TxtOrg.Name = "TxtOrg";
            this.TxtOrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrg.Size = new System.Drawing.Size(231, 29);
            this.TxtOrg.TabIndex = 83;
            this.TxtOrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtorgVisit
            // 
            this.TxtorgVisit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtorgVisit.ForeColor = System.Drawing.Color.Black;
            this.TxtorgVisit.Location = new System.Drawing.Point(997, 102);
            this.TxtorgVisit.Name = "TxtorgVisit";
            this.TxtorgVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtorgVisit.Size = new System.Drawing.Size(231, 29);
            this.TxtorgVisit.TabIndex = 83;
            this.TxtorgVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtorgVisit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtImportID_OnValueChanged);
            // 
            // Txtsubject
            // 
            this.Txtsubject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txtsubject.ForeColor = System.Drawing.Color.Black;
            this.Txtsubject.Location = new System.Drawing.Point(740, 150);
            this.Txtsubject.Name = "Txtsubject";
            this.Txtsubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txtsubject.Size = new System.Drawing.Size(488, 29);
            this.Txtsubject.TabIndex = 83;
            this.Txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtsubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtImportID_OnValueChanged);
            // 
            // DateStartVisit
            // 
            this.DateStartVisit.Font = new System.Drawing.Font("Arial", 13F);
            this.DateStartVisit.Location = new System.Drawing.Point(964, 199);
            this.DateStartVisit.Name = "DateStartVisit";
            this.DateStartVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateStartVisit.Size = new System.Drawing.Size(200, 27);
            this.DateStartVisit.TabIndex = 84;
            // 
            // DateEndVisit
            // 
            this.DateEndVisit.Font = new System.Drawing.Font("Arial", 13F);
            this.DateEndVisit.Location = new System.Drawing.Point(549, 200);
            this.DateEndVisit.Name = "DateEndVisit";
            this.DateEndVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateEndVisit.Size = new System.Drawing.Size(200, 27);
            this.DateEndVisit.TabIndex = 84;
            // 
            // DatepickerStart
            // 
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 13F);
            this.DatepickerStart.Location = new System.Drawing.Point(721, 265);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerStart.Size = new System.Drawing.Size(186, 27);
            this.DatepickerStart.TabIndex = 84;
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 13F);
            this.DatepickerEnd.Location = new System.Drawing.Point(481, 264);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerEnd.Size = new System.Drawing.Size(177, 27);
            this.DatepickerEnd.TabIndex = 84;
            // 
            // DgvVisit
            // 
            this.DgvVisit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvVisit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvVisit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVisit.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVisit.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvVisit.Location = new System.Drawing.Point(12, 341);
            this.DgvVisit.Name = "DgvVisit";
            this.DgvVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvVisit.RowHeadersWidth = 60;
            this.DgvVisit.Size = new System.Drawing.Size(1338, 376);
            this.DgvVisit.TabIndex = 85;
            this.DgvVisit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisit_CellClick);
            // 
            // FormVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.DgvVisit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DatepickerEnd);
            this.Controls.Add(this.DatepickerStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReportViewerVisit);
            this.Controls.Add(this.panel1);
            this.Name = "FormVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة الزيارات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataVisitBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerVisit;
        private System.Windows.Forms.BindingSource ReportDataVisitBindingSource;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDeleteVisit;
        private System.Windows.Forms.Button BtnEditVisit;
        private System.Windows.Forms.Button BtnAddVisit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtImportID;
        private System.Windows.Forms.TextBox TxtExportID;
        private System.Windows.Forms.TextBox TxtOrg;
        private System.Windows.Forms.TextBox TxtorgVisit;
        private System.Windows.Forms.TextBox Txtsubject;
        private System.Windows.Forms.DateTimePicker DateStartVisit;
        private System.Windows.Forms.DateTimePicker DateEndVisit;
        private System.Windows.Forms.DateTimePicker DatepickerStart;
        private System.Windows.Forms.DateTimePicker DatepickerEnd;
        private System.Windows.Forms.DataGridView DgvVisit;
    }
}