namespace archive
{
    partial class FormFollowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFollowing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReportData = new archive.ReportData();
            this.ReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbBxUserName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orgname = new System.Windows.Forms.TextBox();
            this.orgid = new System.Windows.Forms.TextBox();
            this.show_report_btn = new System.Windows.Forms.Button();
            this.DatepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.DatepickerStart = new System.Windows.Forms.DateTimePicker();
            this.lstBxUsers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.ChkBxImportExport = new System.Windows.Forms.CheckBox();
            this.ChkBxImport = new System.Windows.Forms.CheckBox();
            this.ChkBxExport = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportDataBindingSource
            // 
            this.ReportDataBindingSource.DataMember = "ReportData";
            this.ReportDataBindingSource.DataSource = this.ReportData;
            // 
            // ReportViewerFollowing
            // 
            this.ReportViewerFollowing.LocalReport.ReportEmbeddedResource = "archive.ReportFollowing.rdlc";
            this.ReportViewerFollowing.Location = new System.Drawing.Point(3, 215);
            this.ReportViewerFollowing.Name = "ReportViewerFollowing";
            this.ReportViewerFollowing.ServerReport.BearerToken = null;
            this.ReportViewerFollowing.Size = new System.Drawing.Size(1353, 506);
            this.ReportViewerFollowing.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(482, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 66);
            this.panel3.TabIndex = 63;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Location = new System.Drawing.Point(47, 95);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(167, 42);
            this.BtnSearch.TabIndex = 62;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbBxUserName
            // 
            this.CmbBxUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxUserName.FormattingEnabled = true;
            this.CmbBxUserName.Location = new System.Drawing.Point(1061, 106);
            this.CmbBxUserName.Name = "CmbBxUserName";
            this.CmbBxUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbBxUserName.Size = new System.Drawing.Size(163, 27);
            this.CmbBxUserName.TabIndex = 69;
            this.CmbBxUserName.SelectedIndexChanged += new System.EventHandler(this.CmbBxUserName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.ChkBxExport);
            this.panel1.Controls.Add(this.ChkBxImport);
            this.panel1.Controls.Add(this.ChkBxImportExport);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orgname);
            this.panel1.Controls.Add(this.orgid);
            this.panel1.Controls.Add(this.show_report_btn);
            this.panel1.Controls.Add(this.DatepickerEnd);
            this.panel1.Controls.Add(this.DatepickerStart);
            this.panel1.Controls.Add(this.CmbBxUserName);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 144);
            this.panel1.TabIndex = 68;
            // 
            // orgname
            // 
            this.orgname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.orgname.ForeColor = System.Drawing.Color.Black;
            this.orgname.Location = new System.Drawing.Point(714, 100);
            this.orgname.Name = "orgname";
            this.orgname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orgname.Size = new System.Drawing.Size(226, 26);
            this.orgname.TabIndex = 81;
            this.orgname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orgname.TextChanged += new System.EventHandler(this.orgname_OnValueChanged);
            // 
            // orgid
            // 
            this.orgid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.orgid.ForeColor = System.Drawing.Color.Black;
            this.orgid.Location = new System.Drawing.Point(875, 64);
            this.orgid.Name = "orgid";
            this.orgid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orgid.Size = new System.Drawing.Size(65, 26);
            this.orgid.TabIndex = 80;
            this.orgid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orgid.TextChanged += new System.EventHandler(this.orgid_OnValueChanged);
            // 
            // show_report_btn
            // 
            this.show_report_btn.BackColor = System.Drawing.Color.Purple;
            this.show_report_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_report_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.show_report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_report_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_report_btn.Location = new System.Drawing.Point(239, 95);
            this.show_report_btn.Name = "show_report_btn";
            this.show_report_btn.Size = new System.Drawing.Size(174, 44);
            this.show_report_btn.TabIndex = 78;
            this.show_report_btn.Text = "عرض/ اخفاء التقرير";
            this.show_report_btn.UseVisualStyleBackColor = false;
            this.show_report_btn.Click += new System.EventHandler(this.show_report_btn_Click);
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.CalendarForeColor = System.Drawing.Color.Blue;
            this.DatepickerEnd.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.DatepickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DatepickerEnd.CustomFormat = "dd/MM/yyyy";
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerEnd.Location = new System.Drawing.Point(445, 8);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerEnd.RightToLeftLayout = true;
            this.DatepickerEnd.Size = new System.Drawing.Size(189, 29);
            this.DatepickerEnd.TabIndex = 77;
            // 
            // DatepickerStart
            // 
            this.DatepickerStart.CalendarForeColor = System.Drawing.Color.Blue;
            this.DatepickerStart.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.DatepickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DatepickerStart.CustomFormat = "dd/MM/yyyy";
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerStart.Location = new System.Drawing.Point(702, 11);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerStart.RightToLeftLayout = true;
            this.DatepickerStart.Size = new System.Drawing.Size(189, 29);
            this.DatepickerStart.TabIndex = 76;
            // 
            // lstBxUsers
            // 
            this.lstBxUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxUsers.FormattingEnabled = true;
            this.lstBxUsers.ItemHeight = 19;
            this.lstBxUsers.Location = new System.Drawing.Point(1075, 12);
            this.lstBxUsers.Name = "lstBxUsers";
            this.lstBxUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBxUsers.Size = new System.Drawing.Size(267, 42);
            this.lstBxUsers.TabIndex = 70;
            this.lstBxUsers.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(968, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "كود الجهة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(968, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 83;
            this.label5.Text = "اسم الجهة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(640, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 84;
            this.label6.Text = "الى";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(897, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "من";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(933, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 86;
            this.label8.Text = "تاريخ المتابعة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(1232, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 87;
            this.label9.Text = "اسم المختص";
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TxtUser.ForeColor = System.Drawing.Color.Black;
            this.TxtUser.Location = new System.Drawing.Point(919, 28);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUser.Size = new System.Drawing.Size(37, 26);
            this.TxtUser.TabIndex = 88;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUser.Visible = false;
            // 
            // ChkBxImportExport
            // 
            this.ChkBxImportExport.AutoSize = true;
            this.ChkBxImportExport.Checked = true;
            this.ChkBxImportExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBxImportExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxImportExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ChkBxImportExport.Location = new System.Drawing.Point(1168, 3);
            this.ChkBxImportExport.Name = "ChkBxImportExport";
            this.ChkBxImportExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxImportExport.Size = new System.Drawing.Size(155, 38);
            this.ChkBxImportExport.TabIndex = 89;
            this.ChkBxImportExport.Text = "متابعة وارد / صادر ";
            this.ChkBxImportExport.UseVisualStyleBackColor = true;
            this.ChkBxImportExport.CheckedChanged += new System.EventHandler(this.ChkBxImportExport_OnChange);
            // 
            // ChkBxImport
            // 
            this.ChkBxImport.AutoSize = true;
            this.ChkBxImport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkBxImport.Location = new System.Drawing.Point(1197, 32);
            this.ChkBxImport.Name = "ChkBxImport";
            this.ChkBxImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxImport.Size = new System.Drawing.Size(126, 38);
            this.ChkBxImport.TabIndex = 90;
            this.ChkBxImport.Text = "متابعة وارد فقط";
            this.ChkBxImport.UseVisualStyleBackColor = true;
            this.ChkBxImport.CheckedChanged += new System.EventHandler(this.ChkBxImport_OnChange);
            // 
            // ChkBxExport
            // 
            this.ChkBxExport.AutoSize = true;
            this.ChkBxExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F);
            this.ChkBxExport.Location = new System.Drawing.Point(1192, 62);
            this.ChkBxExport.Name = "ChkBxExport";
            this.ChkBxExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxExport.Size = new System.Drawing.Size(131, 38);
            this.ChkBxExport.TabIndex = 91;
            this.ChkBxExport.Text = "متابعة صادر فقط";
            this.ChkBxExport.UseVisualStyleBackColor = true;
            this.ChkBxExport.CheckedChanged += new System.EventHandler(this.ChkBxExport_OnChange);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 243);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 45;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(1330, 464);
            this.dataGridView.TabIndex = 89;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // FormFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.lstBxUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Name = "FormFollowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة المتابعة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFollowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportData ReportData;
        private System.Windows.Forms.BindingSource ReportDataBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CmbBxUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBxUsers;
        private System.Windows.Forms.DateTimePicker DatepickerEnd;
        private System.Windows.Forms.DateTimePicker DatepickerStart;
        private System.Windows.Forms.Button show_report_btn;
        private System.Windows.Forms.TextBox orgid;
        private System.Windows.Forms.TextBox orgname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.CheckBox ChkBxImportExport;
        private System.Windows.Forms.CheckBox ChkBxExport;
        private System.Windows.Forms.CheckBox ChkBxImport;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}