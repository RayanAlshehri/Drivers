using CommonClasses;
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
    public partial class frmMyInfo : Form
    {
        public frmMyInfo()
        {
            InitializeComponent();
        }

        private void frmMyInfo_Load(object sender, EventArgs e)
        {
            tbNationalNo.Text = clsGlobal.LogedDriver.DriverInfo.Person.NationalNumber;
            tbFirstName.Text = clsGlobal.LogedDriver.DriverInfo.Person.FirstName;
            tbSecondName.Text = clsGlobal.LogedDriver.DriverInfo.Person.SecondName;
            tbThirdName.Text = clsGlobal.LogedDriver.DriverInfo.Person.ThirdName;
            tbLastName.Text = clsGlobal.LogedDriver.DriverInfo.Person.LastName;
            tbPhone.Text = clsGlobal.LogedDriver.DriverInfo.Person.Phone;
            tbEmail.Text = clsGlobal.LogedDriver.DriverInfo.Person.Email;
            tbAddress.Text = clsGlobal.LogedDriver.DriverInfo.Person.Address;

            tbThirdName.Focus();
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                if (!clsValidation.DoesEmailHaveBasicFormat(tbEmail.Text.Trim()))
                {
                    MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            clsGlobal.LogedDriver.DriverInfo.Person.ThirdName = tbThirdName.Text.Trim();
            clsGlobal.LogedDriver.DriverInfo.Person.Phone = tbPhone.Text.Trim();
            clsGlobal.LogedDriver.DriverInfo.Person.Email = tbEmail.Text.Trim();
            clsGlobal.LogedDriver.DriverInfo.Person.Address = tbAddress.Text.Trim();

            if (clsGlobal.LogedDriver.DriverInfo.Person.Save())
            {
                MessageBox.Show("Information updated successfully", "Update Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = ibtnSave;
        }
    }
}
