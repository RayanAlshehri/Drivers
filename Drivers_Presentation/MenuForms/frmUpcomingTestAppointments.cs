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
    public partial class frmUpcomingTestAppointments : Form
    {
        public frmUpcomingTestAppointments()
        {
            InitializeComponent();
        }

        private void frmUpcomingTestsAppointments_Load(object sender, EventArgs e)
        {           
            if (clsGlobal.LogedDriver.UpcomingTestsAppointmentsIDs.Length == 0)
            {
                lblNoAppointments.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblNoAppointments.Width),
                    185);
                lblNoAppointments.Visible = true;
                return;
            }

            int LicenseXlocation = 60;
            int LicenseYlocation = 20;
            int LicenseYincrement = 0;

            foreach (int ID in clsGlobal.LogedDriver.UpcomingTestsAppointmentsIDs)
            {
                CtrlUpcomingTestAppointment ctrl = new CtrlUpcomingTestAppointment();
                ctrl.Visible = false;
                this.Controls.Add(ctrl);
                ctrl.Location = new Point(LicenseXlocation, (LicenseYlocation + LicenseYincrement));
                ctrl.FillInfo(ID);
                ctrl.Visible = true;
                LicenseYincrement += 252;
            }
        }
    }
}
