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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_report_btn = new System.Windows.Forms.Button();
            this.remindersTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.show_all_coming_btn = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDeleteVisit = new System.Windows.Forms.Button();
            this.BtnEditReminder = new System.Windows.Forms.Button();
            this.BtnAddReminder = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvReminders = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.show_report_btn);
            this.panel1.Controls.Add(this.remindersTotalTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.description_richTextBox);
            this.panel1.Controls.Add(this.show_all_btn);
            this.panel1.Controls.Add(this.show_all_coming_btn);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDeleteVisit);
            this.panel1.Controls.Add(this.BtnEditReminder);
            this.panel1.Controls.Add(this.BtnAddReminder);
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
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_title.ForeColor = System.Drawing.Color.Black;
            this.txt_title.Location = new System.Drawing.Point(702, 84);
            this.txt_title.Name = "txt_title";
            this.txt_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_title.Size = new System.Drawing.Size(514, 27);
            this.txt_title.TabIndex = 94;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(596, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 40);
            this.label9.TabIndex = 95;
            this.label9.Text = "متابعة السيد مساعد مدير العقود";
            // 
            // DgvReminders
            // 
            this.DgvReminders.AllowUserToAddRows = false;
            this.DgvReminders.AllowUserToDeleteRows = false;
            this.DgvReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReminders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReminders.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvReminders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvReminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvReminders.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReminders.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvReminders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DgvReminders.Location = new System.Drawing.Point(9, 303);
            this.DgvReminders.Name = "DgvReminders";
            this.DgvReminders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReminders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvReminders.RowHeadersWidth = 45;
            this.DgvReminders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvReminders.Size = new System.Drawing.Size(1336, 408);
            this.DgvReminders.TabIndex = 90;
            this.DgvReminders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisit_CellClick);
            this.DgvReminders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReminders_CellDoubleClick);
            // 
            // datePicker
            // 
            this.datePicker.CalendarForeColor = System.Drawing.Color.Blue;
            this.datePicker.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(1027, 251);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datePicker.RightToLeftLayout = true;
            this.datePicker.Size = new System.Drawing.Size(189, 29);
            this.datePicker.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1247, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 96;
            this.label5.Text = "الموضوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1253, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 97;
            this.label2.Text = "التفاصيل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1224, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 98;
            this.label3.Text = "تاريخ المتابعة";
            // 
            // FormReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.DgvReminders);
            this.Controls.Add(this.panel1);
            this.Name = "FormReminders";
            this.Text = "FormReminders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReminders_FormClosed);
            this.Load += new System.EventHandler(this.FormReminders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDeleteVisit;
        private System.Windows.Forms.Button BtnEditReminder;
        private System.Windows.Forms.Button BtnAddReminder;
        private System.Windows.Forms.Button show_all_coming_btn;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.TextBox remindersTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_report_btn;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvReminders;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}