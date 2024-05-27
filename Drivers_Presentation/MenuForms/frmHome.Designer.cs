namespace Drivers_Project
{
    partial class frmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ibtnViewLocalLicenses = new FontAwesome.Sharp.IconButton();
            this.lblLocalLicensesCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ibtnFines = new FontAwesome.Sharp.IconButton();
            this.lblFinesCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ViewTestsAppointments = new FontAwesome.Sharp.IconButton();
            this.lblTestsAppointmentsCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.groupBox1.Controls.Add(this.ibtnViewLocalLicenses);
            this.groupBox1.Controls.Add(this.lblLocalLicensesCount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(34, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Licenses:";
            // 
            // ibtnViewLocalLicenses
            // 
            this.ibtnViewLocalLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnViewLocalLicenses.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnViewLocalLicenses.IconColor = System.Drawing.Color.Black;
            this.ibtnViewLocalLicenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnViewLocalLicenses.Location = new System.Drawing.Point(75, 85);
            this.ibtnViewLocalLicenses.Name = "ibtnViewLocalLicenses";
            this.ibtnViewLocalLicenses.Size = new System.Drawing.Size(75, 37);
            this.ibtnViewLocalLicenses.TabIndex = 1;
            this.ibtnViewLocalLicenses.Text = "View";
            this.ibtnViewLocalLicenses.UseVisualStyleBackColor = true;
            this.ibtnViewLocalLicenses.Click += new System.EventHandler(this.ibtnViewLocalLicenses_Click);
            // 
            // lblLocalLicensesCount
            // 
            this.lblLocalLicensesCount.AutoSize = true;
            this.lblLocalLicensesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblLocalLicensesCount.Location = new System.Drawing.Point(102, 44);
            this.lblLocalLicensesCount.Name = "lblLocalLicensesCount";
            this.lblLocalLicensesCount.Size = new System.Drawing.Size(19, 20);
            this.lblLocalLicensesCount.TabIndex = 0;
            this.lblLocalLicensesCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.groupBox2.Controls.Add(this.ibtnFines);
            this.groupBox2.Controls.Add(this.lblFinesCount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(326, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fines:";
            // 
            // ibtnFines
            // 
            this.ibtnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFines.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnFines.IconColor = System.Drawing.Color.Black;
            this.ibtnFines.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFines.Location = new System.Drawing.Point(75, 85);
            this.ibtnFines.Name = "ibtnFines";
            this.ibtnFines.Size = new System.Drawing.Size(75, 37);
            this.ibtnFines.TabIndex = 1;
            this.ibtnFines.Text = "View";
            this.ibtnFines.UseVisualStyleBackColor = true;
            this.ibtnFines.Click += new System.EventHandler(this.ibtnFines_Click);
            // 
            // lblFinesCount
            // 
            this.lblFinesCount.AutoSize = true;
            this.lblFinesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinesCount.ForeColor = System.Drawing.Color.Red;
            this.lblFinesCount.Location = new System.Drawing.Point(102, 44);
            this.lblFinesCount.Name = "lblFinesCount";
            this.lblFinesCount.Size = new System.Drawing.Size(19, 20);
            this.lblFinesCount.TabIndex = 0;
            this.lblFinesCount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.groupBox3.Controls.Add(this.ViewTestsAppointments);
            this.groupBox3.Controls.Add(this.lblTestsAppointmentsCount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(627, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tests Appointments:";
            // 
            // ViewTestsAppointments
            // 
            this.ViewTestsAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTestsAppointments.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ViewTestsAppointments.IconColor = System.Drawing.Color.Black;
            this.ViewTestsAppointments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewTestsAppointments.Location = new System.Drawing.Point(75, 85);
            this.ViewTestsAppointments.Name = "ViewTestsAppointments";
            this.ViewTestsAppointments.Size = new System.Drawing.Size(75, 37);
            this.ViewTestsAppointments.TabIndex = 1;
            this.ViewTestsAppointments.Text = "View";
            this.ViewTestsAppointments.UseVisualStyleBackColor = true;
            this.ViewTestsAppointments.Click += new System.EventHandler(this.ViewTestsAppointments_Click);
            // 
            // lblTestsAppointmentsCount
            // 
            this.lblTestsAppointmentsCount.AutoSize = true;
            this.lblTestsAppointmentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestsAppointmentsCount.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTestsAppointmentsCount.Location = new System.Drawing.Point(102, 44);
            this.lblTestsAppointmentsCount.Name = "lblTestsAppointmentsCount";
            this.lblTestsAppointmentsCount.Size = new System.Drawing.Size(19, 20);
            this.lblTestsAppointmentsCount.TabIndex = 0;
            this.lblTestsAppointmentsCount.Text = "0";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ibtnViewLocalLicenses;
        private System.Windows.Forms.Label lblLocalLicensesCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton ibtnFines;
        private System.Windows.Forms.Label lblFinesCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton ViewTestsAppointments;
        private System.Windows.Forms.Label lblTestsAppointmentsCount;
    }
}