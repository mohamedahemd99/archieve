namespace archive
{
    partial class FormFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.BtnEditFile = new System.Windows.Forms.Button();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnDeleteFileSub = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEditFileSub = new System.Windows.Forms.Button();
            this.BtnAddFileSub = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFileId = new System.Windows.Forms.TextBox();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.TxtFileNameSub = new System.Windows.Forms.TextBox();
            this.TxtFileidSub = new System.Windows.Forms.TextBox();
            this.TxtSearchSub = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvFile = new System.Windows.Forms.DataGridView();
            this.DgvFileSub = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFileSub)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.TxtFileName);
            this.panel1.Controls.Add(this.TxtFileId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.BtnDeleteFile);
            this.panel1.Controls.Add(this.BtnEditFile);
            this.panel1.Controls.Add(this.BtnAddFile);
            this.panel1.Location = new System.Drawing.Point(913, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 332);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(310, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 57;
            this.label1.Text = "اسم الملف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(310, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 57;
            this.label2.Text = "كود الملف";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(74, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(316, 54);
            this.panel6.TabIndex = 32;
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDeleteFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteFile.BackgroundImage")));
            this.BtnDeleteFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteFile.Location = new System.Drawing.Point(138, 269);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(220, 46);
            this.BtnDeleteFile.TabIndex = 30;
            this.BtnDeleteFile.UseVisualStyleBackColor = false;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // BtnEditFile
            // 
            this.BtnEditFile.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditFile.BackgroundImage")));
            this.BtnEditFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditFile.Location = new System.Drawing.Point(138, 208);
            this.BtnEditFile.Name = "BtnEditFile";
            this.BtnEditFile.Size = new System.Drawing.Size(220, 55);
            this.BtnEditFile.TabIndex = 29;
            this.BtnEditFile.UseVisualStyleBackColor = false;
            this.BtnEditFile.Click += new System.EventHandler(this.BtnEditFile_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAddFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddFile.BackgroundImage")));
            this.BtnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddFile.Location = new System.Drawing.Point(138, 153);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(220, 49);
            this.BtnAddFile.TabIndex = 28;
            this.BtnAddFile.UseVisualStyleBackColor = false;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.TxtFileNameSub);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtFileidSub);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.BtnDeleteFileSub);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnEditFileSub);
            this.panel2.Controls.Add(this.BtnAddFileSub);
            this.panel2.Location = new System.Drawing.Point(912, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 403);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(312, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 57;
            this.label5.Text = "اسم الملف";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(75, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(316, 54);
            this.panel7.TabIndex = 34;
            // 
            // BtnDeleteFileSub
            // 
            this.BtnDeleteFileSub.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDeleteFileSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteFileSub.BackgroundImage")));
            this.BtnDeleteFileSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteFileSub.Location = new System.Drawing.Point(158, 281);
            this.BtnDeleteFileSub.Name = "BtnDeleteFileSub";
            this.BtnDeleteFileSub.Size = new System.Drawing.Size(188, 48);
            this.BtnDeleteFileSub.TabIndex = 33;
            this.BtnDeleteFileSub.UseVisualStyleBackColor = false;
            this.BtnDeleteFileSub.Click += new System.EventHandler(this.BtnDeleteFileSub_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(312, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 57;
            this.label4.Text = "كود الملف";
            // 
            // BtnEditFileSub
            // 
            this.BtnEditFileSub.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditFileSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditFileSub.BackgroundImage")));
            this.BtnEditFileSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditFileSub.Location = new System.Drawing.Point(158, 222);
            this.BtnEditFileSub.Name = "BtnEditFileSub";
            this.BtnEditFileSub.Size = new System.Drawing.Size(188, 53);
            this.BtnEditFileSub.TabIndex = 32;
            this.BtnEditFileSub.UseVisualStyleBackColor = false;
            this.BtnEditFileSub.Click += new System.EventHandler(this.BtnEditFileSub_Click);
            // 
            // BtnAddFileSub
            // 
            this.BtnAddFileSub.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAddFileSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddFileSub.BackgroundImage")));
            this.BtnAddFileSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddFileSub.Location = new System.Drawing.Point(158, 158);
            this.BtnAddFileSub.Name = "BtnAddFileSub";
            this.BtnAddFileSub.Size = new System.Drawing.Size(188, 58);
            this.BtnAddFileSub.TabIndex = 31;
            this.BtnAddFileSub.UseVisualStyleBackColor = false;
            this.BtnAddFileSub.Click += new System.EventHandler(this.BtnAddFileSub_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvFile);
            this.panel3.Location = new System.Drawing.Point(363, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 322);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgvFileSub);
            this.panel4.Location = new System.Drawing.Point(366, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 286);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(32, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 242);
            this.panel5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(833, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 32);
            this.label3.TabIndex = 57;
            this.label3.Text = "بحث";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(781, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 32);
            this.label6.TabIndex = 57;
            this.label6.Text = "بحث";
            // 
            // TxtFileId
            // 
            this.TxtFileId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtFileId.ForeColor = System.Drawing.Color.Black;
            this.TxtFileId.Location = new System.Drawing.Point(226, 62);
            this.TxtFileId.Name = "TxtFileId";
            this.TxtFileId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtFileId.Size = new System.Drawing.Size(78, 29);
            this.TxtFileId.TabIndex = 67;
            this.TxtFileId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFileId.TextChanged += new System.EventHandler(this.TxtFileId_OnValueChanged);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtFileName.ForeColor = System.Drawing.Color.Black;
            this.TxtFileName.Location = new System.Drawing.Point(18, 108);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtFileName.Size = new System.Drawing.Size(289, 29);
            this.TxtFileName.TabIndex = 67;
            this.TxtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFileName.TextChanged += new System.EventHandler(this.TxtFileName_OnValueChanged);
            // 
            // TxtFileNameSub
            // 
            this.TxtFileNameSub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtFileNameSub.ForeColor = System.Drawing.Color.Black;
            this.TxtFileNameSub.Location = new System.Drawing.Point(19, 109);
            this.TxtFileNameSub.Name = "TxtFileNameSub";
            this.TxtFileNameSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtFileNameSub.Size = new System.Drawing.Size(289, 29);
            this.TxtFileNameSub.TabIndex = 68;
            this.TxtFileNameSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFileidSub
            // 
            this.TxtFileidSub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtFileidSub.ForeColor = System.Drawing.Color.Black;
            this.TxtFileidSub.Location = new System.Drawing.Point(227, 64);
            this.TxtFileidSub.Name = "TxtFileidSub";
            this.TxtFileidSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtFileidSub.Size = new System.Drawing.Size(78, 29);
            this.TxtFileidSub.TabIndex = 69;
            this.TxtFileidSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSearchSub
            // 
            this.TxtSearchSub.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSearchSub.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchSub.Location = new System.Drawing.Point(477, 368);
            this.TxtSearchSub.Name = "TxtSearchSub";
            this.TxtSearchSub.Size = new System.Drawing.Size(289, 23);
            this.TxtSearchSub.TabIndex = 70;
            this.TxtSearchSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchSub.TextChanged += new System.EventHandler(this.TxtSearchSub_OnValueChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(527, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(289, 23);
            this.TxtSearch.TabIndex = 71;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_OnValueChanged);
            // 
            // DgvFile
            // 
            this.DgvFile.AllowUserToAddRows = false;
            this.DgvFile.AllowUserToDeleteRows = false;
            this.DgvFile.AllowUserToOrderColumns = true;
            this.DgvFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFile.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFile.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvFile.Location = new System.Drawing.Point(0, 3);
            this.DgvFile.Name = "DgvFile";
            this.DgvFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvFile.RowHeadersWidth = 60;
            this.DgvFile.Size = new System.Drawing.Size(543, 316);
            this.DgvFile.TabIndex = 45;
            this.DgvFile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFile_CellClick);
            // 
            // DgvFileSub
            // 
            this.DgvFileSub.AllowUserToAddRows = false;
            this.DgvFileSub.AllowUserToDeleteRows = false;
            this.DgvFileSub.AllowUserToOrderColumns = true;
            this.DgvFileSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFileSub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvFileSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFileSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvFileSub.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFileSub.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvFileSub.Location = new System.Drawing.Point(3, 3);
            this.DgvFileSub.Name = "DgvFileSub";
            this.DgvFileSub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFileSub.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvFileSub.RowHeadersWidth = 60;
            this.DgvFileSub.Size = new System.Drawing.Size(525, 283);
            this.DgvFileSub.TabIndex = 46;
            this.DgvFileSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFileSub_CellClick);
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtSearchSub);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة الملفات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFileSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnDeleteFile;
        private System.Windows.Forms.Button BtnEditFile;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.Button BtnDeleteFileSub;
        private System.Windows.Forms.Button BtnEditFileSub;
        private System.Windows.Forms.Button BtnAddFileSub;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFileId;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.TextBox TxtFileNameSub;
        private System.Windows.Forms.TextBox TxtFileidSub;
        private System.Windows.Forms.TextBox TxtSearchSub;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvFile;
        private System.Windows.Forms.DataGridView DgvFileSub;
    }
}