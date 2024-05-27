using CommonClasses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Project
{
    public partial class frmInternationalLicense : Form
    {
        public frmInternationalLicense()
        {
            InitializeComponent();
        }

        private void LoadInternationalLicense()
        {
            if (clsGlobal.LogedDriver.InternationalLicenseID == -1)
                clsGlobal.LogedDriver.InternationalLicenseID = clsGlobal.LogedDriver.DriverInfo.GetActiveInternationalLicenseID();

            if (clsGlobal.LogedDriver.InternationalLicenseID == -1)
            {
                lblNoInternationalLicense.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblNoInternationalLicense.Width),
                    185);
                lblNoInternationalLicense.Visible = true;
                return;
            }

            CtrlInternationalLicenseInfo ctrl = new CtrlInternationalLicenseInfo();
            ctrl.Visible = false;
            this.Controls.Add(ctrl);
            ctrl.Location = new Point(28, 20);
            ctrl.FillInfo(clsGlobal.LogedDriver.InternationalLicenseID);
            ctrl.Visible = true;
        }

        private void frmInternationalLicense_Load(object sender, EventArgs e)
        {
            LoadInternationalLicense();
        }
    }
}
