using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using Drivers_Project.Properties;
using DVLD_Business;

namespace Drivers_Project
{
    public partial class CtrlLicenseInfo : UserControl
    {
        public CtrlLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillInfo(int LicenseID)
        {
            clsLicense License = clsLicense.FindByLicenseID(LicenseID);

            if (License != null)
            {
                lblLicenseID.Text = License.ID.ToString();

                if (License.IsDetained())
                {
                    epRed.SetError(lblLicenseID, "This license is detained");
                }             

                lblDriverID.Text = License.Driver.ID.ToString();
                lblNationalNumber.Text = License.Driver.Person.NationalNumber;
                lblFullName.Text = License.Driver.Person.FullName;
                lblDateOfBirth.Text = clsUtility.FormatDateToDMY(License.Driver.Person.DateOfBirth);
                lblClass.Text = License.ClassInfo.Name;
                lblIssueReason.Text = License.IssueReasonString;
                lblIssueDate.Text = clsUtility.FormatDateToDMY(License.IssueDate);
                lblExpiryDate.Text = clsUtility.FormatDateToDMY(License.ExpiryDate);               
                lblConstraints.Text = clsLicense.GetConstraintsString(License.Constraints);

                if (License.IsExpired())
                {
                    epRed.SetError(lblExpiryDate, "Expired");
                }
                else if (License.ExpiryDate.Year == DateTime.Now.Year)
                {
                    epYellow.SetError(lblExpiryDate, "Expires in the current year");
                }
            }
        }
    }
}
