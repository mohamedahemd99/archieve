namespace archive
{
    partial class FormReportItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportItem));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnformbrief = new System.Windows.Forms.Button();
            this.CmbBxName = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkBxExport2 = new System.Windows.Forms.CheckBox();
            this.ChkBxImport2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.TxtDate1);
            this.panel2.Controls.Add(this.TxtCon);
            this.panel2.Controls.Add(this.ChkBxExport2);
            this.panel2.Controls.Add(this.ChkBxImport2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnformbrief);
            this.panel2.Controls.Add(this.CmbBxName);
            this.panel2.Controls.Add(this.btnselect);
            this.panel2.Location = new System.Drawing.Point(1, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 132);
            this.panel2.TabIndex = 2;
            // 
            // btnformbrief
            // 
            this.btnformbrief.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnformbrief.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformbrief.Location = new System.Drawing.Point(11, 31);
            this.btnformbrief.Name = "btnformbrief";
            this.btnformbrief.Size = new System.Drawing.Size(181, 37);
            this.btnformbrief.TabIndex = 60;
            this.btnformbrief.Text = "تقرير مختصر";
            this.btnformbrief.UseVisualStyleBackColor = false;
            this.btnformbrief.Click += new System.EventHandler(this.btnformbrief_Click);
            // 
            // CmbBxName
            // 
            this.CmbBxName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxName.FormattingEnabled = true;
            this.CmbBxName.Location = new System.Drawing.Point(361, 31);
            this.CmbBxName.Name = "CmbBxName";
            this.CmbBxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbBxName.Size = new System.Drawing.Size(254, 25);
            this.CmbBxName.TabIndex = 27;
            this.CmbBxName.SelectedIndexChanged += new System.EventHandler(this.CmbBxName_SelectedIndexChanged);
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(25, 88);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(167, 37);
            this.btnselect.TabIndex = 21;
            this.btnselect.Text = "اختيار";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Visible = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // ReportViewerFollowing
            // 
            this.ReportViewerFollowing.LocalReport.ReportEmbeddedResource = "archive.Report5.rdlc";
            this.ReportViewerFollowing.Location = new System.Drawing.Point(5, 185);
            this.ReportViewerFollowing.Name = "ReportViewerFollowing";
            this.ReportViewerFollowing.ServerReport.BearerToken = null;
            this.ReportViewerFollowing.Size = new System.Drawing.Size(1353, 511);
            this.ReportViewerFollowing.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 44);
            this.panel1.TabIndex = 59;
            // 
            // ChkBxExport2
            // 
            this.ChkBxExport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxExport2.Location = new System.Drawing.Point(1271, 61);
            this.ChkBxExport2.Name = "ChkBxExport2";
            this.ChkBxExport2.Size = new System.Drawing.Size(15, 14);
            this.ChkBxExport2.TabIndex = 98;
            this.ChkBxExport2.UseVisualStyleBackColor = true;
            this.ChkBxExport2.CheckedChanged += new System.EventHandler(this.ChkBxExport2_OnChange);
            // 
            // ChkBxImport2
            // 
            this.ChkBxImport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxImport2.Location = new System.Drawing.Point(1271, 29);
            this.ChkBxImport2.Name = "ChkBxImport2";
            this.ChkBxImport2.Size = new System.Drawing.Size(15, 14);
            this.ChkBxImport2.TabIndex = 97;
            this.ChkBxImport2.UseVisualStyleBackColor = true;
            this.ChkBxImport2.CheckedChanged += new System.EventHandler(this.ChkBxImport2_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1195, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "رقم صادر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1201, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 96;
            this.label4.Text = "رقم وارد";
            // 
            // TxtCon
            // 
            this.TxtCon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCon.ForeColor = System.Drawing.Color.Black;
            this.TxtCon.Location = new System.Drawing.Point(955, 30);
            this.TxtCon.Name = "TxtCon";
            this.TxtCon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCon.Size = new System.Drawing.Size(111, 26);
            this.TxtCon.TabIndex = 99;
            this.TxtCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCon_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1072, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "رقم المكاتبة";
            // 
            // TxtDate1
            // 
            this.TxtDate1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtDate1.ForeColor = System.Drawing.Color.Black;
            this.TxtDate1.Location = new System.Drawing.Point(753, 30);
            this.TxtDate1.Name = "TxtDate1";
            this.TxtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDate1.Size = new System.Drawing.Size(90, 26);
            this.TxtDate1.TabIndex = 99;
            this.TxtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCon_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(849, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 95;
            this.label3.Text = "السنة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(621, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 95;
            this.label5.Text = "الوصف";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.Location = new System.Drawing.Point(495, 77);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(139, 46);
            this.deleteBtn.TabIndex = 100;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Location = new System.Drawing.Point(688, 79);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(152, 41);
            this.addBtn.TabIndex = 101;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(646, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 32);
            this.label6.TabIndex = 102;
            this.label6.Text = "أختيار مكاتبات محددة";
            // 
            // FormReportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Controls.Add(this.panel2);
            this.Name = "FormReportItem";
            this.Text = "اختيار مكاتبة محددة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnselect;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnformbrief;
        private System.Windows.Forms.ComboBox CmbBxName;
        private System.Windows.Forms.CheckBox ChkBxExport2;
        private System.Windows.Forms.CheckBox ChkBxImport2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDate1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label6;
    }
}