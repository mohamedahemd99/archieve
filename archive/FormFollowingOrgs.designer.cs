﻿namespace archive
{
    partial class FormFollowingOrgs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFollowingOrgs));
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DatepickerStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatepickerEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.orgid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ChkBxImport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkBxExport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ChkBxImportExport = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orgname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CmbBxUserName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothActive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.NotActive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Active = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBxUsers = new System.Windows.Forms.ListBox();
            this.TxtUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReportData = new archive.ReportData();
            this.ReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerFollowing
            // 
            this.ReportViewerFollowing.LocalReport.ReportEmbeddedResource = "archive.Report8.rdlc";
            this.ReportViewerFollowing.Location = new System.Drawing.Point(3, 215);
            this.ReportViewerFollowing.Name = "ReportViewerFollowing";
            this.ReportViewerFollowing.ServerReport.BearerToken = null;
            this.ReportViewerFollowing.Size = new System.Drawing.Size(1353, 465);
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
            // DatepickerStart
            // 
            this.DatepickerStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.DatepickerStart.BorderRadius = 0;
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerStart.ForeColor = System.Drawing.Color.White;
            this.DatepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerStart.FormatCustom = "dd-MM-yyyy";
            this.DatepickerStart.Location = new System.Drawing.Point(744, 13);
            this.DatepickerStart.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerStart.Size = new System.Drawing.Size(146, 22);
            this.DatepickerStart.TabIndex = 35;
            this.DatepickerStart.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(698, 8);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(32, 24);
            this.bunifuCustomLabel15.TabIndex = 32;
            this.bunifuCustomLabel15.Text = "الى";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(903, 13);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(30, 24);
            this.bunifuCustomLabel16.TabIndex = 33;
            this.bunifuCustomLabel16.Text = "من";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(948, 13);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(93, 22);
            this.bunifuCustomLabel7.TabIndex = 31;
            this.bunifuCustomLabel7.Text = "تاريخ المتابعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 61;
            this.label2.Text = "متابعة صادر فقط";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1161, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 61;
            this.label1.Text = "متابعة وارد / صادر ";
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.BackColor = System.Drawing.Color.DarkCyan;
            this.DatepickerEnd.BorderRadius = 0;
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerEnd.ForeColor = System.Drawing.Color.White;
            this.DatepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerEnd.FormatCustom = "dd-MM-yyyy";
            this.DatepickerEnd.Location = new System.Drawing.Point(520, 10);
            this.DatepickerEnd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatepickerEnd.Size = new System.Drawing.Size(149, 23);
            this.DatepickerEnd.TabIndex = 34;
            this.DatepickerEnd.Value = new System.DateTime(2019, 4, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1186, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 34);
            this.label3.TabIndex = 60;
            this.label3.Text = "متابعة وارد فقط";
            // 
            // orgid
            // 
            this.orgid.BackColor = System.Drawing.Color.Beige;
            this.orgid.BorderColorFocused = System.Drawing.Color.Blue;
            this.orgid.BorderColorIdle = System.Drawing.Color.Blue;
            this.orgid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orgid.BorderThickness = 3;
            this.orgid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orgid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgid.ForeColor = System.Drawing.Color.Black;
            this.orgid.isPassword = false;
            this.orgid.Location = new System.Drawing.Point(758, 59);
            this.orgid.Margin = new System.Windows.Forms.Padding(4);
            this.orgid.Name = "orgid";
            this.orgid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orgid.Size = new System.Drawing.Size(71, 30);
            this.orgid.TabIndex = 65;
            this.orgid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orgid.OnValueChanged += new System.EventHandler(this.orgid_OnValueChanged);
            // 
            // ChkBxImport
            // 
            this.ChkBxImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxImport.Checked = false;
            this.ChkBxImport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxImport.ForeColor = System.Drawing.Color.White;
            this.ChkBxImport.Location = new System.Drawing.Point(1301, 44);
            this.ChkBxImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxImport.Name = "ChkBxImport";
            this.ChkBxImport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxImport.TabIndex = 59;
            this.ChkBxImport.OnChange += new System.EventHandler(this.ChkBxImport_OnChange);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(844, 104);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(196, 22);
            this.bunifuCustomLabel4.TabIndex = 66;
            this.bunifuCustomLabel4.Text = "اسم الجهة المراد المتابعة معها";
            // 
            // ChkBxExport
            // 
            this.ChkBxExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxExport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxExport.Checked = false;
            this.ChkBxExport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxExport.ForeColor = System.Drawing.Color.White;
            this.ChkBxExport.Location = new System.Drawing.Point(1301, 71);
            this.ChkBxExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxExport.Name = "ChkBxExport";
            this.ChkBxExport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxExport.TabIndex = 58;
            this.ChkBxExport.OnChange += new System.EventHandler(this.ChkBxExport_OnChange);
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
            // ChkBxImportExport
            // 
            this.ChkBxImportExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImportExport.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkBxImportExport.Checked = true;
            this.ChkBxImportExport.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkBxImportExport.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkBxImportExport.ForeColor = System.Drawing.Color.White;
            this.ChkBxImportExport.Location = new System.Drawing.Point(1301, 16);
            this.ChkBxImportExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBxImportExport.Name = "ChkBxImportExport";
            this.ChkBxImportExport.Size = new System.Drawing.Size(20, 20);
            this.ChkBxImportExport.TabIndex = 58;
            this.ChkBxImportExport.OnChange += new System.EventHandler(this.ChkBxImportExport_OnChange);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(844, 67);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(196, 22);
            this.bunifuCustomLabel5.TabIndex = 64;
            this.bunifuCustomLabel5.Text = "كود الجهة المراد المتابعة معها";
            // 
            // orgname
            // 
            this.orgname.BackColor = System.Drawing.Color.Beige;
            this.orgname.BorderColorFocused = System.Drawing.Color.Blue;
            this.orgname.BorderColorIdle = System.Drawing.Color.Blue;
            this.orgname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.orgname.BorderThickness = 3;
            this.orgname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orgname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgname.ForeColor = System.Drawing.Color.Black;
            this.orgname.isPassword = false;
            this.orgname.Location = new System.Drawing.Point(638, 97);
            this.orgname.Margin = new System.Windows.Forms.Padding(4);
            this.orgname.Name = "orgname";
            this.orgname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orgname.Size = new System.Drawing.Size(191, 34);
            this.orgname.TabIndex = 67;
            this.orgname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orgname.OnValueChanged += new System.EventHandler(this.orgname_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1236, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 22);
            this.bunifuCustomLabel1.TabIndex = 68;
            this.bunifuCustomLabel1.Text = "اسم المختص";
            // 
            // CmbBxUserName
            // 
            this.CmbBxUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxUserName.FormattingEnabled = true;
            this.CmbBxUserName.Location = new System.Drawing.Point(1072, 104);
            this.CmbBxUserName.Name = "CmbBxUserName";
            this.CmbBxUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbBxUserName.Size = new System.Drawing.Size(152, 27);
            this.CmbBxUserName.TabIndex = 69;
            this.CmbBxUserName.SelectedIndexChanged += new System.EventHandler(this.CmbBxUserName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.BothActive);
            this.panel1.Controls.Add(this.NotActive);
            this.panel1.Controls.Add(this.Active);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CmbBxUserName);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.orgname);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.ChkBxImportExport);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.ChkBxExport);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.ChkBxImport);
            this.panel1.Controls.Add(this.orgid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DatepickerEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel16);
            this.panel1.Controls.Add(this.bunifuCustomLabel15);
            this.panel1.Controls.Add(this.DatepickerStart);
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 144);
            this.panel1.TabIndex = 68;
            // 
            // BothActive
            // 
            this.BothActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.BothActive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.BothActive.Checked = true;
            this.BothActive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.BothActive.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BothActive.ForeColor = System.Drawing.Color.White;
            this.BothActive.Location = new System.Drawing.Point(593, 106);
            this.BothActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BothActive.Name = "BothActive";
            this.BothActive.Size = new System.Drawing.Size(20, 20);
            this.BothActive.TabIndex = 70;
            this.BothActive.OnChange += new System.EventHandler(this.BothActive_OnChange);
            // 
            // NotActive
            // 
            this.NotActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.NotActive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.NotActive.Checked = false;
            this.NotActive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.NotActive.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NotActive.ForeColor = System.Drawing.Color.White;
            this.NotActive.Location = new System.Drawing.Point(593, 80);
            this.NotActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotActive.Name = "NotActive";
            this.NotActive.Size = new System.Drawing.Size(20, 20);
            this.NotActive.TabIndex = 71;
            this.NotActive.OnChange += new System.EventHandler(this.NotActive_OnChange);
            // 
            // Active
            // 
            this.Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Active.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Active.Checked = false;
            this.Active.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Active.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Active.ForeColor = System.Drawing.Color.White;
            this.Active.Location = new System.Drawing.Point(593, 53);
            this.Active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(20, 20);
            this.Active.TabIndex = 72;
            this.Active.OnChange += new System.EventHandler(this.Active_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(478, 41);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(88, 34);
            this.label4.TabIndex = 73;
            this.label4.Text = "مطلوب الرد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(480, 103);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(35, 34);
            this.label5.TabIndex = 74;
            this.label5.Text = "الكل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Arabic Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(477, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 34);
            this.label6.TabIndex = 75;
            this.label6.Text = "تم الرد";
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
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.Beige;
            this.TxtUser.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtUser.BorderColorIdle = System.Drawing.Color.Blue;
            this.TxtUser.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtUser.BorderThickness = 3;
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Black;
            this.TxtUser.isPassword = false;
            this.TxtUser.Location = new System.Drawing.Point(1064, 38);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUser.Size = new System.Drawing.Size(42, 25);
            this.TxtUser.TabIndex = 84;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUser.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(31, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 42);
            this.button1.TabIndex = 85;
            this.button1.Text = "متابعة مكاتبات محددة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // FormFollowingOrgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBxUsers);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Name = "FormFollowingOrgs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة المتابعة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFollowing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportData ReportData;
        private System.Windows.Forms.BindingSource ReportDataBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerStart;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerEnd;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox orgid;
        private Bunifu.Framework.UI.BunifuCheckbox ChkBxImport;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox ChkBxExport;
        private System.Windows.Forms.Button BtnSearch;
        private Bunifu.Framework.UI.BunifuCheckbox ChkBxImportExport;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox orgname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox CmbBxUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBxUsers;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtUser;
        private Bunifu.Framework.UI.BunifuCheckbox BothActive;
        private Bunifu.Framework.UI.BunifuCheckbox NotActive;
        private Bunifu.Framework.UI.BunifuCheckbox Active;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}