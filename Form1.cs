using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GCodeGeneratorV6_Calligraphy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folder = filePath.Text;
            string filename = fileName.Text;
            string fullpath = folder + filename + ".GCODE";
            Debug.WriteLine(fullpath);
            StreamWriter outputFile = new StreamWriter(fullpath);
            Initialization(outputFile);

            if (SnakeEdgeInput.Checked)
            {
                Print_Snake_Edge(outputFile);
            }

            if (SnakeMiddleInput.Checked)
            {
                Print_Snake_Middle(outputFile);
            }

            if (SpiralInput.Checked)
            {
                Print_Spiral(outputFile);
            }

            if(BLE_IC_breakout.Checked)
            {
                Print_BLE_IC_breakout(outputFile);
            }

            if (strainGaugeButton.Checked)
            {
                Print_strainGauge(outputFile);
            }

            End(outputFile);
        }

        void write2File(StreamWriter f, List<string> str)
        {
            foreach (String s in str)
            {
                f.WriteLine(s);
                this.OutputText.Text += s + "\r\n";
            }
        }
        /*
        void printPad(StreamWriter f)
        {

        }*/

        void Initialization(StreamWriter f)
        {
            List<string> initText = new List<string> { };
            initText.Add("G53");
            initText.Add("G21");
            initText.Add("G90");
            //initText.Add("M190 90"); 
            initText.Add("T15");
            initText.Add("M756 S0.1");
            initText.Add("M6 T15 O1 X0 Y0 Z0");
            initText.Add("M721 S10000 E6000 P-100 T15");
            initText.Add("M722 S10000 E6000 P-100 T15");

            decimal InnerDiameter = InnerDiameterInput.Value;
            int Pulses = Convert.ToInt32(pulseValue.Value);

            initText.Add("M221 S1 T15 P" + Pulses.ToString() + " W" + InnerDiameter.ToString() + " Z0.1");
            initText.Add("M82");
            initText.Add("M229 E0 D0");
            initText.Add("G28 X0 Y0");
            initText.Add("G92 X0 Y0");
            initText.Add("G0 Z4");
            
            decimal XOrigin = XOriginInput.Value;
            decimal YOrigin = YOriginInput.Value;

            initText.Add("G1 X" + XOrigin.ToString() + " Y" + YOrigin.ToString() + " F2400");
            initText.Add("G0 Z0.1");
            initText.Add("G91");


            this.OutputText.Text = "";
            write2File(f, initText);

        }

        void Print_Snake_Edge(StreamWriter f)
        {
            List<string> edgeText = new List<string> { };

            decimal Width = 3;
            decimal Length = 3;
            decimal Overlap = (decimal)100 - 50;
            decimal factor = Overlap / 100;
            decimal InnerDiameter = InnerDiameterInput.Value;
            decimal offset = InnerDiameter * factor;
            decimal limit = Width / offset;
            decimal Directioncheck = 0;

            decimal TranCheck = 0;
            for (int x = 0; x <= (limit / 2); x++)
            {
                edgeText.Add("G1 Y" + Width.ToString() + " E1 F400");
                edgeText.Add("G1 X" + offset.ToString() + " E1 F400");


                TranCheck += offset;
                if (TranCheck >= Length)
                {
                    edgeText.Add("G1 Y-" + Width.ToString() + " E1 F400");

                    
                    Directioncheck = 1;
                    break;
                }

                edgeText.Add("G1 Y-" + Width.ToString() + " E1 F400");
                edgeText.Add("G1 X" + offset.ToString() + " E1 F400");

                TranCheck += offset;
                if (TranCheck >= Length)
                {
                    edgeText.Add("G1 Y" + Width.ToString() + " E1 F400");
                    break;
                }
            }

            if (Directioncheck == 1)
            {
                edgeText.Add("G1 Y" + Width.ToString() + " F2400");
            }

            write2File(f, edgeText);
        }

        void Print_Snake_Middle(StreamWriter f)
        {
            List<string> midText = new List<string> { };

            midText.Add("G1 X1.5 Y1.5 F400");
            midText.Add("G1 Y1.5 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");

            midText.Add("G1 Y-3 E1 F400");
            midText.Add("G1 X-2.87 E1 F400");
            midText.Add("G1 Y3 E1 F400");

            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y-2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");
            midText.Add("G1 Y2.795 E1 F400");
            midText.Add("G1 X0.205 E1 F400");

            write2File(f, midText);
        }

        void Print_Spiral(StreamWriter f)
        {
            List<string> spiralText = new List<string> { };

            decimal loops = (decimal)3 / (decimal)InnerDiameterInput.Value;
            decimal adder = InnerDiameterInput.Value / (decimal)2;
            decimal temp = 0;
            for (int x = 1; x <= loops; x++)
            {
                spiralText.Add("G1 X-" + adder.ToString() + " E1 F400");
                spiralText.Add("G1 Y-" + adder.ToString() + " E1 F400");

                temp = adder + (InnerDiameterInput.Value / (decimal)2);

                spiralText.Add("G1 X" + temp.ToString() + " E1 F400");
                spiralText.Add("G1 Y" + temp.ToString() + " E1 F400");

                if (x == loops)
                {
                    spiralText.Add("G1 X-" + temp.ToString() + " E1 F400");
                }
                else
                {
                    adder += (decimal)2 * (InnerDiameterInput.Value / (decimal)2);
                    temp = 0;
                }
            }
            
            write2File(f, spiralText);
        }

        void Print_BLE_IC_breakout(StreamWriter f)
        {
            List<string> ICText = new List<string> { };
            


        }

        void Print_strainGauge(StreamWriter f)
        {
            List<string> strainText = new List<string> { };

            strainText.Add("G1 Y25 E1 F400;");
            strainText.Add("G1 X7 E1 F400;");
            strainText.Add("G1 Y12 E1 F400;");

            int turns = 11;

            for (int i = 0; i < turns; i++) //FOR LOOP TO MAKE THE TURNS OF THE STRAIN GAUGE
            {
                strainText.Add("G1 Y25 E1 F400;");
                strainText.Add("G1 X-1 E1 F400;");

                decimal needleTipD = InnerDiameterInput.Value;
                decimal stepover = (needleTipD / 2);
                int steps = (int)Math.Ceiling(1 / stepover);
                strainText.Add("G1 Y-" + (stepover*steps).ToString() +";");
                
                for(int j = 0; j < steps; j++)//FOR LOOP TO MAKE THE TINY SQUARES AT THE END OF THE GAUGE
                {
                    if(j%2 == 0)
                    {
                        strainText.Add("G1 X1 E1 F400;");
                        strainText.Add("G1 Y" + stepover.ToString() + " E1 F400;");
                    }
                    else
                    {
                        strainText.Add("G1 X-1 E1 F400;");
                        strainText.Add("G1 Y" + stepover.ToString() + " E1 F400;");
                    }

                }
                strainText.Add("G1 X-1 E1 F400;");
                strainText.Add("G1 Y-25 E1 F400;");

                if (i == turns - 1)
                {
                    break;
                }
                else
                {
                    strainText.Add("G1 X-1 E1 F400;");
                }
            }

            strainText.Add("G1 Y-12 E1 F400;");
            strainText.Add("G1 X7 E1 F400;");
            strainText.Add("G1 Y-25 E1 F400;");

            write2File(f, strainText);
        }

        void End(StreamWriter f)
        {
            List<string> endText = new List<string> { };

            endText.Add("");
            endText.Add("G90");
            endText.Add("G0 Z4");
            endText.Add("G92 E0");
            endText.Add("G28 X0 Y0");
            endText.Add("M106 T10 S0");
            endText.Add("M104 S0");
            endText.Add("G91");
            endText.Add("G90");
            endText.Add("M84");
            endText.Add("M30");

            write2File(f, endText);
            f.Close();
        }

        private void OutputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void InnerDiameterInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void YOriginInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void XOriginInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void filePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BLE_IC_breakout_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pulseValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void strainGaugeButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
