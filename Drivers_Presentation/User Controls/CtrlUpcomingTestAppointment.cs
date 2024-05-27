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
    public partial class CtrlUpcomingTestAppointment : UserControl
    {
        public CtrlUpcomingTestAppointment()
        {
            InitializeComponent();
        }

        public void FillInfo(int AppointmentID)
        {
            clsTestAppoinment Appointment = clsTestAppoinment.Find(AppointmentID);

            if (Appointment != null)
            {
                lblAppointmentID.Text = Appointment.ID.ToString();
                lblTestType.Text = Appointment.TestTypeInfo.TestName;
                lblLicenseClass.Text = Appointment.LocalLicenseApplication.LicenseClassInfo.Name;
                lblTestDate.Text = clsUtility.FormatDateToDMYHM(Appointment.TestDate);
                lblPaidFee.Text = Appointment.PaidFee.ToString();
                lblBookingReason.Text = (Appointment.RetakeTestApplicationID == null ? "First Time" : "Retake");
            }
            else
            {
                MessageBox.Show("Erron in finding appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
