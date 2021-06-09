namespace GCodeGeneratorV6_Calligraphy
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
            this.button2 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BLE_IC_breakout = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.XOriginInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YOriginInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerDiameterInput)).BeginInit();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.BLE_IC_breakout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton BLE_IC_breakout;
    }
}

