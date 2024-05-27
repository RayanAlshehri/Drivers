using Drivers_Presentaion;
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
    public partial class frmHome : Form
    {
        frmMainScreen MainForm;
        public frmHome(frmMainScreen MainForm)
        {
            InitializeComponent();

            this.MainForm = MainForm;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (clsGlobal.LogedDriver.LocalLicensesIDs == null)
                clsGlobal.LogedDriver.LocalLicensesIDs = clsGlobal.LogedDriver.DriverInfo.GetActiveLocalLicensesIDs();

            if (clsGlobal.LogedDriver.DetentionsIDs == null)
                clsGlobal.LogedDriver.DetentionsIDs = clsGlobal.LogedDriver.DriverInfo.GetDriverDetentionsIDsWithUnpaidFines();

            if (clsGlobal.LogedDriver.UpcomingTestsAppointmentsIDs == null)
                clsGlobal.LogedDriver.UpcomingTestsAppointmentsIDs = clsGlobal.LogedDriver.DriverInfo.GetUpcomingAppointmentsIDsForDriver();

            lblLocalLicensesCount.Text = clsGlobal.LogedDriver.LocalLicensesIDs.Length.ToString();
            lblFinesCount.Text = clsGlobal.LogedDriver.DetentionsIDs.Length.ToString();
            lblTestsAppointmentsCount.Text = clsGlobal.LogedDriver.UpcomingTestsAppointmentsIDs.Length.ToString();
        }

        private void ibtnViewLocalLicenses_Click(object sender, EventArgs e)
        {
            MainForm.GoToLocalLicenses();
        }

        private void ibtnFines_Click(object sender, EventArgs e)
        {
            MainForm.GoToFines();
        }

        private void ViewTestsAppointments_Click(object sender, EventArgs e)
        {
            MainForm.GoToTestsAppointments();
        }
    }
}
