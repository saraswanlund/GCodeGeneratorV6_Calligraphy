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

        const double pinLength = 1.1;

        private void button1_Click(object sender, EventArgs e)
        {
            string folder = filePath.Text;
            string filename = fileName.Text;
            string fullpath = folder + filename + ".GCODE";
            Debug.WriteLine(fullpath);
            StreamWriter outputFile = new StreamWriter(fullpath);
            Initialization(outputFile);
            
            if (SnakeEdgeInput.Checked)//DEPRECATED
            {
                Print_Snake_Edge(outputFile);
            }

            if (SnakeMiddleInput.Checked)//DEPRECATED
            {
                Print_Snake_Middle(outputFile);
            }

            if (SpiralInput.Checked)
            {
                Print_Spiral(outputFile, (decimal)3.0);
            }

            if (BLE_IC_breakout.Checked)
            {
                Print_BLE_IC_breakout(outputFile);
            }

            if (strainGaugeButton.Checked)
            {
                Print_strainGauge(outputFile);
            }

            if (BLEcircuitButton.Checked)
            {
                Print_BLE_circuit(outputFile);
            }

            if (traceTestButton.Checked)
            {
                Print_Trace_Test(outputFile, traceDir.Text.ToCharArray()[0]);
            }

            if (traceButton.Checked)
            {
                printTrace(outputFile, traceLen.Value ,traceDir.Text.ToCharArray()[0]);
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
            int Pulses = (int)pulseValue.Value;

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

        void Print_Trace_Test(StreamWriter f, char dir)
        {
            List<string> traceTestText = new List<string> { };

            for(int i = 0; i < 10; i++)
            {
                write2File(f, traceTestText);
                traceTestText.Clear();
                if(dir == 'X' || dir == 'x')
                {
                    printTrace(f, (decimal)10.0, 'X');
                    traceTestText.Add("G1 Y2 F400;");
                }else if(dir == 'Y' || dir == 'y')
                {
                    printTrace(f, (decimal)10.0, 'Y');
                    traceTestText.Add("G1 X2 F400;");
                }
                else
                {
                    printTrace(f, (decimal)10.0, 'e');
                }
            }

            write2File(f, traceTestText);
        }

        void printTrace(StreamWriter f, decimal length, char dir)
        {
            List<string> traceText = new List<string> { };

            //WILL PRINT A LINE IN THE DESIGNATED DIRECTION THAT IS <length> MM LONG AND THEN RETURNS TO THE START OF THE LINE
            //ASSUMES THAT THE NEEDLE HEAD IS STARTING AT A Z HEIGHT OF 4 MM
            if(dir == 'X' || dir == 'x')
            {
                traceText.Add("G0 Z-3.9;");
                traceText.Add("G1 X" + length.ToString() + " E1 F400;");
                traceText.Add("G0 Z3.9;");
                traceText.Add("G1 X-" + length.ToString() + " F400;");
            }
            else if(dir == 'Y' || dir == 'y')
            {
                traceText.Add("G0 Z-3.9;");
                traceText.Add("G1 Y" + length.ToString() + " E1 F400;");
                traceText.Add("G0 Z3.9;");
                traceText.Add("G1 Y-" + length.ToString() + " F400;");
            }
            else
            {
                traceText.Add("####ERROR, INVALID INPUT FOR TRACE DIRECTION####");
            }

            write2File(f, traceText);
        }

        void doubleTrace(StreamWriter f, decimal length, char dir)
        {
            List<string> dTraceText = new List<string> { };

            //WILL PRINT A LINE IN THE DESIGNATED DIRECTION THAT IS <length> MM LONG AND THEN RETURNS TO THE START OF THE LINE
            //ASSUMES THAT THE NEEDLE HEAD IS STARTING AT A Z HEIGHT OF 4 MM
            if (dir == 'X' || dir == 'x')
            {
                dTraceText.Add("G0 Z-3.9;");
                dTraceText.Add("G1 X" + length.ToString() + " E1 F400;");
                dTraceText.Add("G1 X-" + length.ToString() + "E1 F400;");
                dTraceText.Add("G0 Z3.9;");
            }
            else if (dir == 'Y' || dir == 'y')
            {
                dTraceText.Add("G0 Z-3.9;");
                dTraceText.Add("G1 Y" + length.ToString() + " E1 F400;");
                dTraceText.Add("G1 Y-" + length.ToString() + " E1 F400;");
                dTraceText.Add("G0 Z3.9;");
            }
            else
            {
                dTraceText.Add("####ERROR, INVALID INPUT FOR TRACE DIRECTION####");
            }

            write2File(f, dTraceText);  
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

        void Print_Spiral(StreamWriter f, decimal size)
        {
            List<string> spiralText = new List<string> { };

            decimal InnerDiameter = InnerDiameterInput.Value;
            int Pulses = (int)pulseValue.Value;
            spiralText.Add("M221 S1 T15 P800 W" + InnerDiameter.ToString() + " Z0.1");

            decimal loops = size / (decimal)InnerDiameterInput.Value;
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

            //RETURN TO CENTER
            spiralText.Add("G0 Z3.9;");
            spiralText.Add("G1 X-" + (size/2).ToString() + " Y-" + (size/2).ToString() + " F400");
            spiralText.Add("G0 Z-3.9;");

            spiralText.Add("M221 S1 T15 P" + Pulses.ToString() + " W" + InnerDiameter.ToString() + " Z0.1");
            write2File(f, spiralText);
        }

        void Print_BLE_IC_breakout(StreamWriter f)
        {
            List<string> ICText = new List<string> { };
            //ASSUMING ORIGIN IS AT TOP LEFT CORNER OF PIN

            ICText.Add("G0 Z3.9;");
            ICText.Add("G1 X10 Y4.2 F400;");
            ICText.Add("G0 Z-3.9");

            //PRINT A SPIRAL PAD
            write2File(f, ICText);
            ICText.Clear();
            Print_Spiral(f, (decimal)3.0);

            ICText.Add("G1 X-" + (10 + pinLength).ToString() + " E1 F400;");
            ICText.Add("G0 Z3.9;");
            ICText.Add("G1 X" + (10 + pinLength).ToString() + " Y9.3 F400;");
            ICText.Add("G0 Z-3.9;");

            //PRINT A SPIRAL PAD
            write2File(f, ICText);
            ICText.Clear();
            Print_Spiral(f, (decimal)3.0);

            ICText.Add("G1 X-" + (10 + pinLength).ToString() + " E1 F400;");
            ICText.Add("G0 Z3.9;");
            ICText.Add("G1 X-" + (20 - pinLength).ToString() + " Y-12.7 F400;");
            ICText.Add("G0 Z-3.9;");

            //PRINT A SPIRAL PAD
            write2File(f, ICText);
            ICText.Clear();
            Print_Spiral(f, (decimal)3.0);

            ICText.Add("G1 X10 Y5 E1 F400;");
            ICText.Add("G1 X" + pinLength.ToString() + " E1 F400;");
            ICText.Add("G0 Z3.9;");
            ICText.Add("G1 X-" + (10 + pinLength).ToString() + " Y0.7 F400;");
            ICText.Add("G0 Z-3.9;");

            //PRINT A SPIRAL PAD
            write2File(f, ICText);
            ICText.Clear();
            Print_Spiral(f, (decimal)3.0);

            ICText.Add("G1 X" + (10 + pinLength).ToString() + " E1 F400;");
            ICText.Add("G0 Z3.9;");
            ICText.Add("G1 X-" + (10 + pinLength).ToString() + " Y5.7 F400;");
            ICText.Add("G0 Z-3.9;");

            //PRINT A SPIRAL PAD
            write2File(f, ICText);
            ICText.Clear();
            Print_Spiral(f, (decimal)3.0);

            ICText.Add("G1 X10 Y-5 E1 F400");
            ICText.Add("G1 X" + pinLength.ToString() + " E1 F400");

            write2File(f, ICText);

        }

        void Print_strainGauge(StreamWriter f)
        {
            List<string> strainText = new List<string> { };

            int turns = 24;
            decimal InnerDiameter = InnerDiameterInput.Value;

            //PRINT TRACES FIRST
            strainText.Add("G1 Y12 E1 F400;");
            for (int i = 0; i < turns; i++) //FOR LOOP TO MAKE THE TURNS OF THE STRAIN GAUGE
            {
                write2File(f, strainText);
                strainText.Clear();
                doubleTrace(f, 25, 'y');
                strainText.Add("G1 X-" + (1 + InnerDiameter).ToString() + " F400;");

                if (i == turns - 1)
                {
                    strainText.Add("G1 X" + (1 + InnerDiameter).ToString() + " F400;");
                    strainText.Add("G0 Z-3.9;");
                    break;
                }
            }
            strainText.Add("G1 Y-12 E1 F400;");
            strainText.Add("G0 Z3.9;");

            //PRINT PADS
            //CONTACT PADS
            strainText.Add("G1 Y12 F400;");
            strainText.Add("G0 Z-3.9;");
            strainText.Add("G1 Y-12 E1 F400;");
            strainText.Add("G0 Z-3.9;");
            write2File(f, strainText);
            strainText.Clear();
            Print_Spiral(f, 3);
            strainText.Add("G0 Z3.9;");
            strainText.Add("G1 X" + ((turns - 1) * (1 + InnerDiameter)).ToString() + " F400;");
            strainText.Add("G0 Z-3.9;");
            write2File(f, strainText);
            strainText.Clear();
            Print_Spiral(f, 3);
            strainText.Add("G1 Y12 E1 F400;");
            strainText.Add("G0 Z3.9;");
            strainText.Add("G1 Y25 F400;");

            //PRINT LOWER ROW OF PADS
            strainText.Add("G1 X-" + ((1 + InnerDiameter)/2).ToString() + " F400;");
            strainText.Add("G0 Z-3.9");
            
            for(int i = 0; i < turns/2; i++)
            {
                write2File(f, strainText);
                strainText.Clear();
                Print_Spiral(f, 1);
                strainText.Add("G0 Z3.9;");
                strainText.Add("G1 X-" + ((decimal)2.0 + InnerDiameter * (decimal)1.7).ToString() + " F400;");
                strainText.Add("G0 Z-3.9;");
            }

            //PRINT UPPER PADS
            strainText.Add("G0 Z3.9;");
            strainText.Add("G1 X" + ((turns/2)*(((decimal)2.0 + InnerDiameter * (decimal)1.7))).ToString() + " Y-24 F400;");
            strainText.Add("G1 X-" + (1+InnerDiameter).ToString() + " F400;");
            strainText.Add("G0 Z-3.9;");
            for(int i = 0; i < ((turns/2)-1); i++)
            {
                write2File(f, strainText);
                strainText.Clear();
                Print_Spiral(f, (decimal)0.5);
                strainText.Add("G0 Z3.9;");
                strainText.Add("G1 X-" + ((decimal)2.0 + InnerDiameter * (decimal)1.7).ToString() + " F400;");
                strainText.Add("G0 Z-3.9;");
            }

            write2File(f, strainText);
        }

        void Print_BLE_circuit(StreamWriter f)
        {
            List<string> circuitText = new List<string> { };

            //ASSUMES ORIGIN IS AT TOP LEFT GND PAD
            Print_Spiral(f, 3);
            circuitText.Add("G0 Z3.9;");
            doubleTrace(f, (decimal)(12 + pinLength), 'Y');
            circuitText.Add("G1 X-16 F400;");
            circuitText.Add("G0 Z-3.9;");
            circuitText.Add("G0 Z-3.9;");
            write2File(f, circuitText);
            circuitText.Clear();
            Print_Spiral(f, 3);
            circuitText.Add("G0 Z3.9");
            write2File(f, circuitText);
            circuitText.Clear();
            doubleTrace(f, 32, 'y');
            circuitText.Add("G1 Y32 F400;");
            circuitText.Add("G0 Z-3.9");
            write2File(f, circuitText);
            circuitText.Clear();
            doubleTrace(f, (decimal)9.6, 'x');
            circuitText.Add("G1 X9.6 F400;");
            circuitText.Add("G0 Z-3.9");
            circuitText.Add("G1 Y-" + (10 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G1 Y" + (10 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G0 Z3.9;");
            circuitText.Add("G1 X-7.62 Y5 F400;");
            write2File(f, circuitText);
            circuitText.Clear();
            doubleTrace(f, (decimal)11.82, 'x');
            circuitText.Add("G1 X11.82 F400;");
            circuitText.Add("G0 Z-3.9;");
            circuitText.Add("G1 Y-" + (15 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G1 Y" + (15 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G0 Z3.9;");
            circuitText.Add("G1 X16.02 F400;");
            circuitText.Add("G0 Z-3.9;");
            circuitText.Add("G1 X-11.82 E1 F400;");
            circuitText.Add("G1 Y-" + (15 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G1 Y" + (15 + pinLength).ToString() + " E1 F400;");
            circuitText.Add("G1 X11.82 E1 F400;");

            write2File(f, circuitText);
            circuitText.Clear();
            Print_strainGauge(f);

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

        private void BLEcircuitButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traceTestButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traceDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traceLen_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
