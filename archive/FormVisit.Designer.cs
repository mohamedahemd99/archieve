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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisit));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportDataVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvVisit = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DateEndVisit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnDeleteVisit = new System.Windows.Forms.Button();
            this.BtnEditVisit = new System.Windows.Forms.Button();
            this.BtnAddVisit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateStartVisit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.TxtImportID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtOrg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtorgVisit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtsubject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ReportViewerVisit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatepickerStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DatepickerEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtExportID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataVisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportDataVisitBindingSource
            // 
            this.ReportDataVisitBindingSource.DataMember = "ReportDataVisit";
            // 
            // DgvVisit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvVisit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvVisit.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvVisit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvVisit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVisit.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvVisit.DoubleBuffered = true;
            this.DgvVisit.EnableHeadersVisualStyles = false;
            this.DgvVisit.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.DgvVisit.HeaderForeColor = System.Drawing.Color.Black;
            this.DgvVisit.Location = new System.Drawing.Point(12, 340);
            this.DgvVisit.Name = "DgvVisit";
            this.DgvVisit.ReadOnly = true;
            this.DgvVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvVisit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvVisit.Size = new System.Drawing.Size(1338, 334);
            this.DgvVisit.TabIndex = 1;
            this.DgvVisit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisit_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.TxtExportID);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.DateEndVisit);
            this.panel1.Controls.Add(this.BtnDeleteVisit);
            this.panel1.Controls.Add(this.BtnEditVisit);
            this.panel1.Controls.Add(this.BtnAddVisit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DateStartVisit);
            this.panel1.Controls.Add(this.TxtImportID);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.TxtOrg);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.TxtorgVisit);
            this.panel1.Controls.Add(this.Txtsubject);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 244);
            this.panel1.TabIndex = 2;
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
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(766, 202);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(163, 29);
            this.bunifuCustomLabel8.TabIndex = 72;
            this.bunifuCustomLabel8.Text = "تاريخ نهاية الزيارة";
            // 
            // DateEndVisit
            // 
            this.DateEndVisit.BackColor = System.Drawing.Color.MidnightBlue;
            this.DateEndVisit.BorderRadius = 0;
            this.DateEndVisit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEndVisit.ForeColor = System.Drawing.Color.White;
            this.DateEndVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEndVisit.FormatCustom = "yyyy-MM-dd";
            this.DateEndVisit.Location = new System.Drawing.Point(536, 204);
            this.DateEndVisit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DateEndVisit.Name = "DateEndVisit";
            this.DateEndVisit.Size = new System.Drawing.Size(204, 27);
            this.DateEndVisit.TabIndex = 71;
            this.DateEndVisit.Value = new System.DateTime(2019, 4, 2, 0, 0, 0, 0);
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
            // DateStartVisit
            // 
            this.DateStartVisit.BackColor = System.Drawing.Color.DodgerBlue;
            this.DateStartVisit.BorderRadius = 0;
            this.DateStartVisit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStartVisit.ForeColor = System.Drawing.Color.White;
            this.DateStartVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartVisit.FormatCustom = "yyyy-MM-dd";
            this.DateStartVisit.Location = new System.Drawing.Point(974, 202);
            this.DateStartVisit.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.DateStartVisit.Name = "DateStartVisit";
            this.DateStartVisit.Size = new System.Drawing.Size(196, 29);
            this.DateStartVisit.TabIndex = 64;
            this.DateStartVisit.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DateStartVisit.onValueChanged += new System.EventHandler(this.DateVisit_onValueChanged);
            // 
            // TxtImportID
            // 
            this.TxtImportID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtImportID.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtImportID.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtImportID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtImportID.BorderThickness = 3;
            this.TxtImportID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtImportID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImportID.ForeColor = System.Drawing.Color.Black;
            this.TxtImportID.isPassword = false;
            this.TxtImportID.Location = new System.Drawing.Point(739, 55);
            this.TxtImportID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtImportID.Name = "TxtImportID";
            this.TxtImportID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtImportID.Size = new System.Drawing.Size(91, 33);
            this.TxtImportID.TabIndex = 22;
            this.TxtImportID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtImportID.OnValueChanged += new System.EventHandler(this.TxtImportID_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(848, 56);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 29);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "رقم الوارد";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // TxtOrg
            // 
            this.TxtOrg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtOrg.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtOrg.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtOrg.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtOrg.BorderThickness = 3;
            this.TxtOrg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOrg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrg.ForeColor = System.Drawing.Color.Black;
            this.TxtOrg.isPassword = false;
            this.TxtOrg.Location = new System.Drawing.Point(997, 52);
            this.TxtOrg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtOrg.Name = "TxtOrg";
            this.TxtOrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrg.Size = new System.Drawing.Size(231, 38);
            this.TxtOrg.TabIndex = 20;
            this.TxtOrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtOrg.OnValueChanged += new System.EventHandler(this.TxtOrg_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1262, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 29);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "الجهة";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1185, 202);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 29);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "تاريخ بداية الزيارة";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // TxtorgVisit
            // 
            this.TxtorgVisit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtorgVisit.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtorgVisit.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtorgVisit.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtorgVisit.BorderThickness = 3;
            this.TxtorgVisit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtorgVisit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtorgVisit.ForeColor = System.Drawing.Color.Black;
            this.TxtorgVisit.isPassword = false;
            this.TxtorgVisit.Location = new System.Drawing.Point(997, 98);
            this.TxtorgVisit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtorgVisit.Name = "TxtorgVisit";
            this.TxtorgVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtorgVisit.Size = new System.Drawing.Size(231, 37);
            this.TxtorgVisit.TabIndex = 12;
            this.TxtorgVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtorgVisit.OnValueChanged += new System.EventHandler(this.TxtorgVisit_OnValueChanged);
            // 
            // Txtsubject
            // 
            this.Txtsubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txtsubject.BorderColorFocused = System.Drawing.Color.Blue;
            this.Txtsubject.BorderColorIdle = System.Drawing.Color.Navy;
            this.Txtsubject.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Txtsubject.BorderThickness = 3;
            this.Txtsubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtsubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsubject.ForeColor = System.Drawing.Color.Black;
            this.Txtsubject.isPassword = false;
            this.Txtsubject.Location = new System.Drawing.Point(746, 143);
            this.Txtsubject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtsubject.Name = "Txtsubject";
            this.Txtsubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txtsubject.Size = new System.Drawing.Size(482, 41);
            this.Txtsubject.TabIndex = 10;
            this.Txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(1253, 143);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(88, 29);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "الموضوع";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(1238, 106);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(106, 29);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "جهة الزيارة";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
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
            // DatepickerStart
            // 
            this.DatepickerStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.DatepickerStart.BorderRadius = 0;
            this.DatepickerStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerStart.ForeColor = System.Drawing.Color.White;
            this.DatepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerStart.FormatCustom = "yyyy-MM-dd";
            this.DatepickerStart.Location = new System.Drawing.Point(728, 268);
            this.DatepickerStart.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.DatepickerStart.Name = "DatepickerStart";
            this.DatepickerStart.Size = new System.Drawing.Size(179, 24);
            this.DatepickerStart.TabIndex = 63;
            this.DatepickerStart.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // DatepickerEnd
            // 
            this.DatepickerEnd.BackColor = System.Drawing.Color.Turquoise;
            this.DatepickerEnd.BorderRadius = 0;
            this.DatepickerEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepickerEnd.ForeColor = System.Drawing.Color.White;
            this.DatepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerEnd.FormatCustom = "yyyy-MM-dd";
            this.DatepickerEnd.Location = new System.Drawing.Point(467, 265);
            this.DatepickerEnd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DatepickerEnd.Name = "DatepickerEnd";
            this.DatepickerEnd.Size = new System.Drawing.Size(188, 27);
            this.DatepickerEnd.TabIndex = 62;
            this.DatepickerEnd.Value = new System.DateTime(2019, 4, 2, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(684, 263);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(32, 24);
            this.bunifuCustomLabel15.TabIndex = 60;
            this.bunifuCustomLabel15.Text = "الى";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(911, 268);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(30, 24);
            this.bunifuCustomLabel16.TabIndex = 61;
            this.bunifuCustomLabel16.Text = "من";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(947, 268);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(88, 22);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "تاريخ الزيارة";
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
            // TxtExportID
            // 
            this.TxtExportID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtExportID.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtExportID.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtExportID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtExportID.BorderThickness = 3;
            this.TxtExportID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtExportID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExportID.ForeColor = System.Drawing.Color.Black;
            this.TxtExportID.isPassword = false;
            this.TxtExportID.Location = new System.Drawing.Point(739, 102);
            this.TxtExportID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtExportID.Name = "TxtExportID";
            this.TxtExportID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtExportID.Size = new System.Drawing.Size(91, 33);
            this.TxtExportID.TabIndex = 80;
            this.TxtExportID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtExportID.OnValueChanged += new System.EventHandler(this.TxtExportID_OnValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(848, 103);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 29);
            this.bunifuCustomLabel4.TabIndex = 81;
            this.bunifuCustomLabel4.Text = "رقم الصادر";
            // 
            // FormVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DatepickerStart);
            this.Controls.Add(this.DatepickerEnd);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.ReportViewerVisit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvVisit);
            this.Name = "FormVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة الزيارات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataVisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvVisit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtorgVisit;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtsubject;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtImportID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtOrg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerVisit;
        private System.Windows.Forms.BindingSource ReportDataVisitBindingSource;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerStart;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerEnd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker DateStartVisit;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDeleteVisit;
        private System.Windows.Forms.Button BtnEditVisit;
        private System.Windows.Forms.Button BtnAddVisit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuDatepicker DateEndVisit;
        private System.Windows.Forms.Button BtnClear;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtExportID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}