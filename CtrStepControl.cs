using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Timers;

namespace DynaDrive
{
    internal class CtrStepControl : CtrPositionControl
    {
        public double[] stepsize = new double[2];
        public MetroGrid table = new MetroGrid();
        public DataGridView dataGridView1 = new DataGridView();
        public MetroTextBox[] Mc_tube = new MetroTextBox[4];
        public CtrStepControl(Form1 Form, OpenRBSerialGen openRB) : base(Form, openRB)
        {
            table = Form.metroGrid1;
            Mc_tube[0] = Form.MC_tube2_rt; Mc_tube[1] = Form.MC_tube2_tr;
            Mc_tube[2] = Form.MC_tube1_rt; Mc_tube[3] = Form.MC_tube1_tr;
        }
        public new void updateVal(Form1 Form)
        {
            try { stepsize[0] = Convert.ToDouble(Form.ScRtStepSizeTxtbox.Text.ToString()); }
            catch { stepsize[0] = 22.5; }
            try { stepsize[1] = Convert.ToDouble(Form.ScTrStepSizeTxtbox.Text.ToString()); }
            catch { stepsize[1] = 10; }
        }

        /////////// Auto Step Control ///////////
        public void CopyRow()
        {
            try
            {
                int CurrentRow = table.CurrentRow.Index;
                DataGridViewRow selectedRow = table.Rows[CurrentRow];
                string[] value = new string[selectedRow.Cells.Count];
                for (int i = 0; i < value.Length; i++)
                {
                    if (selectedRow.Cells[i].Value != null) value[i] = selectedRow.Cells[i].Value.ToString();
                }
                table.Rows.Add(value);
            }
            catch { }
        }
        public void DeleteRow()
        {
            try
            {
                int CurrentRow = table.CurrentRow.Index;
                table.Rows.RemoveAt(CurrentRow);
            }
            catch { }
        }
        public void Clear()
        {
            table.Rows.Clear();
        }
        public void AutoStepControlGO(Form1 Form) 
        {
            double interval;
            try { interval = Convert.ToDouble(Form.ScIntervalTxtbox.ToString())*1000.0; }
            catch { interval = 3000; }
            Convert.ToInt32(interval);

            DataGridViewRow row;
            for (int i = 0; i < table.RowCount; i++)
            {   
                row = table.Rows[i];
                for (int j = 0; j < 4; j++)
                {
                    if (row.Cells[j].Value == null) continue;
                    Mc_tube[j].Text = row.Cells[j].Value.ToString();
                    
                }

                
            }

            
        }
        public void AutoStepControlSTOP() { }


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

