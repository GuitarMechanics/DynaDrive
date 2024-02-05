using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DynaDrive
{
    public class ArrayMath
    {
        public double[,] multArray(double[,] arr1, double[,] arr2)
        {
            double[,] answer = new double[arr1.GetLength(0), arr2.GetLength(1)];
            if (arr1.GetLength(1) == arr2.GetLength(0))
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr2.GetLength(1); k++)
                        {
                            answer[i, k] += arr1[i, j] * arr2[j, k];
                        }
                    }
                }
            }
            return answer;
        }
        public double[,] addArray(double[,] arr1, double[,] arr2)
        {
            double[,] answer;
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
            {
                answer = new double[arr1.GetLength(0), arr1.GetLength(1)];
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0;j < arr1.GetLength(1); j++)
                        answer[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
            else answer = new double[3,3] { { 1, 0, 0 },{ 0, 1, 0 },{ 0, 0, 1 } };
            return answer;
        }
    }

    class Tube
    {
        public double I, K, OD, ID, rho, L_s, L_c, angle, E, angleRt, lengthTr, tubeExist = 1;
        public double curvature(double lengthTr, double length)
        {
            double curvature;
            if (L_s >= L_s + L_c - lengthTr + length) curvature = 0;
            else if (length > lengthTr)
            {
                curvature = 0;
                tubeExist = 0;
            }
            else curvature = K;
            //Console.WriteLine(K);
            return curvature;
        }
    }
    internal class CtrPositionControl : CtrMovementControl
    {
        

        public double rho_f;
        public double L_1, L_2; public double[] L_c = new double[3];
        public double angle_f;
        public double E;
        public double angleRt_f;
        public bool[] PcToggles = new bool[2];
        Tube tube1 = new Tube();
        Tube tube2 = new Tube();
        ArrayMath arrayMath = new ArrayMath();
        public CtrPositionControl(Form1 Form, OpenRBSerialGen openRB) : base(Form, openRB)
        {
            PcPreset(Form);
            updateVal(openRB);
        }
        public void PcPreset(Form1 Form)
        {
            tube1.OD = Convert.ToDouble(Form.PcTube1ODTxtbox.Text.ToString());
            tube1.ID = Convert.ToDouble(Form.PcTube1IDTxtbox.Text.ToString());
            tube2.OD = Convert.ToDouble(Form.PcTube2ODTxtbox.Text.ToString());
            tube2.ID = Convert.ToDouble(Form.PcTube2IDTxtbox.Text.ToString());
            tube1.rho = Convert.ToDouble(Form.PcTube1RhoTxtbox.Text.ToString());
            tube2.rho = Convert.ToDouble(Form.PcTube2RhoTxtbox.Text.ToString());
            tube1.angle = Convert.ToDouble(Form.PcTube1AngleTxtbox.Text.ToString())/180.0*Math.PI;
            tube2.angle = Convert.ToDouble(Form.PcTube2AngleTxtbox.Text.ToString())/180.0*Math.PI;
            tube1.E = Convert.ToDouble(Form.PcTube1ETxtbox.Text.ToString());
            tube2.E = Convert.ToDouble(Form.PcTube2ETxtbox.Text.ToString());
            
            E = tube1.E / tube2.E;
            tube1.I = Math.PI / 64 * (Math.Pow(tube1.OD, 4) - Math.Pow(tube1.ID, 4));
            tube2.I = Math.PI / 64 * (Math.Pow(tube2.OD, 4) - Math.Pow(tube2.ID, 4));
            tube1.K = 1 / tube1.rho;
            tube2.K = 1 / tube2.rho;
            tube1.L_c = tube1.angle * tube1.rho;
            tube2.L_c = tube2.angle* tube2.rho;
        }
        public double[] PolarToCartesian(double r, double phi, double z_p)
        {
            double[] cartesian = new double[3];
            cartesian[0] = r*Math.Cos(phi);
            cartesian[1] = r*Math.Sin(phi);
            cartesian[2] = z_p;
            return cartesian;
        }
        public double[] CartesianToPolar(double x, double y, double z)
        {
            double[] polar = new double[3];
            polar[0] = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            if (x > 0) polar[1] = Math.Atan(y / x);
            else if (x == 0 && y > 0) polar[1] = Math.PI / 2;
            else if (x < 0) polar[1] = Math.PI + Math.Atan(y / x);
            else if (x == 0 && y < 0) polar[1] = 3 * Math.PI / 2;
            polar[2] = z;
            return polar;
        }

        public void updateVal(OpenRBSerialGen openRB)
        {
            tube1.angleRt = Convert.ToDouble(openRB.goalPos[2] - mtZeroPos[2]) / 4096 * Math.PI * 2;
            tube2.angleRt = Convert.ToDouble(openRB.goalPos[0] - mtZeroPos[0]) / 4096 * Math.PI * 2;
            tube1.lengthTr = -Convert.ToDouble(openRB.goalPos[3] - mtZeroPos[3]) / 4096 * (14 * 2 * Math.PI);
            tube2.lengthTr = -Convert.ToDouble(openRB.goalPos[1] - mtZeroPos[1]) / 4096 * (14 * 2 * Math.PI) + 3.5;
            tube1.tubeExist = 1;
            tube2.tubeExist = 1;
            Array.Resize(ref L_c, 2);

            if (tube1.lengthTr > tube1.L_c) 
            {
                Array.Resize(ref L_c, 3);
                L_c[2] = (tube1.lengthTr - tube1.L_c);
            }
            L_c[0] = (tube1.lengthTr);
            L_c[1] = (tube2.lengthTr);
            Array.Sort(L_c);
        }
        public double[,] rotationY(double x)
        {
            double[,] R = new double[3, 3] { { Math.Cos(x), 0, Math.Sin(x) },{ 0, 1, 0 },{ -Math.Sin(x), 0, Math.Cos(x) } };
            return R;
        }
        public double[,] rotationZ(double x)
        {
            double[,] R = new double[3, 3] { { Math.Cos(x), -Math.Sin(x), 0 }, { Math.Sin(x), Math.Cos(x), 0 }, { 0, 0, 1 }, };
            return R;
        }
        public void PcGetXyzPos(Form1 Form, OpenRBSerialGen openRB)
        {
            
            PcToggles[0] = Form.PcTolToggle.Checked;
            PcToggles[1] = Form.PcTboToggle.Checked;
            PcPreset(Form);
            updateVal(openRB);
            double theta_0 = 0.07;
            double K_x, K_y, K_f = 0, K_t1 = 0,K_t2 = 0, K_tx = 0, K_ty = 0, K_t = 0;
            double angleRt1 = tube1.angleRt;
            double angleRt2 = tube2.angleRt;
            double angle_t, theta_t = 0;
            double K_1 ;
            double K_2 ;
            double phi, theta = 0, L, L_t = 0, sumL = 0, d = 0.7/2;
            double x_p, y_p, z_p;
            double[,] P = new double[3, 1] { { 0 }, { 0 }, { 0 } };
            double[,] Ori = new double[3, 1] { { 0 }, { 0 }, { 1 } };
            double[,] P_p = new double[3, 1];
            double[,] R = new double[3, 3] { { 1, 0, 0 },{ 0, 1, 0 },{ 0, 0, 1 } };
            double[,] R_t = new double[3, 3];
            double[,] ans = new double[3, 2];
            bool IsTol1 = true, IsTol2 = true;

            foreach (double length in L_c)
            {
                // 현재 구간 길이
                L = length - sumL;

                sumL += L;

                // 현재 구간 각각의 튜브 곡률
                K_1 = tube1.curvature(tube1.lengthTr, length);
                K_2 = tube2.curvature(tube2.lengthTr, length);
                
                // 튜브 공차 offset rotation matrix
                if (tube1.tubeExist == 0)
                {

                }
                if (tube2.tubeExist == 0 && IsTol2 && PcToggles[0])
                {
                    K_t1 /= L_t;
                    K_t2 /= L_t;

                    K_tx = K_t1*Math.Cos(angleRt1) - K_t2*Math.Cos(angleRt2);
                    K_ty = K_t1*Math.Sin(angleRt1) - K_t2*Math.Sin(angleRt2);
                    K_t = Math.Sqrt(Math.Pow(K_tx, 2) + Math.Pow(K_ty, 2));
                    angle_t = Math.Atan2(K_ty, K_tx);

                    
                    if (1 / K_t - 1 / K_t * Math.Cos(L_t * K_t / 2) > d / 2)
                    {   
                        K_t = 1 / (Math.Pow(L_t,2) / 5.6 + 0.35);
                        theta_t = Math.Asin((L_t / 2)/ (1 / K_t))*2;
                    }
                    R = arrayMath.multArray(R,rotationY(theta_t));

                    K_t1 = 0;
                    K_t2 = 0;
                    L_t = 0;
                    IsTol2 = false;
                }

                K_t1 += K_1 * L;
                K_t2 += K_2 * L;
                L_t += L;
                
                
                // 현재 구간 튜브 최종 곡률
                K_x = (E * tube1.I * K_1 * Math.Cos(angleRt1) + tube2.I * K_2 * Math.Cos(angleRt2)) / ((E * tube1.I * tube1.tubeExist) + (tube2.I * tube2.tubeExist));
                K_y = (E * tube1.I * K_1 * Math.Sin(angleRt1) + tube2.I * K_2 * Math.Sin(angleRt2)) / ((E * tube1.I * tube1.tubeExist) + (tube2.I * tube2.tubeExist));
                K_f = Math.Sqrt(Math.Pow(K_x, 2) + Math.Pow(K_y, 2));

                theta = L * K_f;

                // 현재 구간 튜브 최종 각도
                if (K_y == 0 && K_x == 0) phi = 0;
                else phi = Math.Atan2(K_y, K_x);
                if (K_f == 0)
                {
                    x_p = 0; y_p = 0; z_p = L;
                }
                else 
                {
                    x_p = 1 / K_f * (1 - Math.Cos(L * K_f)) * Math.Cos(phi);
                    y_p = 1 / K_f * (1 - Math.Cos(L * K_f)) * Math.Sin(phi);
                    z_p = 1 / K_f * Math.Sin(L * K_f);
                }
                
                // base frame에 대한 위치벡터 연산
                P_p = new double[3, 1] { { x_p }, { y_p }, { z_p } };
                P_p = arrayMath.multArray(R, P_p);
                P = arrayMath.addArray(P, P_p);

                Console.WriteLine(angleRt1);

                // 다음 구간 각각의 튜브 각도
                angleRt1 -= phi;
                angleRt2 -= phi;

                // 다음 구간 rotation matrix

                R = arrayMath.multArray(R, rotationZ(phi));

                    
                if (IsTol1 && PcToggles[1]) // base frame 공차 offset rotation matrix
                {
                    R = arrayMath.multArray(R, rotationY(theta_0));
                    IsTol1 = false;
                }

                R = arrayMath.multArray(R, rotationY(theta));

            }

            // Orientation 구하기
            Ori = arrayMath.multArray(R, Ori);
           for(int i = 0; i < 3; i++)
            {
                ans[i, 0] = P[i, 0];
                ans[i, 1] = Ori[i, 0];
            }

            Form.PcXPosTxtbox.Text = ans[0, 0].ToString();
            Form.PcYPosTxtbox.Text = ans[1, 0].ToString();
            Form.PcZPosTxtbox.Text = ans[2, 0].ToString();

            Form.PcXOriTxtbox.Text = ans[0, 1].ToString();
            Form.PcYOriTxtbox.Text = ans[1, 1].ToString();
            Form.PcZOriTxtbox.Text = ans[2, 1].ToString();
        }
    }
}
