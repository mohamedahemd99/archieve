namespace archive
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblerr = new System.Windows.Forms.Label();
            this.CmbBxUserName = new System.Windows.Forms.ComboBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.PanelServer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PanelServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.BackColor = System.Drawing.Color.White;
            this.lblerr.Location = new System.Drawing.Point(72, 377);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(35, 13);
            this.lblerr.TabIndex = 26;
            this.lblerr.Text = "label1";
            this.lblerr.Visible = false;
            // 
            // CmbBxUserName
            // 
            this.CmbBxUserName.BackColor = System.Drawing.Color.White;
            this.CmbBxUserName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxUserName.FormattingEnabled = true;
            this.CmbBxUserName.Location = new System.Drawing.Point(95, 253);
            this.CmbBxUserName.Name = "CmbBxUserName";
            this.CmbBxUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbBxUserName.Size = new System.Drawing.Size(201, 34);
            this.CmbBxUserName.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.Location = new System.Drawing.Point(53, 405);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(222, 56);
            this.btnlogin.TabIndex = 63;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // PanelServer
            // 
            this.PanelServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelServer.BackgroundImage")));
            this.PanelServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelServer.Controls.Add(this.label4);
            this.PanelServer.Controls.Add(this.txtPassword);
            this.PanelServer.Controls.Add(this.btnlogin);
            this.PanelServer.Controls.Add(this.CmbBxUserName);
            this.PanelServer.Controls.Add(this.lblerr);
            this.PanelServer.Location = new System.Drawing.Point(1, -1);
            this.PanelServer.Name = "PanelServer";
            this.PanelServer.Size = new System.Drawing.Size(351, 472);
            this.PanelServer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(326, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.close_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(95, 300);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(201, 34);
            this.txtPassword.TabIndex = 82;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(353, 473);
            this.ControlBox = false;
            this.Controls.Add(this.PanelServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.PanelServer.ResumeLayout(false);
            this.PanelServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblerr;
        private System.Windows.Forms.ComboBox CmbBxUserName;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel PanelServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
    }
}