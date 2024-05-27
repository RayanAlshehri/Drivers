namespace Drivers_Presentaion
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblLogedDriverName = new System.Windows.Forms.Label();
            this.pnlTitleBarSeperator = new System.Windows.Forms.Panel();
            this.lblOpenedChildFormTitle = new System.Windows.Forms.Label();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlActivatedBtnLeftBorder = new System.Windows.Forms.Panel();
            this.ipbLicensesMenuArrow = new FontAwesome.Sharp.IconPictureBox();
            this.ibtnLogout = new FontAwesome.Sharp.IconButton();
            this.ibtnMyInfo = new FontAwesome.Sharp.IconButton();
            this.ibtnTestAppointments = new FontAwesome.Sharp.IconButton();
            this.ibtnFines = new FontAwesome.Sharp.IconButton();
            this.ibtnInternational = new FontAwesome.Sharp.IconButton();
            this.ibtnLocal = new FontAwesome.Sharp.IconButton();
            this.ibtnLicenses = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTopleft = new System.Windows.Forms.Panel();
            this.pnlSideMenuSeperator = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlChildForContainer = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLicensesMenuArrow)).BeginInit();
            this.pnlTopleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.pnlTitleBar.Controls.Add(this.lblLogedDriverName);
            this.pnlTitleBar.Controls.Add(this.pnlTitleBarSeperator);
            this.pnlTitleBar.Controls.Add(this.lblOpenedChildFormTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(251, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(899, 91);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblLogedDriverName
            // 
            this.lblLogedDriverName.AutoEllipsis = true;
            this.lblLogedDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedDriverName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLogedDriverName.Location = new System.Drawing.Point(767, 41);
            this.lblLogedDriverName.Name = "lblLogedDriverName";
            this.lblLogedDriverName.Size = new System.Drawing.Size(120, 20);
            this.lblLogedDriverName.TabIndex = 3;
            this.lblLogedDriverName.Text = "Hi Driver!";
            // 
            // pnlTitleBarSeperator
            // 
            this.pnlTitleBarSeperator.BackColor = System.Drawing.Color.DarkGray;
            this.pnlTitleBarSeperator.Location = new System.Drawing.Point(29, 89);
            this.pnlTitleBarSeperator.Name = "pnlTitleBarSeperator";
            this.pnlTitleBarSeperator.Size = new System.Drawing.Size(836, 2);
            this.pnlTitleBarSeperator.TabIndex = 2;
            // 
            // lblOpenedChildFormTitle
            // 
            this.lblOpenedChildFormTitle.AutoSize = true;
            this.lblOpenedChildFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenedChildFormTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOpenedChildFormTitle.Location = new System.Drawing.Point(39, 41);
            this.lblOpenedChildFormTitle.Name = "lblOpenedChildFormTitle";
            this.lblOpenedChildFormTitle.Size = new System.Drawing.Size(52, 20);
            this.lblOpenedChildFormTitle.TabIndex = 0;
            this.lblOpenedChildFormTitle.Text = "Home";
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.pnlSideMenu.Controls.Add(this.pnlActivatedBtnLeftBorder);
            this.pnlSideMenu.Controls.Add(this.ipbLicensesMenuArrow);
            this.pnlSideMenu.Controls.Add(this.ibtnLogout);
            this.pnlSideMenu.Controls.Add(this.ibtnMyInfo);
            this.pnlSideMenu.Controls.Add(this.ibtnTestAppointments);
            this.pnlSideMenu.Controls.Add(this.ibtnFines);
            this.pnlSideMenu.Controls.Add(this.ibtnInternational);
            this.pnlSideMenu.Controls.Add(this.ibtnLocal);
            this.pnlSideMenu.Controls.Add(this.ibtnLicenses);
            this.pnlSideMenu.Controls.Add(this.ibtnHome);
            this.pnlSideMenu.Controls.Add(this.panel1);
            this.pnlSideMenu.Controls.Add(this.pnlTopleft);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(251, 562);
            this.pnlSideMenu.TabIndex = 2;
            // 
            // pnlActivatedBtnLeftBorder
            // 
            this.pnlActivatedBtnLeftBorder.Location = new System.Drawing.Point(10, 102);
            this.pnlActivatedBtnLeftBorder.Name = "pnlActivatedBtnLeftBorder";
            this.pnlActivatedBtnLeftBorder.Size = new System.Drawing.Size(5, 51);
            this.pnlActivatedBtnLeftBorder.TabIndex = 2;
            this.pnlActivatedBtnLeftBorder.Visible = false;
            // 
            // ipbLicensesMenuArrow
            // 
            this.ipbLicensesMenuArrow.BackColor = System.Drawing.Color.Transparent;
            this.ipbLicensesMenuArrow.Enabled = false;
            this.ipbLicensesMenuArrow.ForeColor = System.Drawing.Color.Gainsboro;
            this.ipbLicensesMenuArrow.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.ipbLicensesMenuArrow.IconColor = System.Drawing.Color.Gainsboro;
            this.ipbLicensesMenuArrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbLicensesMenuArrow.IconSize = 19;
            this.ipbLicensesMenuArrow.Location = new System.Drawing.Point(225, 168);
            this.ipbLicensesMenuArrow.Name = "ipbLicensesMenuArrow";
            this.ipbLicensesMenuArrow.Size = new System.Drawing.Size(20, 19);
            this.ipbLicensesMenuArrow.TabIndex = 0;
            this.ipbLicensesMenuArrow.TabStop = false;
            // 
            // ibtnLogout
            // 
            this.ibtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnLogout.FlatAppearance.BorderSize = 0;
            this.ibtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnLogout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnLogout.IconSize = 35;
            this.ibtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogout.Location = new System.Drawing.Point(0, 511);
            this.ibtnLogout.Name = "ibtnLogout";
            this.ibtnLogout.Size = new System.Drawing.Size(241, 51);
            this.ibtnLogout.TabIndex = 6;
            this.ibtnLogout.Text = "Logout";
            this.ibtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLogout.UseVisualStyleBackColor = true;
            this.ibtnLogout.Click += new System.EventHandler(this.ibtnLogout_Click);
            // 
            // ibtnMyInfo
            // 
            this.ibtnMyInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMyInfo.FlatAppearance.BorderSize = 0;
            this.ibtnMyInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnMyInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMyInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMyInfo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnMyInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMyInfo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnMyInfo.IconSize = 35;
            this.ibtnMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMyInfo.Location = new System.Drawing.Point(0, 408);
            this.ibtnMyInfo.Name = "ibtnMyInfo";
            this.ibtnMyInfo.Size = new System.Drawing.Size(241, 51);
            this.ibtnMyInfo.TabIndex = 5;
            this.ibtnMyInfo.Text = "My Information";
            this.ibtnMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMyInfo.UseVisualStyleBackColor = true;
            this.ibtnMyInfo.Click += new System.EventHandler(this.ibtnMyInfo_Click);
            // 
            // ibtnTestAppointments
            // 
            this.ibtnTestAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTestAppointments.FlatAppearance.BorderSize = 0;
            this.ibtnTestAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnTestAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnTestAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTestAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTestAppointments.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnTestAppointments.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.ibtnTestAppointments.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnTestAppointments.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnTestAppointments.IconSize = 35;
            this.ibtnTestAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTestAppointments.Location = new System.Drawing.Point(0, 357);
            this.ibtnTestAppointments.Name = "ibtnTestAppointments";
            this.ibtnTestAppointments.Size = new System.Drawing.Size(241, 51);
            this.ibtnTestAppointments.TabIndex = 4;
            this.ibtnTestAppointments.Text = "Test Appointments";
            this.ibtnTestAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTestAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTestAppointments.UseVisualStyleBackColor = true;
            this.ibtnTestAppointments.Click += new System.EventHandler(this.ibtnTestsAppointments_Click);
            // 
            // ibtnFines
            // 
            this.ibtnFines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnFines.FlatAppearance.BorderSize = 0;
            this.ibtnFines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnFines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFines.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnFines.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.ibtnFines.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnFines.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnFines.IconSize = 35;
            this.ibtnFines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFines.Location = new System.Drawing.Point(0, 306);
            this.ibtnFines.Name = "ibtnFines";
            this.ibtnFines.Size = new System.Drawing.Size(241, 51);
            this.ibtnFines.TabIndex = 3;
            this.ibtnFines.Text = "Fines";
            this.ibtnFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFines.UseVisualStyleBackColor = false;
            this.ibtnFines.Click += new System.EventHandler(this.ibtnFines_Click);
            // 
            // ibtnInternational
            // 
            this.ibtnInternational.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnInternational.FlatAppearance.BorderSize = 0;
            this.ibtnInternational.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnInternational.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnInternational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnInternational.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnInternational.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnInternational.IconColor = System.Drawing.Color.Black;
            this.ibtnInternational.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInternational.Location = new System.Drawing.Point(0, 255);
            this.ibtnInternational.Name = "ibtnInternational";
            this.ibtnInternational.Size = new System.Drawing.Size(241, 51);
            this.ibtnInternational.TabIndex = 9;
            this.ibtnInternational.Text = "         International";
            this.ibtnInternational.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnInternational.UseVisualStyleBackColor = true;
            this.ibtnInternational.Visible = false;
            this.ibtnInternational.Click += new System.EventHandler(this.ibtnInternational_Click);
            // 
            // ibtnLocal
            // 
            this.ibtnLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnLocal.FlatAppearance.BorderSize = 0;
            this.ibtnLocal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLocal.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnLocal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnLocal.IconColor = System.Drawing.Color.Black;
            this.ibtnLocal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLocal.Location = new System.Drawing.Point(0, 204);
            this.ibtnLocal.Name = "ibtnLocal";
            this.ibtnLocal.Size = new System.Drawing.Size(241, 51);
            this.ibtnLocal.TabIndex = 8;
            this.ibtnLocal.Text = "         Local";
            this.ibtnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLocal.UseVisualStyleBackColor = true;
            this.ibtnLocal.Visible = false;
            this.ibtnLocal.Click += new System.EventHandler(this.ibtnLocal_Click);
            // 
            // ibtnLicenses
            // 
            this.ibtnLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnLicenses.FlatAppearance.BorderSize = 0;
            this.ibtnLicenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLicenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLicenses.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnLicenses.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ibtnLicenses.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnLicenses.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnLicenses.IconSize = 35;
            this.ibtnLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLicenses.Location = new System.Drawing.Point(0, 153);
            this.ibtnLicenses.Name = "ibtnLicenses";
            this.ibtnLicenses.Size = new System.Drawing.Size(241, 51);
            this.ibtnLicenses.TabIndex = 0;
            this.ibtnLicenses.Text = "Licenses";
            this.ibtnLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLicenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLicenses.UseVisualStyleBackColor = true;
            this.ibtnLicenses.Click += new System.EventHandler(this.ibtnLicenses_Click);
            this.ibtnLicenses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibtnLicenses_MouseDown);
            this.ibtnLicenses.MouseEnter += new System.EventHandler(this.ibtnLicenses_MouseEnter);
            this.ibtnLicenses.MouseLeave += new System.EventHandler(this.ibtnLicenses_MouseLeave);
            // 
            // ibtnHome
            // 
            this.ibtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnHome.IconSize = 35;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 102);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Size = new System.Drawing.Size(241, 51);
            this.ibtnHome.TabIndex = 10;
            this.ibtnHome.Text = "Home";
            this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHome.UseVisualStyleBackColor = false;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(241, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 460);
            this.panel1.TabIndex = 2;
            // 
            // pnlTopleft
            // 
            this.pnlTopleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.pnlTopleft.Controls.Add(this.pnlSideMenuSeperator);
            this.pnlTopleft.Controls.Add(this.lblMainTitle);
            this.pnlTopleft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopleft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopleft.Name = "pnlTopleft";
            this.pnlTopleft.Size = new System.Drawing.Size(251, 102);
            this.pnlTopleft.TabIndex = 1;
            // 
            // pnlSideMenuSeperator
            // 
            this.pnlSideMenuSeperator.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSideMenuSeperator.Location = new System.Drawing.Point(12, 89);
            this.pnlSideMenuSeperator.Name = "pnlSideMenuSeperator";
            this.pnlSideMenuSeperator.Size = new System.Drawing.Size(221, 2);
            this.pnlSideMenuSeperator.TabIndex = 1;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMainTitle.Location = new System.Drawing.Point(3, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(245, 37);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Drivers System";
            // 
            // pnlChildForContainer
            // 
            this.pnlChildForContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.pnlChildForContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForContainer.Location = new System.Drawing.Point(251, 91);
            this.pnlChildForContainer.Name = "pnlChildForContainer";
            this.pnlChildForContainer.Size = new System.Drawing.Size(899, 471);
            this.pnlChildForContainer.TabIndex = 3;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 562);
            this.Controls.Add(this.pnlChildForContainer);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbLicensesMenuArrow)).EndInit();
            this.pnlTopleft.ResumeLayout(false);
            this.pnlTopleft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlSideMenu;
        private FontAwesome.Sharp.IconButton ibtnLicenses;
        private System.Windows.Forms.Panel pnlTopleft;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblOpenedChildFormTitle;
        private System.Windows.Forms.Panel pnlSideMenuSeperator;
        private System.Windows.Forms.Panel pnlTitleBarSeperator;
        private System.Windows.Forms.Panel pnlActivatedBtnLeftBorder;
        private FontAwesome.Sharp.IconButton ibtnLogout;
        private FontAwesome.Sharp.IconButton ibtnMyInfo;
        private FontAwesome.Sharp.IconButton ibtnTestAppointments;
        private FontAwesome.Sharp.IconButton ibtnFines;
        private FontAwesome.Sharp.IconButton ibtnInternational;
        private FontAwesome.Sharp.IconButton ibtnLocal;
        private FontAwesome.Sharp.IconPictureBox ipbLicensesMenuArrow;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private System.Windows.Forms.Label lblLogedDriverName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlChildForContainer;
        private System.Windows.Forms.Panel panel1;
    }
}

