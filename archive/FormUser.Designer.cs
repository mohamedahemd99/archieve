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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.TxtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtUserId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvUser = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnDeleteUser);
            this.panel1.Controls.Add(this.BtnEditUser);
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.TxtUserId);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Location = new System.Drawing.Point(941, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 743);
            this.panel1.TabIndex = 1;
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
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUserName.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtUserName.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtUserName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtUserName.BorderThickness = 3;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.isPassword = false;
            this.TxtUserName.Location = new System.Drawing.Point(5, 198);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUserName.Size = new System.Drawing.Size(270, 38);
            this.TxtUserName.TabIndex = 12;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtUserId
            // 
            this.TxtUserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUserId.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtUserId.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtUserId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtUserId.BorderThickness = 3;
            this.TxtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserId.ForeColor = System.Drawing.Color.Black;
            this.TxtUserId.isPassword = false;
            this.TxtUserId.Location = new System.Drawing.Point(188, 136);
            this.TxtUserId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUserId.Size = new System.Drawing.Size(87, 34);
            this.TxtUserId.TabIndex = 10;
            this.TxtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUserId.OnValueChanged += new System.EventHandler(this.TxtUserId_OnValueChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(283, 136);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(135, 34);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "كود المختص";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(283, 200);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(136, 34);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "اسم المختص";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtSearch.BorderColorIdle = System.Drawing.Color.Navy;
            this.TxtSearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtSearch.BorderThickness = 3;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSearch.isPassword = false;
            this.TxtSearch.Location = new System.Drawing.Point(552, 49);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(290, 34);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSearch.OnValueChanged += new System.EventHandler(this.TxtSearch_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(868, 49);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(57, 34);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "بحث";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvUser);
            this.panel2.Location = new System.Drawing.Point(452, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 442);
            this.panel2.TabIndex = 18;
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToAddRows = false;
            this.DgvUser.AllowUserToDeleteRows = false;
            this.DgvUser.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUser.DoubleBuffered = true;
            this.DgvUser.EnableHeadersVisualStyles = false;
            this.DgvUser.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.DgvUser.HeaderForeColor = System.Drawing.Color.Black;
            this.DgvUser.Location = new System.Drawing.Point(3, -4);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.ReadOnly = true;
            this.DgvUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvUser.Size = new System.Drawing.Size(483, 439);
            this.DgvUser.TabIndex = 0;
            this.DgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
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
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel1);
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
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtUserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtUserId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Panel panel4;
    }
}