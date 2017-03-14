namespace Image_Processing_Studio_1._0
{
    partial class ColorAdjustment
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Color Adjustment";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Red";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Green";
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(71, 53);
            this.RedBar.Maximum = 255;
            this.RedBar.Minimum = -255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(170, 45);
            this.RedBar.TabIndex = 9;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(71, 104);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Minimum = -255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(170, 45);
            this.GreenBar.TabIndex = 7;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(71, 155);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Minimum = -255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(170, 45);
            this.BlueBar.TabIndex = 8;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // ColorAdjustment
            // 
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "ColorAdjustment";
            this.Size = new System.Drawing.Size(264, 239);
            this.Load += new System.EventHandler(this.ColorAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar ResShift;
        private System.Windows.Forms.TrackBar GreenShift;
        private System.Windows.Forms.TrackBar BlueShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TrackBar BlueBar;
    }
}
