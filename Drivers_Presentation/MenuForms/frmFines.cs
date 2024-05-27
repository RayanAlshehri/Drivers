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
    public partial class frmFines : Form
    {
        public frmFines()
        {
            InitializeComponent();
        }

        private void frmFines_Load(object sender, EventArgs e)
        {
            if (clsGlobal.LogedDriver.DetentionsIDs.Length == 0)
            {
                lblNoFines.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblNoFines.Width),
                    185);
                lblNoFines.Visible = true;
                return;
            }

            int xLocation = 62;
            int yLocation = 21;
            int NumberOfDetentionsShown = 0;

            foreach (int ID in clsGlobal.LogedDriver.DetentionsIDs)
            {
                int xIncerement = 0;
                int yIncrement = 0;

                if (NumberOfDetentionsShown == 0)
                {

                }
                else if (NumberOfDetentionsShown % 2 != 0)
                {
                    xIncerement = 439;
                }
                else
                {
                    yIncrement = 325;
                }

                CtrlDetentionInfo Ctrl = new CtrlDetentionInfo();

                Ctrl.Visible = false;
                this.Controls.Add(Ctrl);
                Ctrl.Location = new Point(xLocation + xIncerement, yLocation + yIncrement);
                Ctrl.FinePaid += CtrlDetentionInfo_FinePaid;
                Ctrl.FillInfo(ID);

                Ctrl.Visible = true;
                NumberOfDetentionsShown++;
            }
        }

        private void CtrlDetentionInfo_FinePaid(object sender, EventArgs e)
        {
            CtrlDetentionInfo.FinePaidEventArgs FinePaidEventArgs = e as CtrlDetentionInfo.FinePaidEventArgs;

            clsGlobal.LogedDriver.DetentionsIDs = clsGlobal.LogedDriver.DetentionsIDs.Where(
                ID => ID != FinePaidEventArgs.DetentionID).ToArray();
            this.Controls.Remove((Control)sender);
            frmFines_Load(null, null);
        }
    }
}
