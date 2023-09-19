using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DynaDrive
{
    internal class AutoStepping
    {
        private bool[] mtActives = new bool[4];
        private int[] mtFroms  = new int[4];
        private int[] mtFinals = new int[4];
        private int[] mtSteps = new int[4];
        private bool isRoundTripSet = false;

        private int[] mtStepCnts = new int[4];
        public int runCounts;
        public int repeats;

        public AutoStepping(MetroTextBox[] mtFromTBXs, MetroTextBox[] mtToTBXs, MetroTextBox[] mtStepTBXs, bool[] mtAvails,bool rTripSet)
        {
            isRoundTripSet = rTripSet;
            mtActives = mtAvails;

            for (int i = 0; i<4; i++)
            {
                try { mtFroms[i] = Convert.ToInt32(mtFromTBXs[i].Text.ToString());}
                catch (Exception) { mtFroms[i] = 0; mtFromTBXs[i].Text = "0"; }

                try { mtFinals[i] = Convert.ToInt32(mtToTBXs[i].Text.ToString()); }
                catch (Exception) { mtFinals[i] = 0; mtToTBXs[i].Text = "0"; }

                try { mtSteps[i] = Convert.ToInt32(mtStepTBXs[i].Text.ToString()); }
                catch (Exception) { mtSteps[i] = 1; mtToTBXs[i].Text = "-"; }
                if (!mtAvails[i])
                {
                    mtFroms[i] = 0;
                    mtFinals[i] = 0;
                    mtSteps[i] = 1;
                }

                mtStepCnts[i] = Math.Abs(mtFinals[i] - mtFroms[i]) / Math.Abs(mtSteps[i]) + 1;
            }
        }

        public int[,] RunDataGen()
        {
            int cntMax = 0;
            foreach (int i in mtStepCnts)  if (i > cntMax) cntMax = i;
            if(this.isRoundTripSet) { runCounts = cntMax * 2 - 1; } else { runCounts = cntMax; }
            int[,] retVal = new int[runCounts, 4];

            for (int i = 0; i < 4; i++) retVal[0, i] = mtFroms[i];
            for(int turns = 1; turns < cntMax; turns++)
            {
                for(int motors = 0; motors<4; motors++)
                {
                    if (turns > mtStepCnts[motors] || retVal[turns-1, motors] > mtFinals[motors] - mtSteps[motors]) 
                        retVal[turns, motors] = retVal[turns - 1, motors];
                    else retVal[turns, motors] = retVal[turns - 1, motors] + mtSteps[motors];
                }
            }
            if(this.isRoundTripSet)
            {
                for(int i = 0; i < cntMax - 1; i++)
                {
                    for(int j = 0; j< 4; j++)
                    {
                        retVal[runCounts - 1 - i, j] = retVal[i, j];
                    }
                }
            }
            return retVal;
        }

        public string runData2Str(int[,] inputDatas)
        {
            string retStr = "";
            for(int rows = 0; rows < inputDatas.GetLength(0); rows++)
            {
                for(int cols = 0; cols < inputDatas.GetLength(1); cols++)
                {
                    retStr += inputDatas[rows, cols] + ",";
                }
                retStr += "\n";
            }
            return retStr;
        }
        public string runData2Str()
        {
            return runData2Str(RunDataGen());
        }
    }
}
