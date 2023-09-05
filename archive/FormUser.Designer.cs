namespace archive
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.TxtUserId);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnDeleteUser);
            this.panel1.Controls.Add(this.BtnEditUser);
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Location = new System.Drawing.Point(941, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 743);
            this.panel1.TabIndex = 1;
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtUserId.ForeColor = System.Drawing.Color.Black;
            this.TxtUserId.Location = new System.Drawing.Point(189, 141);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(87, 29);
            this.TxtUserId.TabIndex = 66;
            this.TxtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.Location = new System.Drawing.Point(6, 194);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(270, 29);
            this.TxtUserName.TabIndex = 66;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18.56F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(281, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 55;
            this.label1.Text = "اسم المختص";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(282, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 54;
            this.label10.Text = "كود المختص";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(48, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 71);
            this.panel4.TabIndex = 32;
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteUser.BackgroundImage")));
            this.BtnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteUser.Location = new System.Drawing.Point(86, 497);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(265, 58);
            this.BtnDeleteUser.TabIndex = 30;
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click_1);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditUser.BackgroundImage")));
            this.BtnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditUser.Location = new System.Drawing.Point(86, 388);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(265, 68);
            this.BtnEditUser.TabIndex = 29;
            this.BtnEditUser.UseVisualStyleBackColor = false;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click_1);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddUser.BackgroundImage")));
            this.BtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddUser.Location = new System.Drawing.Point(86, 291);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(265, 59);
            this.BtnAddUser.TabIndex = 28;
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvUser);
            this.panel2.Location = new System.Drawing.Point(452, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 442);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(-1, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 446);
            this.panel3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(858, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 56;
            this.label2.Text = "بحث";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(573, 49);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(270, 29);
            this.TxtSearch.TabIndex = 66;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_OnValueChanged);
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToAddRows = false;
            this.DgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUser.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUser.Location = new System.Drawing.Point(15, 3);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUser.RowHeadersWidth = 60;
            this.DgvUser.Size = new System.Drawing.Size(468, 436);
            this.DgvUser.TabIndex = 44;
            this.DgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة المختصون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvUser;
    }
}