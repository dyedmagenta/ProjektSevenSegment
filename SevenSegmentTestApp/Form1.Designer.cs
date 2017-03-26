namespace SevenSegmentTestApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sevenSegmentPanel1 = new ComponentsLibrary.SevenSegmentPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sevenSegmentPanel1
            // 
            this.sevenSegmentPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.sevenSegmentPanel1.Blinking = false;
            this.sevenSegmentPanel1.CurrentDigits = ComponentsLibrary.SevenSegmentPanel.Digits.Two;
            this.sevenSegmentPanel1.Digit1DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit1LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit2DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit2LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit3DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit3LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit4DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit4LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit5DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit5LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit6DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit6LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit7DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit7LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.Digit8DarkColor = System.Drawing.Color.DarkRed;
            this.sevenSegmentPanel1.Digit8LightColor = System.Drawing.Color.Red;
            this.sevenSegmentPanel1.FrameMainColor = System.Drawing.Color.DeepSkyBlue;
            this.sevenSegmentPanel1.FrameSecondaryColor = System.Drawing.Color.Crimson;
            this.sevenSegmentPanel1.FrameType = ComponentsLibrary.ControlFrame.FrameType.Dotted;
            this.sevenSegmentPanel1.Location = new System.Drawing.Point(12, 1);
            this.sevenSegmentPanel1.Name = "sevenSegmentPanel1";
            this.sevenSegmentPanel1.Size = new System.Drawing.Size(255, 160);
            this.sevenSegmentPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 261);
            this.Controls.Add(this.sevenSegmentPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ComponentsLibrary.SevenSegmentPanel sevenSegmentPanel1;
    }
}

