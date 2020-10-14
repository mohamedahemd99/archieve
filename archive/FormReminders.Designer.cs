namespace archive
{
    partial class FormReminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReminders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_report_btn = new System.Windows.Forms.Button();
            this.remindersTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.show_all_coming_btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDeleteVisit = new System.Windows.Forms.Button();
            this.BtnEditReminder = new System.Windows.Forms.Button();
            this.BtnAddReminder = new System.Windows.Forms.Button();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.title_combobox = new System.Windows.Forms.ComboBox();
            this.txt_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DgvReminders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.show_report_btn);
            this.panel1.Controls.Add(this.remindersTotalTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.description_richTextBox);
            this.panel1.Controls.Add(this.show_all_btn);
            this.panel1.Controls.Add(this.show_all_coming_btn);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDeleteVisit);
            this.panel1.Controls.Add(this.BtnEditReminder);
            this.panel1.Controls.Add(this.BtnAddReminder);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 303);
            this.panel1.TabIndex = 3;
            // 
            // show_report_btn
            // 
            this.show_report_btn.BackColor = System.Drawing.Color.Teal;
            this.show_report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_report_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_report_btn.Location = new System.Drawing.Point(227, 249);
            this.show_report_btn.Name = "show_report_btn";
            this.show_report_btn.Size = new System.Drawing.Size(197, 40);
            this.show_report_btn.TabIndex = 93;
            this.show_report_btn.Text = "عرض تقرير المتابعة";
            this.show_report_btn.UseVisualStyleBackColor = false;
            this.show_report_btn.Click += new System.EventHandler(this.show_report_btn_Click);
            // 
            // remindersTotalTextBox
            // 
            this.remindersTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remindersTotalTextBox.Location = new System.Drawing.Point(32, 253);
            this.remindersTotalTextBox.Name = "remindersTotalTextBox";
            this.remindersTotalTextBox.ReadOnly = true;
            this.remindersTotalTextBox.Size = new System.Drawing.Size(61, 29);
            this.remindersTotalTextBox.TabIndex = 92;
            this.remindersTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "عدد المتابعات";
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_title.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_title.BorderColorIdle = System.Drawing.Color.Navy;
            this.txt_title.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_title.BorderThickness = 3;
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.Black;
            this.txt_title.isPassword = false;
            this.txt_title.Location = new System.Drawing.Point(699, 84);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_title.Name = "txt_title";
            this.txt_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_title.Size = new System.Drawing.Size(517, 34);
            this.txt_title.TabIndex = 90;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_richTextBox.Location = new System.Drawing.Point(626, 142);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description_richTextBox.Size = new System.Drawing.Size(590, 79);
            this.description_richTextBox.TabIndex = 80;
            this.description_richTextBox.Text = "";
            // 
            // show_all_btn
            // 
            this.show_all_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.show_all_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_all_btn.Location = new System.Drawing.Point(227, 150);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(197, 40);
            this.show_all_btn.TabIndex = 86;
            this.show_all_btn.Text = "عرض كل المتابعات";
            this.show_all_btn.UseVisualStyleBackColor = false;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // show_all_coming_btn
            // 
            this.show_all_coming_btn.BackColor = System.Drawing.Color.Olive;
            this.show_all_coming_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all_coming_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_all_coming_btn.Location = new System.Drawing.Point(227, 199);
            this.show_all_coming_btn.Name = "show_all_coming_btn";
            this.show_all_coming_btn.Size = new System.Drawing.Size(197, 40);
            this.show_all_coming_btn.TabIndex = 85;
            this.show_all_coming_btn.Text = "عرض كل المتابعات القادمة";
            this.show_all_coming_btn.UseVisualStyleBackColor = false;
            this.show_all_coming_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(1247, 84);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(88, 29);
            this.bunifuCustomLabel10.TabIndex = 84;
            this.bunifuCustomLabel10.Text = "الموضوع";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Blue;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(583, 9);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(280, 40);
            this.bunifuCustomLabel9.TabIndex = 82;
            this.bunifuCustomLabel9.Text = "متابعة السيد نائب المدير";
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
            // BtnEditReminder
            // 
            this.BtnEditReminder.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnEditReminder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditReminder.BackgroundImage")));
            this.BtnEditReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditReminder.Location = new System.Drawing.Point(28, 78);
            this.BtnEditReminder.Name = "BtnEditReminder";
            this.BtnEditReminder.Size = new System.Drawing.Size(159, 49);
            this.BtnEditReminder.TabIndex = 69;
            this.BtnEditReminder.UseVisualStyleBackColor = false;
            this.BtnEditReminder.Click += new System.EventHandler(this.BtnEditVisit_Click);
            // 
            // BtnAddReminder
            // 
            this.BtnAddReminder.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAddReminder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddReminder.BackgroundImage")));
            this.BtnAddReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddReminder.Location = new System.Drawing.Point(28, 12);
            this.BtnAddReminder.Name = "BtnAddReminder";
            this.BtnAddReminder.Size = new System.Drawing.Size(159, 54);
            this.BtnAddReminder.TabIndex = 68;
            this.BtnAddReminder.UseVisualStyleBackColor = false;
            this.BtnAddReminder.Click += new System.EventHandler(this.BtnAddVisit_Click);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.DodgerBlue;
            this.datePicker.BorderRadius = 0;
            this.datePicker.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.FormatCustom = "yyyy-MM-dd";
            this.datePicker.Location = new System.Drawing.Point(997, 252);
            this.datePicker.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(196, 29);
            this.datePicker.TabIndex = 64;
            this.datePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1224, 252);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 29);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "تاريخ المتابعة";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(1253, 148);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(82, 29);
            this.bunifuCustomLabel7.TabIndex = 11;
            this.bunifuCustomLabel7.Text = "التفاصيل";
            // 
            // title_combobox
            // 
            this.title_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_combobox.FormattingEnabled = true;
            this.title_combobox.Location = new System.Drawing.Point(244, 369);
            this.title_combobox.Name = "title_combobox";
            this.title_combobox.Size = new System.Drawing.Size(614, 28);
            this.title_combobox.TabIndex = 89;
            this.title_combobox.Visible = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_search.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_search.BorderColorIdle = System.Drawing.Color.Navy;
            this.txt_search.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_search.BorderThickness = 3;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.isPassword = false;
            this.txt_search.Location = new System.Drawing.Point(894, 364);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(261, 32);
            this.txt_search.TabIndex = 87;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1170, 367);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(160, 24);
            this.bunifuCustomLabel2.TabIndex = 88;
            this.bunifuCustomLabel2.Text = "بحث بملخص الموضوع";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // DgvReminders
            // 
            this.DgvReminders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvReminders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReminders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReminders.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReminders.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReminders.DoubleBuffered = true;
            this.DgvReminders.EnableHeadersVisualStyles = false;
            this.DgvReminders.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvReminders.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.DgvReminders.HeaderForeColor = System.Drawing.Color.Black;
            this.DgvReminders.Location = new System.Drawing.Point(12, 309);
            this.DgvReminders.Name = "DgvReminders";
            this.DgvReminders.ReadOnly = true;
            this.DgvReminders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvReminders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReminders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvReminders.RowTemplate.Height = 50;
            this.DgvReminders.Size = new System.Drawing.Size(1338, 412);
            this.DgvReminders.TabIndex = 79;
            this.DgvReminders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisit_CellClick);
            this.DgvReminders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReminders_CellDoubleClick);
            // 
            // FormReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_combobox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.DgvReminders);
            this.Name = "FormReminders";
            this.Text = "FormReminders";
            this.Load += new System.EventHandler(this.FormReminders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDeleteVisit;
        private System.Windows.Forms.Button BtnEditReminder;
        private System.Windows.Forms.Button BtnAddReminder;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvReminders;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Button show_all_coming_btn;
        private System.Windows.Forms.Button show_all_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox title_combobox;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_title;
        private System.Windows.Forms.TextBox remindersTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_report_btn;
    }
}