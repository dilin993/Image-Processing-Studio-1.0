namespace Image_Processing_Studio_1._0
{
    partial class SaturationAdjustment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaturationLevel = new System.Windows.Forms.TrackBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.SaturationValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saturation Adjustment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saturation Level";
            // 
            // SaturationLevel
            // 
            this.SaturationLevel.Location = new System.Drawing.Point(20, 98);
            this.SaturationLevel.Maximum = 255;
            this.SaturationLevel.Minimum = -255;
            this.SaturationLevel.Name = "SaturationLevel";
            this.SaturationLevel.Size = new System.Drawing.Size(239, 45);
            this.SaturationLevel.TabIndex = 2;
            this.SaturationLevel.Scroll += new System.EventHandler(this.SaturationLevel_Scroll);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(160, 162);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SaturationValue
            // 
            this.SaturationValue.AutoSize = true;
            this.SaturationValue.Location = new System.Drawing.Point(125, 82);
            this.SaturationValue.Name = "SaturationValue";
            this.SaturationValue.Size = new System.Drawing.Size(33, 13);
            this.SaturationValue.TabIndex = 4;
            this.SaturationValue.Text = "value";
            // 
            // SaturationAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaturationValue);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.SaturationLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaturationAdjustment";
            this.Size = new System.Drawing.Size(285, 227);
            this.Load += new System.EventHandler(this.SaturationAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaturationLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SaturationLevel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label SaturationValue;
    }
}
