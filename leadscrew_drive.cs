using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DynaDrive
{
    // this class convertes values between motor driving and leadscrew translation

    internal class leadscrew_drive
    {
        private float screw_lead;
        private OpenRBSerialGen openRB;

        public leadscrew_drive(float screw_lead, OpenRBSerialGen board)
        {
            this.screw_lead = screw_lead;
            this.openRB = board;
        }

        public int[] trans2rot(float[] values)
            // get rotation value for certain translation and also automatically writes to motors
        {
            int[] retVals = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                retVals[i] = (int)Math.Round((double)(values[i] / this.screw_lead)) * 4096;
            }
            this.openRB.writeGoalPos(retVals);
            return retVals;
        }
        public float[] rot2trans(int[] values)
            // get translation value from motor's positions
        {
            float[] retVals = new float[values.Length];
            for (int i = 0; i<values.Length; i++)
            {
                retVals[i] = (float)values[i] / this.screw_lead;
            }
            return retVals;
        }
    }
}
