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
using static System.Net.Mime.MediaTypeNames;

namespace Drivers_Project
{
    public partial class CtrlInternationalLicenseInfo : UserControl
    {
        public CtrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillInfo(int InternationalLicenseID)
        {
            clsInternationalLicense License = clsInternationalLicense.FindByInternationalLicenseID(InternationalLicenseID);

            if (License != null)
            {
                lblLicenseID.Text = License.ID.ToString();
                lblDriverID.Text = License.Driver.ID.ToString();
                lblNationalNumber.Text = License.Driver.Person.NationalNumber;
                lblFullName.Text = License.Driver.Person.FullName;
                lblDateOfBirth.Text = clsUtility.FormatDateToDMY(License.Driver.Person.DateOfBirth);
                lblIssuedByLicense.Text = License.IssuedUsingLocalLicenseID.ToString();
                lblIssueDate.Text = clsUtility.FormatDateToDMY(License.IssueDate);
                lblExpiryDate.Text = clsUtility.FormatDateToDMY(License.ExpiryDate);

                if (License.IsExpired())
                {
                    epRed.SetError(lblExpiryDate, "Expired");
                }
                else if (License.ExpiryDate.Year == DateTime.Now.Year) 
                {
                    if (License.ExpiryDate.Month == DateTime.Now.Month)
                        epYellow.SetError(lblExpiryDate, $"Expires after {License.ExpiryDate.Day - DateTime.Now.Day} day(s)");
                    else
                        epYellow.SetError(lblExpiryDate, $"Expires after {License.ExpiryDate.Month - DateTime.Now.Month} month(s)");
                }               
            }
        }
    }
}
