using System.Collections.Generic;

namespace ComponentsLibrary
{
    partial class SingleDigit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lightH = new ComponentsLibrary.SingleLight();
            this.lightF = new ComponentsLibrary.SingleLight();
            this.lightE = new ComponentsLibrary.SingleLight();
            this.lightB = new ComponentsLibrary.SingleLight();
            this.lightC = new ComponentsLibrary.SingleLight();
            this.lightG = new ComponentsLibrary.SingleLight();
            this.lightD = new ComponentsLibrary.SingleLight();
            this.lightA = new ComponentsLibrary.SingleLight();
            this.SuspendLayout();
            // 
            // lightH
            // 
            this.lightH.Blink = false;
            this.lightH.DarkColor = System.Drawing.Color.Thistle;
            this.lightH.IsOff = false;
            this.lightH.LightColor = System.Drawing.Color.Magenta;
            this.lightH.Location = new System.Drawing.Point(105, 133);
            this.lightH.Name = "lightH";
            this.lightH.Size = new System.Drawing.Size(10, 10);
            this.lightH.TabIndex = 7;
            // 
            // lightF
            // 
            this.lightF.Blink = false;
            this.lightF.DarkColor = System.Drawing.Color.Thistle;
            this.lightF.IsOff = false;
            this.lightF.LightColor = System.Drawing.Color.Magenta;
            this.lightF.Location = new System.Drawing.Point(7, 16);
            this.lightF.Name = "lightF";
            this.lightF.Size = new System.Drawing.Size(10, 55);
            this.lightF.TabIndex = 6;
            // 
            // lightE
            // 
            this.lightE.Blink = false;
            this.lightE.DarkColor = System.Drawing.Color.Thistle;
            this.lightE.IsOff = false;
            this.lightE.LightColor = System.Drawing.Color.Magenta;
            this.lightE.Location = new System.Drawing.Point(7, 77);
            this.lightE.Name = "lightE";
            this.lightE.Size = new System.Drawing.Size(10, 55);
            this.lightE.TabIndex = 5;
            // 
            // lightB
            // 
            this.lightB.Blink = false;
            this.lightB.DarkColor = System.Drawing.Color.Thistle;
            this.lightB.IsOff = false;
            this.lightB.LightColor = System.Drawing.Color.Magenta;
            this.lightB.Location = new System.Drawing.Point(89, 16);
            this.lightB.Name = "lightB";
            this.lightB.Size = new System.Drawing.Size(10, 55);
            this.lightB.TabIndex = 4;
            // 
            // lightC
            // 
            this.lightC.Blink = false;
            this.lightC.DarkColor = System.Drawing.Color.Thistle;
            this.lightC.IsOff = false;
            this.lightC.LightColor = System.Drawing.Color.Magenta;
            this.lightC.Location = new System.Drawing.Point(89, 77);
            this.lightC.Name = "lightC";
            this.lightC.Size = new System.Drawing.Size(10, 55);
            this.lightC.TabIndex = 3;
            // 
            // lightG
            // 
            this.lightG.Blink = false;
            this.lightG.DarkColor = System.Drawing.Color.Thistle;
            this.lightG.IsOff = false;
            this.lightG.LightColor = System.Drawing.Color.Magenta;
            this.lightG.Location = new System.Drawing.Point(23, 77);
            this.lightG.Name = "lightG";
            this.lightG.Size = new System.Drawing.Size(60, 10);
            this.lightG.TabIndex = 2;
            // 
            // lightD
            // 
            this.lightD.Blink = false;
            this.lightD.DarkColor = System.Drawing.Color.Thistle;
            this.lightD.IsOff = false;
            this.lightD.LightColor = System.Drawing.Color.Magenta;
            this.lightD.Location = new System.Drawing.Point(23, 133);
            this.lightD.Name = "lightD";
            this.lightD.Size = new System.Drawing.Size(60, 10);
            this.lightD.TabIndex = 1;
            // 
            // lightA
            // 
            this.lightA.Blink = false;
            this.lightA.DarkColor = System.Drawing.Color.Thistle;
            this.lightA.IsOff = false;
            this.lightA.LightColor = System.Drawing.Color.Magenta;
            this.lightA.Location = new System.Drawing.Point(23, 3);
            this.lightA.Name = "lightA";
            this.lightA.Size = new System.Drawing.Size(60, 10);
            this.lightA.TabIndex = 0;
            // 
            // SingleDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lightH);
            this.Controls.Add(this.lightF);
            this.Controls.Add(this.lightE);
            this.Controls.Add(this.lightB);
            this.Controls.Add(this.lightC);
            this.Controls.Add(this.lightG);
            this.Controls.Add(this.lightD);
            this.Controls.Add(this.lightA);
            this.Name = "SingleDigit";
            this.Size = new System.Drawing.Size(120, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private SingleLight lightA;
        private SingleLight lightD;
        private SingleLight lightG;
        private SingleLight lightC;
        private SingleLight lightB;
        private SingleLight lightF;
        private SingleLight lightE;
        private SingleLight lightH;
    }
}
