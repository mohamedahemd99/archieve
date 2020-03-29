namespace archive
{
    partial class FormBrief
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
            this.ReportViewerFollowing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerFollowing
            // 
            this.ReportViewerFollowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerFollowing.LocalReport.ReportEmbeddedResource = "archive.Report6.rdlc";
            this.ReportViewerFollowing.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerFollowing.Name = "ReportViewerFollowing";
            this.ReportViewerFollowing.ServerReport.BearerToken = null;
            this.ReportViewerFollowing.Size = new System.Drawing.Size(1339, 733);
            this.ReportViewerFollowing.TabIndex = 59;
            // 
            // FormBrief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 733);
            this.Controls.Add(this.ReportViewerFollowing);
            this.Name = "FormBrief";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير مختصر لمكاتبات محددة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBrief_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFollowing;
    }
}