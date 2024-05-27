namespace Drivers_Project
{
    partial class frmFines
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
            this.lblNoFines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoFines
            // 
            this.lblNoFines.AutoSize = true;
            this.lblNoFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFines.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNoFines.Location = new System.Drawing.Point(356, 191);
            this.lblNoFines.Name = "lblNoFines";
            this.lblNoFines.Size = new System.Drawing.Size(165, 42);
            this.lblNoFines.TabIndex = 1;
            this.lblNoFines.Text = "No fines ";
            this.lblNoFines.Visible = false;
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.lblNoFines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFines";
            this.Text = "frmFines";
            this.Load += new System.EventHandler(this.frmFines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoFines;
    }
}