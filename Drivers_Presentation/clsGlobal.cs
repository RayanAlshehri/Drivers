using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers_Project
{
    internal static class clsGlobal
    {
        public static class LogedDriver
        {
            public static clsDriver DriverInfo;

            public static int[] LocalLicensesIDs = null;

            public static int InternationalLicenseID = -1;

            public static int[] DetentionsIDs = null;

            public static int[] UpcomingTestsAppointmentsIDs = null;

            public static void ResetAllVariables()
            {
                DriverInfo = null;
                LocalLicensesIDs = null;
                InternationalLicenseID = -1;
                DetentionsIDs = null;
                UpcomingTestsAppointmentsIDs = null;
            }
        }
    }
}
