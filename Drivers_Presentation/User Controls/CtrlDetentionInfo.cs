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
    public partial class CtrlDetentionInfo : UserControl
    {       
        public event EventHandler FinePaid;

        public class FinePaidEventArgs : EventArgs
        {
            public int DetentionID { get; set; }
            public int LicenseID { get; set; }
        }
        protected virtual void OnFinePaid()
        {
            if (FinePaid != null)
            {
                FinePaidEventArgs args = new FinePaidEventArgs { DetentionID = _Detention.ID, LicenseID = _Detention.LicenseID };
                FinePaid.Invoke(this, args);
            }
        }

        private clsDetention _Detention;
        

        public CtrlDetentionInfo()
        {
            InitializeComponent();
        }

        public void FillInfo(int DetentionID)
        {
            _Detention = clsDetention.FindByDetentionID(DetentionID);

            if (_Detention != null)
            {
                lblDetentionID.Text = _Detention.ID.ToString();
                lblLicenseID.Text = _Detention.LicenseID.ToString();
                lblDetentionDate.Text = clsUtility.FormatDateToDMY(_Detention.DetentionDate);
                lblFine.Text = _Detention.Fine.ToString();
            }
            else
            {
                MessageBox.Show("Error in fetching date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void ibtnPayFine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to pay this fine?", "Pay Fine", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            if (_Detention.MarkFineAsPaid())
            {
                MessageBox.Show("Fine paid successfully", "Pay Fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnFinePaid();
            }
            else
            {
                MessageBox.Show("Payment failed", "Pay Fine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
