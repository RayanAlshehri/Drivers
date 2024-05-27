namespace Drivers_Project
{
    partial class frmLocalLicenses
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
            this.lblNoLicenses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoLicenses
            // 
            this.lblNoLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNoLicenses.AutoSize = true;
            this.lblNoLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLicenses.Location = new System.Drawing.Point(307, 184);
            this.lblNoLicenses.Name = "lblNoLicenses";
            this.lblNoLicenses.Size = new System.Drawing.Size(299, 42);
            this.lblNoLicenses.TabIndex = 0;
            this.lblNoLicenses.Text = "No local licenses";
            this.lblNoLicenses.Visible = false;
            // 
            // frmLocalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.lblNoLicenses);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalLicenses";
            this.Text = "frmLicenses";
            this.Load += new System.EventHandler(this.frmLicenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoLicenses;
    }
}