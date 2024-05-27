using CommonClasses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Project
{
    public partial class frmLocalLicenses : Form
    {
        public frmLocalLicenses()
        {
            InitializeComponent();
        }

        private void LoadLocalLicenses()
        {                      
            if (clsGlobal.LogedDriver.LocalLicensesIDs.Length == 0)
            {
                lblNoLicenses.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblNoLicenses.Width),
                    185);
                lblNoLicenses.Visible = true;
                return;
            }

            int LicenseXlocation = 28;
            int LicenseYlocation = 20;
            int LicenseYincrement = 0;

            foreach (int ID in clsGlobal.LogedDriver.LocalLicensesIDs)
            {
                CtrlLicenseInfo ctrl = new CtrlLicenseInfo();
                ctrl.Visible = false;
                this.Controls.Add(ctrl);
                ctrl.Location = new Point(LicenseXlocation, (LicenseYlocation + LicenseYincrement));
                ctrl.FillInfo(ID);
                ctrl.Visible = true;
                LicenseYincrement += 252;
            }
        }

           
        private void frmLicenses_Load(object sender, EventArgs e)
        {           
            LoadLocalLicenses();
        }     
    }
}
