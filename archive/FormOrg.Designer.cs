namespace archive
{
    partial class FormOrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnDeleteOrg = new System.Windows.Forms.Button();
            this.BtnEditOrg = new System.Windows.Forms.Button();
            this.ButnAddOrg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtOrgId = new System.Windows.Forms.TextBox();
            this.TxtOrgName = new System.Windows.Forms.TextBox();
            this.DgvOrg = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.TxtOrgName);
            this.panel1.Controls.Add(this.TxtOrgId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnDeleteOrg);
            this.panel1.Controls.Add(this.BtnEditOrg);
            this.panel1.Controls.Add(this.ButnAddOrg);
            this.panel1.Location = new System.Drawing.Point(927, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 743);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(314, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 55;
            this.label10.Text = "كود الجهة";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(42, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 64);
            this.panel4.TabIndex = 32;
            // 
            // BtnDeleteOrg
            // 
            this.BtnDeleteOrg.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDeleteOrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteOrg.BackgroundImage")));
            this.BtnDeleteOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteOrg.Location = new System.Drawing.Point(106, 485);
            this.BtnDeleteOrg.Name = "BtnDeleteOrg";
            this.BtnDeleteOrg.Size = new System.Drawing.Size(265, 58);
            this.BtnDeleteOrg.TabIndex = 27;
            this.BtnDeleteOrg.UseVisualStyleBackColor = false;
            this.BtnDeleteOrg.Click += new System.EventHandler(this.BtnDeleteOrgClick);
            // 
            // BtnEditOrg
            // 
            this.BtnEditOrg.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditOrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditOrg.BackgroundImage")));
            this.BtnEditOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditOrg.Location = new System.Drawing.Point(106, 369);
            this.BtnEditOrg.Name = "BtnEditOrg";
            this.BtnEditOrg.Size = new System.Drawing.Size(265, 68);
            this.BtnEditOrg.TabIndex = 26;
            this.BtnEditOrg.UseVisualStyleBackColor = false;
            this.BtnEditOrg.Click += new System.EventHandler(this.BtnEditOrgClick);
            // 
            // ButnAddOrg
            // 
            this.ButnAddOrg.BackColor = System.Drawing.Color.PapayaWhip;
            this.ButnAddOrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButnAddOrg.BackgroundImage")));
            this.ButnAddOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButnAddOrg.Location = new System.Drawing.Point(106, 259);
            this.ButnAddOrg.Name = "ButnAddOrg";
            this.ButnAddOrg.Size = new System.Drawing.Size(265, 59);
            this.ButnAddOrg.TabIndex = 25;
            this.ButnAddOrg.UseVisualStyleBackColor = false;
            this.ButnAddOrg.Click += new System.EventHandler(this.BtnAddOrgClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvOrg);
            this.panel2.Location = new System.Drawing.Point(472, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 399);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(-12, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 754);
            this.panel3.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Location = new System.Drawing.Point(247, 435);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(180, 156);
            this.panel12.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(38, 420);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(145, 171);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(24, 245);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(207, 137);
            this.panel10.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(237, 245);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 151);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(83, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 219);
            this.panel8.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "archive.oranizationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(475, 566);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(426, 100);
            this.reportViewer1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(313, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "اسم الجهة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(760, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "بحث عن جهة";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(484, 87);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSearch.Size = new System.Drawing.Size(270, 23);
            this.TxtSearch.TabIndex = 67;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_OnValueChanged_1);
            // 
            // TxtOrgId
            // 
            this.TxtOrgId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtOrgId.ForeColor = System.Drawing.Color.Black;
            this.TxtOrgId.Location = new System.Drawing.Point(210, 136);
            this.TxtOrgId.Name = "TxtOrgId";
            this.TxtOrgId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrgId.Size = new System.Drawing.Size(87, 26);
            this.TxtOrgId.TabIndex = 68;
            this.TxtOrgId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOrgId.TextChanged += new System.EventHandler(this.TxtOrgId_OnValueChanged);
            // 
            // TxtOrgName
            // 
            this.TxtOrgName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtOrgName.ForeColor = System.Drawing.Color.Black;
            this.TxtOrgName.Location = new System.Drawing.Point(5, 184);
            this.TxtOrgName.Name = "TxtOrgName";
            this.TxtOrgName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrgName.Size = new System.Drawing.Size(292, 26);
            this.TxtOrgName.TabIndex = 69;
            this.TxtOrgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOrgName.TextChanged += new System.EventHandler(this.TxtOrgName_OnValueChanged);
            // 
            // DgvOrg
            // 
            this.DgvOrg.AllowUserToAddRows = false;
            this.DgvOrg.AllowUserToDeleteRows = false;
            this.DgvOrg.AllowUserToOrderColumns = true;
            this.DgvOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOrg.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOrg.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOrg.Location = new System.Drawing.Point(3, 3);
            this.DgvOrg.Name = "DgvOrg";
            this.DgvOrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvOrg.RowHeadersWidth = 60;
            this.DgvOrg.Size = new System.Drawing.Size(446, 393);
            this.DgvOrg.TabIndex = 70;
            this.DgvOrg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrg_CellClick);
            // 
            // FormOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z`";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button ButnAddOrg;
        private System.Windows.Forms.Button BtnEditOrg;
        private System.Windows.Forms.Button BtnDeleteOrg;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtOrgId;
        private System.Windows.Forms.TextBox TxtOrgName;
        private System.Windows.Forms.DataGridView DgvOrg;
    }
}