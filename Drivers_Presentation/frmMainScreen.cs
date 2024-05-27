using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using Drivers_Project;
using System.Windows.Forms.VisualStyles;
using System.Reflection;

namespace Drivers_Presentaion
{
    public partial class frmMainScreen : Form
    {
        private frmLogin _LoginForm;
        private IconButton _CurrentlyActivatedIconBtn;
        private Form _CurrentlyOpenedForm;
        private bool _IsLicensesMenuOpened;
        private struct stColors
        {
            public static Color DarkBlue = Color.FromArgb(0, 20, 75);
            public static Color DarkerBlue = Color.FromArgb(0, 20, 55);
            public static Color LighterBlue = Color.FromArgb(8, 28, 48);
        }
        public frmMainScreen(frmLogin LoginForm)
        {
            InitializeComponent();

            this._LoginForm = LoginForm;

            pnlSideMenuSeperator.Location = new Point(clsDesign.GetControlXcenterPosition(
                pnlTopleft.ClientSize.Width, pnlSideMenuSeperator.Width), pnlSideMenuSeperator.Location.Y);

            pnlTitleBarSeperator.Location = new Point(clsDesign.GetControlXcenterPosition(
                 pnlTitleBar.ClientSize.Width, pnlTitleBarSeperator.Width), pnlTitleBarSeperator.Location.Y);
        }

        private void _ActivateBtn(IconButton btn)
        {
            btn.BackColor = stColors.DarkBlue;
            btn.IconColor = btn.ForeColor;
            btn.FlatAppearance.MouseOverBackColor = stColors.DarkBlue;
            btn.FlatAppearance.MouseDownBackColor = stColors.DarkBlue;
            pnlActivatedBtnLeftBorder.BackColor = Color.Orange;
            pnlActivatedBtnLeftBorder.Location = new Point(0, btn.Location.Y);
            pnlActivatedBtnLeftBorder.Visible = true;
            lblOpenedChildFormTitle.Text = btn.Text.Trim();
        }

        private void _DeactivateCurrentBtn()
        {
            _CurrentlyActivatedIconBtn.BackColor = stColors.DarkerBlue;
            _CurrentlyActivatedIconBtn.ForeColor = Color.Gainsboro;
            _CurrentlyActivatedIconBtn.IconColor = _CurrentlyActivatedIconBtn.ForeColor;
            _CurrentlyActivatedIconBtn.FlatAppearance.MouseOverBackColor = stColors.DarkerBlue;
            _CurrentlyActivatedIconBtn.FlatAppearance.MouseDownBackColor = stColors.DarkerBlue;
            pnlActivatedBtnLeftBorder.Visible = false;
            lblOpenedChildFormTitle.Text = "Home";
        }

        private void _OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.Parent = pnlChildForContainer;
            ChildForm.Show();
            ChildForm.Focus();
            _CurrentlyOpenedForm = ChildForm;          
        }

        private void _OpenLicensesMenu()
        {
            ibtnInternational.Visible = true;
            ibtnLocal.Visible = true;           
            _IsLicensesMenuOpened = true;
        }

        private void _CloseLicensesMenu()
        {
            ibtnLocal.Visible = false;
            ibtnInternational.Visible = false;
            _IsLicensesMenuOpened = false;
        }

        
        //Used as links from other forms:
        public void GoToLocalLicenses()
        {
            if (!_IsLicensesMenuOpened)
            {               
                ibtnLicenses.PerformClick();
                ibtnLicenses_MouseLeave(null, null);
            }

            ibtnLocal.PerformClick();
        }

        public void GoToTestsAppointments()
        {
            ibtnTestAppointments.PerformClick();
        }

        public void GoToFines()
        {
            ibtnFines.PerformClick();
        }

        //Events:
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            ibtnHome.PerformClick();
            lblLogedDriverName.Text = "Hi " + clsGlobal.LogedDriver.DriverInfo.Person.FirstName + "!";
        }

        private void MenuIconBtn_Click(IconButton ClickedIconBtn, Form ChildForm)
        {
            if (_CurrentlyActivatedIconBtn != null)
            {
                if (ClickedIconBtn == _CurrentlyActivatedIconBtn)
                    return;

                _DeactivateCurrentBtn();
                _CurrentlyOpenedForm.Close();
            }

            _ActivateBtn(ClickedIconBtn);
            _CurrentlyActivatedIconBtn = ClickedIconBtn;
            _OpenChildForm(ChildForm);                   
        }

        private void ibtnLicenses_Click(object sender, EventArgs e)
        {
            ibtnLicenses_MouseEnter(null, null);

            if (!_IsLicensesMenuOpened)
            {                
                ipbLicensesMenuArrow.IconColor = Color.Orange;
                _OpenLicensesMenu();
                pnlActivatedBtnLeftBorder.Location = new Point(_CurrentlyActivatedIconBtn.Location.X, 
                    _CurrentlyActivatedIconBtn.Location.Y);
            }
            else
            {
                if (ReferenceEquals(_CurrentlyActivatedIconBtn, ibtnLocal) || ReferenceEquals(_CurrentlyActivatedIconBtn, ibtnInternational))
                    return;

                ipbLicensesMenuArrow.IconColor = Color.Gainsboro;
                _CloseLicensesMenu();
                pnlActivatedBtnLeftBorder.Location = new Point(_CurrentlyActivatedIconBtn.Location.X,
                   _CurrentlyActivatedIconBtn.Location.Y);
            }
        }

        private void ibtnLicenses_MouseEnter(object sender, EventArgs e)
        {
            ipbLicensesMenuArrow.BackColor = ibtnLicenses.FlatAppearance.MouseOverBackColor;
        }     

        private void ibtnLicenses_MouseLeave(object sender, EventArgs e)
        {
            ipbLicensesMenuArrow.BackColor = ibtnLicenses.BackColor;
        }

        private void ibtnLicenses_MouseDown(object sender, MouseEventArgs e)
        {           
            ipbLicensesMenuArrow.BackColor = ibtnLicenses.BackColor;           
        }

        private void ibtnLocal_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmLocalLicenses());
        }

        private void ibtnInternational_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmInternationalLicense());
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmHome(this));
        }

        private void ibtnFines_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmFines());
        }

        private void ibtnMyInfo_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmMyInfo());
        }

        private void ibtnTestsAppointments_Click(object sender, EventArgs e)
        {
            MenuIconBtn_Click((IconButton)sender, new frmUpcomingTestAppointments());
        }

        private void ibtnLogout_Click(object sender, EventArgs e)
        {
            clsGlobal.LogedDriver.ResetAllVariables();
            Close();
            _LoginForm.Show();
        }
    }
}
