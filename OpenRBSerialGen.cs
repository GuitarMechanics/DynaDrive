using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaDrive
{
    internal class OpenRBSerialGen
    {
        private const int posCenter = 2048;
        private const int pidPinit = 800;

        private int[] parcedInts = new int[12];
        private int serialID = 0;

        public bool manageSpeed = false;
        public int[] goalPos = new int[4];
        public int[] presPos = new int[4];
        public int[] pidPGains = new int[4];
        public int accMode = 0;
        public int maxSpd = 300;

        public OpenRBSerialGen()
        {
            for (int i = 0; i < 4; i++)
            {
                goalPos[i] = 0;
                pidPGains[i] = pidPinit;
            }
        }

        public void inputStrDecode(string inputStr)
        {
            try
            {
                char[] splits = { ',' };
                string[] strings = inputStr.Split(splits);
                for (int i = 0; i < strings.Length; i++) parcedInts[i] = int.Parse(strings[i]);
                for (int i = 1; i < 5; i++) presPos[i - 1] = parcedInts[i] - posCenter;
            }
            catch(Exception)
            {

            }
        }
        public string[] serialGen()
        {
            string[] retStrs = new string[2];
            string serialStr = "";
            if (serialID != 0) serialStr += serialID.ToString() + ",";
            serialStr += accMode.ToString() + ",";
            serialStr += maxSpd.ToString() + ",";
            if (manageSpeed) serialStr += "1,"; else serialStr += "0,";
            serialStr += "1111,";
            for (int i = 0; i < 4; i++) serialStr += (goalPos[i] + posCenter).ToString() + ",";
            for (int i = 0; i < 4; i++) serialStr += pidPGains[i].ToString() + ",";

            string logStr = "DXL State Update";
            retStrs[0] = serialStr; retStrs[1] = logStr;
            return retStrs;
        }
        public void writeGoalPos(int[] vals)
        {
            for (int i = 0; i < 4; i++) goalPos[i] = vals[i];
        }
        public void writeGoalCenter()
        {
            for (int i = 0; i < 4; i++) goalPos[i] = 0;
        }
        public void writePGains(int[] vals)
        {
            for (int i = 0; i < 4; i++) pidPGains[i] = vals[i];
        }
        public void writeAccMode(int value)
        // accMode : 1 >> slow, 2 >> med, 3 >> fast , default >> instant
        {
            accMode = value;
        }
        public void setSerialID(int serial_ID) { serialID = serial_ID; }
    }
}
