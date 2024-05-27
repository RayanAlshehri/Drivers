using CommonClasses;
using Drivers_Presentaion;
using DVLD_Business;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Drivers_Project
{
    public partial class frmLogin : Form
    {
        string StoredNationalNumber;
        bool IsNationalNumberGottenFromRegestry = false;
        clsDriver Driver = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ShowNewAccountControls()
        {           
            lblConfirmPassword.Visible = true;
            ibtnCheck.Visible = true;
            tbConfirmPassword.Visible = true;
            btnRegister.Visible = true;
        }

        private void ShowRegisteredAccountControls()
        {
            cbRememberMe.Visible = true;
            btnLogin.Visible = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {           
            if (clsUtility.GetStoredUsernameInRegestry(ref StoredNationalNumber, ConfigurationManager.AppSettings["RegestryKeyName"]))
            {
                tbNationalNumber.Text = StoredNationalNumber;
                cbRememberMe.Checked = true;
                IsNationalNumberGottenFromRegestry = true;
            }

            tbNationalNumber.Focus();
        }

        private void tbNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b');         
        }


        private void ibtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNationalNumber.Text))
            {
                MessageBox.Show("Enter national number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNationalNumber.Clear();
                tbNationalNumber.Focus();
                return;
            }

            string NationalNumber = tbNationalNumber.Text.Trim();
            clsPerson Person = clsPerson.Find(NationalNumber);

            if (Person != null)
            {
                Driver = clsDriver.FindByPersonID(Person.ID);
            }
            else
            {
                MessageBox.Show("Invalid national number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNationalNumber.Focus();
                return;
            }

            if (Driver == null)
            {
                MessageBox.Show("This national number does not belong to a driver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNationalNumber.Focus();
                return;
            }

            tbNationalNumber.Enabled = false;
            btnEnter.Visible = false;
            btnBack.Enabled = true;

            lblPassword.Visible = true;
            ibLockIcon.Visible = true;
            tbPassword.Visible = true;
            tbPassword.Focus();

            if (Driver.Password != null)
            {
                ShowRegisteredAccountControls();
                this.AcceptButton = btnLogin;
            }
            else
            {
                ShowNewAccountControls();
                this.AcceptButton = btnRegister;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsUtility.HashData(tbPassword.Text.Trim()) == Driver.Password)
                {
                    if (cbRememberMe.Checked)
                    {
                        if (!IsNationalNumberGottenFromRegestry || (tbNationalNumber.Text != StoredNationalNumber))
                            clsUtility.StoreUsernameInRegestry(tbNationalNumber.Text.Trim(), ConfigurationManager.AppSettings["RegestryKeyName"]);
                    }
                    else
                    {
                        if (IsNationalNumberGottenFromRegestry)
                        {
                            clsUtility.DeleteStoredUsernameInRegestry("Drivers_Project");
                            cbRememberMe.Checked = false;
                        }
                    }

                    clsGlobal.LogedDriver.DriverInfo = Driver;
                    frmMainScreen frm = new frmMainScreen(this);

                    tbNationalNumber.Enabled = true;
                    tbNationalNumber.Focus();
                    this.Hide();
                    tbNationalNumber.Clear();
                    tbPassword.Clear();
                    lblPassword.Visible = false;
                    tbPassword.Visible = false;
                    ibLockIcon.Visible = false;
                    tbPassword.Visible = false;
                    cbRememberMe.Visible = false;
                    btnBack.Enabled = false;
                    btnLogin.Visible = false;
                    btnEnter.Visible = true;
                    frmLogin_Load(null, null);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                clsUtility.LogExceptionToEventViewer(ConfigurationManager.AppSettings["LoggedExceptionSourceName"], EX);
                MessageBox.Show("Password conversion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
                tbPassword.Focus();             
                return;
            }

            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                MessageBox.Show("Confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
                tbPassword.Focus();
                return;
            }

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password and confirmation do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
                tbPassword.Focus();
                return;
            }

            if (Driver.UpdatePassword(tbPassword.Text.Trim()))
            {
                MessageBox.Show("Account registered successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.AcceptButton = btnEnter;
                lblPassword.Visible = false;
                tbPassword.Visible = false;
                ibLockIcon.Visible = false;
                tbPassword.Visible = false;
                lblConfirmPassword.Visible = false;
                ibtnCheck.Visible = false;
                tbConfirmPassword.Visible = false;
                cbRememberMe.Visible = false;
                btnBack.Enabled = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnEnter.Visible = true;
                tbNationalNumber.Text = Driver.Person.NationalNumber;
                tbNationalNumber.Enabled = true;
                tbNationalNumber.Focus();
            }
            else
            {
                MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            ibLockIcon.Visible = false;
            tbPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            ibtnCheck.Visible = false;
            tbConfirmPassword.Visible = false;
            cbRememberMe.Visible = false;
            btnLogin.Visible = false;
            btnRegister.Visible = false;

            btnEnter.Visible = true;
            this.AcceptButton = btnEnter;
            btnBack.Enabled = false;
            tbNationalNumber.Text = Driver.Person.NationalNumber;
            tbNationalNumber.Enabled = true;
            tbNationalNumber.Focus();
        }
    }
}
