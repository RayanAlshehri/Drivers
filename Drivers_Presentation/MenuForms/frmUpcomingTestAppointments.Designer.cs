namespace Drivers_Project
{
    partial class frmUpcomingTestAppointments
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
            this.lblNoAppointments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoAppointments
            // 
            this.lblNoAppointments.AutoSize = true;
            this.lblNoAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAppointments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNoAppointments.Location = new System.Drawing.Point(307, 195);
            this.lblNoAppointments.Name = "lblNoAppointments";
            this.lblNoAppointments.Size = new System.Drawing.Size(300, 42);
            this.lblNoAppointments.TabIndex = 2;
            this.lblNoAppointments.Text = "No appointments";
            this.lblNoAppointments.Visible = false;
            // 
            // frmUpcomingTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.lblNoAppointments);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpcomingTestAppointments";
            this.Text = "frmUpcomingTestsAppointments";
            this.Load += new System.EventHandler(this.frmUpcomingTestsAppointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoAppointments;
    }
}