using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
//123123123

namespace DynaDrive
{
    internal class CtrMovementControl
    {
       
        public MetroTextBox[] mtMcTargets = new MetroTextBox[4];
        public int[] mtCenterPos = new int[4];
        public int[] mtZeroPos = new int[4];


        public CtrMovementControl(Form1 Form, OpenRBSerialGen openRB) {
            updateVal(Form);

            for (int i = 0; i < 4; i++) openRB.goalPos[i] = mtCenterPos[i];
        }
        public void updateVal(Form1 Form)
        {
            mtMcTargets[0] = Form.MC_tube2_rt; mtMcTargets[1] = Form.MC_tube2_tr;
            mtMcTargets[2] = Form.MC_tube1_rt; mtMcTargets[3] = Form.MC_tube1_tr;
            mtCenterPos[0] = Convert.ToInt32(Form.mtCenterPos1.Text.ToString()); mtCenterPos[1] = Convert.ToInt32(Form.mtCenterPos2.Text.ToString());
            mtCenterPos[2] = Convert.ToInt32(Form.mtCenterPos3.Text.ToString()); mtCenterPos[3] = Convert.ToInt32(Form.mtCenterPos4.Text.ToString());
            mtZeroPos[0] = Convert.ToInt32(Form.mtZeroPos1.Text.ToString()); mtZeroPos[1] = Convert.ToInt32(Form.mtZeroPos2.Text.ToString());
            mtZeroPos[2] = Convert.ToInt32(Form.mtZeroPos3.Text.ToString()); mtZeroPos[3] = Convert.ToInt32(Form.mtZeroPos4.Text.ToString());
        }
        public void McCenter(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            for (int i = 0; i < 4; i++)
            {
                openRB.goalPos[i] = mtCenterPos[i];
            }
        }
        public void McZero(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            for (int i = 0; i < 4; i++)
            {
                openRB.goalPos[i] = mtZeroPos[i];
            }
        }

        public void MovementControlGo(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[0].Checked) openRB.goalPos[0] = mtZeroPos[0] + Convert.ToInt32(Math.Round(Convert.ToDouble(mtMcTargets[0].Text.ToString()) / 360 * 4096));
            }
            catch (Exception) { }
            try
            {
                if (Form.mtToggles[1].Checked)
                {
                    openRB.goalPos[1] = mtZeroPos[1] - Convert.ToInt32(Math.Round((Convert.ToDouble(mtMcTargets[1].Text.ToString())-3) * 4096 / (14 * 2 * Math.PI)));
                    if (Convert.ToInt32(mtMcTargets[1].Text.ToString()) > 75) openRB.goalPos[1] = mtZeroPos[1] - Convert.ToInt32(Math.Round(72 * 4096 / (14 * 2 * Math.PI)));
                    if (Convert.ToInt32(mtMcTargets[1].Text.ToString()) < 4) openRB.goalPos[1] = mtZeroPos[1];
                }
            }
            catch (Exception) { }
            try
            {
                if (Form.mtToggles[2].Checked) openRB.goalPos[2] = mtZeroPos[2] + Convert.ToInt32(Math.Round(Convert.ToDouble(mtMcTargets[2].Text.ToString())) / 360 * 4096);
            }
            catch (Exception) { }
            try
            {
                if (Form.mtToggles[3].Checked)
                {
                    openRB.goalPos[3] = mtZeroPos[3] - Convert.ToInt32(Math.Round(Convert.ToDouble(mtMcTargets[3].Text.ToString()) * 4096 / (14 * 2 * Math.PI)));
                    if (Convert.ToInt32(mtMcTargets[3].Text.ToString()) > 150) openRB.goalPos[3] = mtZeroPos[3] - Convert.ToInt32(Math.Round(150 * 4096 / (14 * 2 * Math.PI)));
                    if (Convert.ToInt32(mtMcTargets[3].Text.ToString()) < 0) openRB.goalPos[3] = mtZeroPos[3];
                }
            }
            catch (Exception) { }
        }
    }
}
