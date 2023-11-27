using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DynaDrive
{
    internal class DualbendCalc
    {
        private double diskRadius;
        private double TotalLength;
        private double ProxLength;

        private double mt1dir;//to distal
        private double mt2dir;
        private double mt3dir;//to proximal
        private double mt4dir;


        private double[] mtDirs;

        public DualbendCalc(MetroTextBox[] initValsTxtBox)
        {
            getProperties(initValsTxtBox);
            mt1dir = Math.PI / 2f;
            mt2dir = 0;
            mt3dir = -Math.PI / 4f;
            mt4dir = Math.PI / 4f;
            mtDirs = new double[] { mt1dir, mt2dir, mt3dir, mt4dir };
        }
        

        public double[] getTargetTrans(MetroTextBox[,] targetTxtBoxes)
        {
            double mt1trans = 0;
            double mt2trans = 0;
            double mt3trans = 0;
            double mt4trans = 0;

            double seg1tdlEquiv = ang2Equivtdl(deg2rad(txtBox2Double(targetTxtBoxes[0, 0])));
            double seg1Dir = deg2rad(txtBox2Double(targetTxtBoxes[0, 1]));
            double seg2tdlEquiv = ang2Equivtdl(deg2rad(txtBox2Double(targetTxtBoxes[1, 0])));
            double seg2Dir = deg2rad(txtBox2Double(targetTxtBoxes[1, 1]));

            // Input: proximal segment, Offset compensation for distal segment

            mt3trans += seg1tdlEquiv * Math.Cos(mtDirs[2] - seg1Dir); // original input
            mt4trans += seg1tdlEquiv * Math.Cos(mtDirs[3] - seg1Dir); // original input
                                     
            mt1trans += (3d / 4d) * seg1tdlEquiv * Math.Cos(mtDirs[0] - seg1Dir); // offset compensation
            mt2trans += (3d / 4d) * seg1tdlEquiv * Math.Cos(mtDirs[1] - seg1Dir); // offset compensation

            // Input: distal segment, Offset compensation for proximal segment


            mt1trans += seg2tdlEquiv * Math.Cos(mtDirs[0] - seg2Dir);
            mt2trans += seg2tdlEquiv * Math.Cos(mtDirs[1] - seg2Dir);

            // Offset initial curvature k_1 --> use k_1 = 2*tdl / (curvelength * radius)
            // Result: compenTDL_prox = TDL_dist * (proxlen / totallen)
            double k1_seg2_compenTDL = seg2tdlEquiv * (1d/4d);
            mt3trans -= k1_seg2_compenTDL * Math.Cos(mtDirs[2] - seg2Dir);
            mt4trans -= k1_seg2_compenTDL * Math.Cos(mtDirs[3] - seg2Dir);


            double[] targetTrans = new double[] { mt1trans, mt2trans, mt3trans, mt4trans };
            return targetTrans;
        }
        
        public void getProperties(MetroTextBox[] props)
        {
            diskRadius = txtBox2Double(props[0]);
            TotalLength = txtBox2Double(props[1]);
            ProxLength = txtBox2Double(props[2]);
        }

        private double txtBox2Double(MetroTextBox txtBox)
        {
            double retval = 0f;
            try
            {
                retval = Convert.ToDouble(txtBox.Text);
            }
            catch (Exception) { }
            return retval;
        }
        private double deg2rad(double val)
        {
            return Math.PI * val / 180;
        }
        private double ang2Equivtdl(double angleRad)
        {
            return this.diskRadius * angleRad;
        }
        public double[,] getDualbendTarget(MetroTextBox[,] txtBoxes)
        {
            double[,] targetVals = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    targetVals[i, j] = deg2rad(txtBox2Double(txtBoxes[i, j]));
                }
            }
            return targetVals;
        }
        private double getInitCurvature(double tdl, double armLength)
        {
            return 2*tdl / (armLength * this.diskRadius);
        }
        private double InitCurve2TDL(double curvature, double armLength)
        {
            return armLength * curvature * this.diskRadius / 2;
        }
    }
}
