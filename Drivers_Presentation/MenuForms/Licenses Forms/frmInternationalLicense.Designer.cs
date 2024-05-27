namespace Drivers_Project
{
    partial class frmInternationalLicense
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
            this.lblNoInternationalLicense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoInternationalLicense
            // 
            this.lblNoInternationalLicense.AutoSize = true;
            this.lblNoInternationalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoInternationalLicense.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNoInternationalLicense.Location = new System.Drawing.Point(259, 194);
            this.lblNoInternationalLicense.Name = "lblNoInternationalLicense";
            this.lblNoInternationalLicense.Size = new System.Drawing.Size(406, 42);
            this.lblNoInternationalLicense.TabIndex = 0;
            this.lblNoInternationalLicense.Text = "No international license";
            this.lblNoInternationalLicense.Visible = false;
            // 
            // frmInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.lblNoInternationalLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInternationalLicense";
            this.Text = "frmInternationalLicense";
            this.Load += new System.EventHandler(this.frmInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoInternationalLicense;
    }
}