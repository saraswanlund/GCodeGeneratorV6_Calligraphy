﻿namespace GCodeGeneratorV6_Calligraphy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SnakeEdgeInput = new System.Windows.Forms.RadioButton();
            this.SnakeMiddleInput = new System.Windows.Forms.RadioButton();
            this.SpiralInput = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.XOriginInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.YOriginInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.InnerDiameterInput = new System.Windows.Forms.NumericUpDown();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BLE_IC_breakout = new System.Windows.Forms.RadioButton();
            this.pulseValueLabel = new System.Windows.Forms.Label();
            this.pulseValue = new System.Windows.Forms.NumericUpDown();
            this.strainGaugeButton = new System.Windows.Forms.RadioButton();
            this.BLEcircuitButton = new System.Windows.Forms.RadioButton();
            this.traceTestButton = new System.Windows.Forms.RadioButton();
            this.traceDir = new System.Windows.Forms.TextBox();
            this.traceDirLabel = new System.Windows.Forms.Label();
            this.traceButton = new System.Windows.Forms.RadioButton();
            this.traceLen = new System.Windows.Forms.NumericUpDown();
            this.traceLenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XOriginInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YOriginInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerDiameterInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceLen)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeEdgeInput
            // 
            this.SnakeEdgeInput.AutoSize = true;
            this.SnakeEdgeInput.Location = new System.Drawing.Point(81, 84);
            this.SnakeEdgeInput.Name = "SnakeEdgeInput";
            this.SnakeEdgeInput.Size = new System.Drawing.Size(110, 21);
            this.SnakeEdgeInput.TabIndex = 0;
            this.SnakeEdgeInput.TabStop = true;
            this.SnakeEdgeInput.Text = "Snake_Edge";
            this.SnakeEdgeInput.UseVisualStyleBackColor = true;
            // 
            // SnakeMiddleInput
            // 
            this.SnakeMiddleInput.AutoSize = true;
            this.SnakeMiddleInput.Location = new System.Drawing.Point(81, 111);
            this.SnakeMiddleInput.Name = "SnakeMiddleInput";
            this.SnakeMiddleInput.Size = new System.Drawing.Size(118, 21);
            this.SnakeMiddleInput.TabIndex = 1;
            this.SnakeMiddleInput.TabStop = true;
            this.SnakeMiddleInput.Text = "Snake_Middle";
            this.SnakeMiddleInput.UseVisualStyleBackColor = true;
            // 
            // SpiralInput
            // 
            this.SpiralInput.AutoSize = true;
            this.SpiralInput.Location = new System.Drawing.Point(81, 138);
            this.SpiralInput.Name = "SpiralInput";
            this.SpiralInput.Size = new System.Drawing.Size(65, 21);
            this.SpiralInput.TabIndex = 2;
            this.SpiralInput.TabStop = true;
            this.SpiralInput.Text = "Spiral";
            this.SpiralInput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X Origin";
            // 
            // XOriginInput
            // 
            this.XOriginInput.Location = new System.Drawing.Point(302, 66);
            this.XOriginInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.XOriginInput.Name = "XOriginInput";
            this.XOriginInput.Size = new System.Drawing.Size(120, 22);
            this.XOriginInput.TabIndex = 4;
            this.XOriginInput.ValueChanged += new System.EventHandler(this.XOriginInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Origin";
            // 
            // YOriginInput
            // 
            this.YOriginInput.Location = new System.Drawing.Point(302, 111);
            this.YOriginInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.YOriginInput.Name = "YOriginInput";
            this.YOriginInput.Size = new System.Drawing.Size(120, 22);
            this.YOriginInput.TabIndex = 6;
            this.YOriginInput.ValueChanged += new System.EventHandler(this.YOriginInput_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inner Diameter";
            // 
            // InnerDiameterInput
            // 
            this.InnerDiameterInput.DecimalPlaces = 2;
            this.InnerDiameterInput.Location = new System.Drawing.Point(302, 203);
            this.InnerDiameterInput.Name = "InnerDiameterInput";
            this.InnerDiameterInput.Size = new System.Drawing.Size(120, 22);
            this.InnerDiameterInput.TabIndex = 8;
            this.InnerDiameterInput.ValueChanged += new System.EventHandler(this.InnerDiameterInput_ValueChanged);
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(498, 12);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(719, 426);
            this.OutputText.TabIndex = 9;
            this.OutputText.TextChanged += new System.EventHandler(this.OutputText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Click to Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(81, 269);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(319, 22);
            this.filePath.TabIndex = 12;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter File Path:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(81, 328);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(319, 22);
            this.fileName.TabIndex = 14;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter File Name:";
            // 
            // BLE_IC_breakout
            // 
            this.BLE_IC_breakout.AutoSize = true;
            this.BLE_IC_breakout.Location = new System.Drawing.Point(81, 165);
            this.BLE_IC_breakout.Name = "BLE_IC_breakout";
            this.BLE_IC_breakout.Size = new System.Drawing.Size(139, 21);
            this.BLE_IC_breakout.TabIndex = 16;
            this.BLE_IC_breakout.TabStop = true;
            this.BLE_IC_breakout.Text = "BLE_IC_breakout";
            this.BLE_IC_breakout.UseVisualStyleBackColor = true;
            this.BLE_IC_breakout.CheckedChanged += new System.EventHandler(this.BLE_IC_breakout_CheckedChanged);
            // 
            // pulseValueLabel
            // 
            this.pulseValueLabel.AutoSize = true;
            this.pulseValueLabel.Location = new System.Drawing.Point(302, 138);
            this.pulseValueLabel.Name = "pulseValueLabel";
            this.pulseValueLabel.Size = new System.Drawing.Size(87, 17);
            this.pulseValueLabel.TabIndex = 18;
            this.pulseValueLabel.Text = "Pulse Value:";
            // 
            // pulseValue
            // 
            this.pulseValue.Location = new System.Drawing.Point(302, 159);
            this.pulseValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pulseValue.Name = "pulseValue";
            this.pulseValue.Size = new System.Drawing.Size(120, 22);
            this.pulseValue.TabIndex = 19;
            this.pulseValue.ValueChanged += new System.EventHandler(this.pulseValue_ValueChanged);
            // 
            // strainGaugeButton
            // 
            this.strainGaugeButton.AutoSize = true;
            this.strainGaugeButton.Location = new System.Drawing.Point(81, 193);
            this.strainGaugeButton.Name = "strainGaugeButton";
            this.strainGaugeButton.Size = new System.Drawing.Size(117, 21);
            this.strainGaugeButton.TabIndex = 20;
            this.strainGaugeButton.TabStop = true;
            this.strainGaugeButton.Text = "Strain_Gauge";
            this.strainGaugeButton.UseVisualStyleBackColor = true;
            this.strainGaugeButton.CheckedChanged += new System.EventHandler(this.strainGaugeButton_CheckedChanged);
            // 
            // BLEcircuitButton
            // 
            this.BLEcircuitButton.AutoSize = true;
            this.BLEcircuitButton.Location = new System.Drawing.Point(81, 221);
            this.BLEcircuitButton.Name = "BLEcircuitButton";
            this.BLEcircuitButton.Size = new System.Drawing.Size(100, 21);
            this.BLEcircuitButton.TabIndex = 21;
            this.BLEcircuitButton.TabStop = true;
            this.BLEcircuitButton.Text = "BLE_circuit";
            this.BLEcircuitButton.UseVisualStyleBackColor = true;
            this.BLEcircuitButton.CheckedChanged += new System.EventHandler(this.BLEcircuitButton_CheckedChanged);
            // 
            // traceTestButton
            // 
            this.traceTestButton.AutoSize = true;
            this.traceTestButton.Location = new System.Drawing.Point(81, 57);
            this.traceTestButton.Name = "traceTestButton";
            this.traceTestButton.Size = new System.Drawing.Size(121, 21);
            this.traceTestButton.TabIndex = 22;
            this.traceTestButton.TabStop = true;
            this.traceTestButton.Text = "Trace_Testing";
            this.traceTestButton.UseVisualStyleBackColor = true;
            this.traceTestButton.CheckedChanged += new System.EventHandler(this.traceTestButton_CheckedChanged);
            // 
            // traceDir
            // 
            this.traceDir.Location = new System.Drawing.Point(208, 57);
            this.traceDir.Name = "traceDir";
            this.traceDir.Size = new System.Drawing.Size(42, 22);
            this.traceDir.TabIndex = 23;
            this.traceDir.TextChanged += new System.EventHandler(this.traceDir_TextChanged);
            // 
            // traceDirLabel
            // 
            this.traceDirLabel.AutoSize = true;
            this.traceDirLabel.Location = new System.Drawing.Point(188, 37);
            this.traceDirLabel.Name = "traceDirLabel";
            this.traceDirLabel.Size = new System.Drawing.Size(109, 17);
            this.traceDirLabel.TabIndex = 24;
            this.traceDirLabel.Text = "Trace Direction:";
            // 
            // traceButton
            // 
            this.traceButton.AutoSize = true;
            this.traceButton.Location = new System.Drawing.Point(81, 30);
            this.traceButton.Name = "traceButton";
            this.traceButton.Size = new System.Drawing.Size(66, 21);
            this.traceButton.TabIndex = 25;
            this.traceButton.TabStop = true;
            this.traceButton.Text = "Trace";
            this.traceButton.UseVisualStyleBackColor = true;
            this.traceButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // traceLen
            // 
            this.traceLen.Location = new System.Drawing.Point(208, 111);
            this.traceLen.Name = "traceLen";
            this.traceLen.Size = new System.Drawing.Size(88, 22);
            this.traceLen.TabIndex = 26;
            this.traceLen.ValueChanged += new System.EventHandler(this.traceLen_ValueChanged);
            // 
            // traceLenLabel
            // 
            this.traceLenLabel.AutoSize = true;
            this.traceLenLabel.Location = new System.Drawing.Point(200, 84);
            this.traceLenLabel.Name = "traceLenLabel";
            this.traceLenLabel.Size = new System.Drawing.Size(97, 17);
            this.traceLenLabel.TabIndex = 27;
            this.traceLenLabel.Text = "Trace Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.traceLenLabel);
            this.Controls.Add(this.traceLen);
            this.Controls.Add(this.traceButton);
            this.Controls.Add(this.traceDirLabel);
            this.Controls.Add(this.traceDir);
            this.Controls.Add(this.traceTestButton);
            this.Controls.Add(this.BLEcircuitButton);
            this.Controls.Add(this.strainGaugeButton);
            this.Controls.Add(this.pulseValue);
            this.Controls.Add(this.pulseValueLabel);
            this.Controls.Add(this.BLE_IC_breakout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InnerDiameterInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YOriginInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XOriginInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpiralInput);
            this.Controls.Add(this.SnakeMiddleInput);
            this.Controls.Add(this.SnakeEdgeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.XOriginInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YOriginInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerDiameterInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SnakeEdgeInput;
        private System.Windows.Forms.RadioButton SnakeMiddleInput;
        private System.Windows.Forms.RadioButton SpiralInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown XOriginInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown YOriginInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown InnerDiameterInput;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton BLE_IC_breakout;
        private System.Windows.Forms.Label pulseValueLabel;
        private System.Windows.Forms.NumericUpDown pulseValue;
        private System.Windows.Forms.RadioButton strainGaugeButton;
        private System.Windows.Forms.RadioButton BLEcircuitButton;
        private System.Windows.Forms.RadioButton traceTestButton;
        private System.Windows.Forms.TextBox traceDir;
        private System.Windows.Forms.Label traceDirLabel;
        private System.Windows.Forms.RadioButton traceButton;
        private System.Windows.Forms.NumericUpDown traceLen;
        private System.Windows.Forms.Label traceLenLabel;
    }
}

