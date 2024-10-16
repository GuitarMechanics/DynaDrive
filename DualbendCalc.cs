using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynaDrive
{
    internal class DualbendCalc
    {
        private double diskRadius;
        private double TotalLength;
        private double ProxLength;
        private double lenRatio;

        private double mt1dir;//to distal
        private double mt2dir;
        private double mt3dir;//to proximal
        private double mt4dir;

        private double dist_compenCoeff_toprox;
        private double prox_compenCoeff_todist;

        private double dir1, dir2, bend1, bend2;

        private double[] mtDirs;
        private double s_val = 0.17575d;

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

            bend1 = deg2rad(txtBox2Double(targetTxtBoxes[0, 0]));
            dir1 = deg2rad(txtBox2Double(targetTxtBoxes[0, 1]));
            bend2 = deg2rad(txtBox2Double(targetTxtBoxes[1, 0]));
            dir2 = deg2rad(txtBox2Double(targetTxtBoxes[1, 1]));

            double seg1tdlEquiv = ang2Equivtdl(bend1);
            double seg1Dir = this.dir1;
            double seg2tdlEquiv = ang2Equivtdl(bend2);
            double seg2Dir = this.dir2;

            // Input: proximal segment, Offset compensation for distal segment

            mt3trans += seg1tdlEquiv * Math.Cos(mtDirs[2] - seg1Dir); // original input
            mt4trans += seg1tdlEquiv * Math.Cos(mtDirs[3] - seg1Dir); // original input

            //mt1trans += prox_compenCoeff_todist * seg1tdlEquiv * Math.Cos(mtDirs[0] - seg1Dir); // offset compensation
            //mt2trans += prox_compenCoeff_todist * seg1tdlEquiv * Math.Cos(mtDirs[1] - seg1Dir); // offset compensation
            mt1trans += seg1tdlEquiv * Math.Cos(mtDirs[0] - seg1Dir);
            mt2trans += seg1tdlEquiv * Math.Cos(mtDirs[1] - seg1Dir); // prox input --> length compensation for distal

            // Input: distal segment, Offset compensation for proximal segment

            //proximal compensation
            double proxBias = ProxLength + seg1tdlEquiv * Math.Cos(seg2Dir- seg1Dir);
            double lenratio_bias = proxBias / TotalLength;
            double k1_seg2_compenTDL = seg2tdlEquiv * lenratio_bias * (1 - lenratio_bias / 2);// / 2;
            mt3trans -= k1_seg2_compenTDL * Math.Cos(mtDirs[2] - seg2Dir);
            mt4trans -= k1_seg2_compenTDL * Math.Cos(mtDirs[3] - seg2Dir);

            double seg2tdlReal = seg2tdlEquiv + k1_seg2_compenTDL;///2;// * (1 - Math.Cos(seg1Dir  - seg2Dir));//compression compensation
            mt1trans += seg2tdlReal * Math.Cos(mtDirs[0] - seg2Dir);
            mt2trans += seg2tdlReal * Math.Cos(mtDirs[1] - seg2Dir);

            // Offset initial curvature k_1 --> use k_1 = 2*tdl / (curvelength * radius)
            // Result: compenTDL_prox = TDL_dist * (proxlen / totallen)
            //double k1_seg2_compenTDL = seg2tdlReal / 2;// * lenRatio * (2-lenRatio);



            double[] targetTrans = new double[] { mt1trans, mt2trans, mt3trans, mt4trans };
            return targetTrans;
        }
        
        public void getProperties(MetroTextBox[] props)
        {
            diskRadius = txtBox2Double(props[0]);
            TotalLength = txtBox2Double(props[1]);
            ProxLength = txtBox2Double(props[2]);
            lenRatio = ProxLength / TotalLength;
            prox_compenCoeff_todist = 1 - (1 - lenRatio) * (1 - lenRatio);
            dist_compenCoeff_toprox = lenRatio * (2-lenRatio);
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
        private double[] getRotSingleSeg(double[] vct, double bend, double dir)
        {
            double[] retVct = new double[3];

            return retVct;
        }

        public double[] getDistalOrient()
        {
            double[] initUnit = { 0d, 0d, 1d };
            double[] retVct = new double[3];
            double[] vct1 = matVctMul(initUnit,matMul(matMul(matMul(rotMatrixZ(dir1),rotMatrixY(bend1)),rotMatrixZ(dir2)),rotMatrixY(bend2)));
            string consoleStr = "";
            foreach (double var in vct1) consoleStr += var + " ";
            //Console.WriteLine(consoleStr);
            return retVct;
        }
        public double[] getDistalPos()
        {
            double[] initPos = { 0d, 0d, 0d, 1d };
            double[] distPos = matVctMul(initPos, matMul(forward_transform(bend1, dir1, ProxLength), forward_transform(bend2, dir2, (TotalLength - ProxLength))));
            return distPos;
        }
        private double[,] rotMatrixY(double ang)
        {
            double[,] retMat = { { Math.Cos(ang), 0, -Math.Sin(ang) }, { 0d,1d,0d},{ Math.Sin(ang), 0d, Math.Cos(ang) } };
            return retMat;
        }
        private double[,] rotMatrixZ(double ang)
        {
            double[,] retMat = { { Math.Cos(ang), Math.Sin(ang), 0d }, { -Math.Sin(ang), Math.Cos(ang), 0d }, { 0d, 0d, 1d } };
            return retMat;
        }
        private double vctDot(double[] vct1, double[] vct2)
        {
            double retVal = 0;
            for (int i = 0; i < 3; i++) retVal += vct1[i] * vct2[i];
            return retVal;
        }
        private double[,] matMul(double[,] mat1, double[,] mat2)
        {
            double[,] retMat = new double[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double[] vctRow = { mat1[i, 0], mat1[i, 1], mat1[i, 2] };
                    double[] vctCol = { mat2[0, j], mat2[1, j], mat2[2, j] };
                    retMat[i, j] = vctDot(vctRow, vctCol);
                }
            }
            return retMat;
        }
        private double[] matVctMul(double[] vct, double[,] mat)
        {
            double[] retVct = new double[vct.Length];
            for(int i = 0; i<vct.Length; i++)
            {
                double[] partVct = new double[3]{ mat[i, 0], mat[i, 1], mat[i, 2] };
                retVct[i] = vctDot(partVct, vct);
            }
            return retVct;
        }
        private double[,] forward_transform(double bend, double dir, double segLength)
        {
            double[,] retMat =
            {
                {Math.Cos(dir)*Math.Cos(bend), Math.Sin(dir), -Math.Cos(dir)*Math.Sin(bend), segLength * ((1-s_val)*Math.Sin(Math.PI*bend/4))},
                {-Math.Sin(dir)*Math.Cos(bend), Math.Cos(dir), Math.Sin(dir)*Math.Sin(bend),0 },
                {Math.Sin(bend), 0,Math.Cos(bend),segLength*(s_val + (1-s_val)*Math.Cos(Math.PI*bend/4)) },
                {0,0,0,1 }
            };
            return retMat;
        }
    }
}
