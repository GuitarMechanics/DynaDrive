using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace DynaDrive
{
    internal class CtrStepControl : CtrPositionControl
    {
        public double[] stepsize = new double[2];

        public CtrStepControl(Form1 Form, OpenRBSerialGen openRB) : base(Form, openRB)
        {
        }
        public new void updateVal(Form1 Form)
        {
            try { stepsize[0] = Convert.ToDouble(Form.ScRtStepSizeTxtbox.Text.ToString()); }
            catch { stepsize[0] = 22.5; }
            try { stepsize[1] = Convert.ToDouble(Form.ScTrStepSizeTxtbox.Text.ToString()); }
            catch { stepsize[1] = 10; }
        }
        
        /////////// Step up Control ///////////
        public void StepControlup1(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[0].Checked) openRB.goalPos[0] += Convert.ToInt32(Math.Round(stepsize[0]) / 360 * 4096);
            }
            catch (Exception) { }
            getCurrentPos(Form,openRB);
        }
        public void StepControlup2(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[1].Checked)
                {
                    openRB.goalPos[1] -= Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    if ((mtZeroPos[1] - openRB.goalPos[1] > 75 * 4096 / (14 * 2 * Math.PI)) || (mtZeroPos[1] - openRB.goalPos[1] < 3 * 4096 / (14 * 2 * Math.PI)))
                    {
                        openRB.goalPos[1] += Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    }
                }
            }
            catch (Exception) { }
            getCurrentPos(Form,openRB);
        }
        public void StepControlup3(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[2].Checked) openRB.goalPos[2] += Convert.ToInt32(Math.Round(stepsize[0]) / 360 * 4096);
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }
        public void StepControlup4(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[3].Checked)
                {
                    openRB.goalPos[3] -= Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    if ((mtZeroPos[3] - openRB.goalPos[3] > 150 * 4096 / (14 * 2 * Math.PI)) || (mtZeroPos[3] - openRB.goalPos[3] < 0))
                    {
                        openRB.goalPos[3] += Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    }
                }
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }

        /////////// Step down Control ///////////
        public void StepControldown1(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[0].Checked) openRB.goalPos[0] -= Convert.ToInt32(Math.Round(stepsize[0]) / 360 * 4096);
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }
        public void StepControldown2(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[1].Checked)
                {
                    openRB.goalPos[1] += Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    if ((mtZeroPos[1] - openRB.goalPos[1] > 75 * 4096 / (14 * 2 * Math.PI)) || (mtZeroPos[1] - openRB.goalPos[1] < 3 * 4096 / (14 * 2 * Math.PI)))
                    {
                        openRB.goalPos[1] -= Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    }
                }                
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }
        public void StepControldown3(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[2].Checked) openRB.goalPos[2] -= Convert.ToInt32(Math.Round(stepsize[0]) / 360 * 4096);
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }
        public void StepControldown4(Form1 Form, OpenRBSerialGen openRB)
        {
            updateVal(Form);
            try
            {
                if (Form.mtToggles[3].Checked)
                {
                    openRB.goalPos[3] += Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    if ((mtZeroPos[3] - openRB.goalPos[3] > 150 * 4096 / (14 * 2 * Math.PI)) || (mtZeroPos[3] - openRB.goalPos[3] < 0))
                    {
                        openRB.goalPos[3] -= Convert.ToInt32(Math.Round(stepsize[1] * 4096 / (14 * 2 * Math.PI)));
                    }
                }
            }
            catch (Exception) { }
            getCurrentPos(Form, openRB);
        }
    }
}

