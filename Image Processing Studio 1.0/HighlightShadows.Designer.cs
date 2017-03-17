namespace Image_Processing_Studio_1._0
{
    partial class HightlightShadows
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
            this.Gamma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.HighlightBar = new System.Windows.Forms.TrackBar();
            this.ShadowBar = new System.Windows.Forms.TrackBar();
            this.GammaVal = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.HighlightVal = new System.Windows.Forms.Label();
            this.ShadowVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighlightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highlights and Shadows";
            // 
            // Gamma
            // 
            this.Gamma.AutoSize = true;
            this.Gamma.Location = new System.Drawing.Point(3, 50);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(43, 13);
            this.Gamma.TabIndex = 1;
            this.Gamma.Text = "Gamma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Highlights";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shadows";
            // 
            // GammaBar
            // 
            this.GammaBar.LargeChange = 1;
            this.GammaBar.Location = new System.Drawing.Point(17, 66);
            this.GammaBar.Maximum = 100;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(242, 45);
            this.GammaBar.TabIndex = 4;
            this.GammaBar.Value = 50;
            this.GammaBar.Scroll += new System.EventHandler(this.GammaBar_Scroll);
            // 
            // HighlightBar
            // 
            this.HighlightBar.Location = new System.Drawing.Point(17, 117);
            this.HighlightBar.Maximum = 100;
            this.HighlightBar.Name = "HighlightBar";
            this.HighlightBar.Size = new System.Drawing.Size(242, 45);
            this.HighlightBar.TabIndex = 5;
            this.HighlightBar.Value = 50;
            this.HighlightBar.Scroll += new System.EventHandler(this.HighlightBar_Scroll);
            // 
            // ShadowBar
            // 
            this.ShadowBar.Location = new System.Drawing.Point(17, 168);
            this.ShadowBar.Name = "ShadowBar";
            this.ShadowBar.Size = new System.Drawing.Size(242, 45);
            this.ShadowBar.TabIndex = 6;
            this.ShadowBar.Value = 5;
            this.ShadowBar.Scroll += new System.EventHandler(this.ShadowBar_Scroll);
            // 
            // GammaVal
            // 
            this.GammaVal.AutoSize = true;
            this.GammaVal.Location = new System.Drawing.Point(112, 50);
            this.GammaVal.Name = "GammaVal";
            this.GammaVal.Size = new System.Drawing.Size(33, 13);
            this.GammaVal.TabIndex = 7;
            this.GammaVal.Text = "value";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(186, 16);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // HighlightVal
            // 
            this.HighlightVal.AutoSize = true;
            this.HighlightVal.Location = new System.Drawing.Point(112, 98);
            this.HighlightVal.Name = "HighlightVal";
            this.HighlightVal.Size = new System.Drawing.Size(33, 13);
            this.HighlightVal.TabIndex = 9;
            this.HighlightVal.Text = "value";
            // 
            // ShadowVal
            // 
            this.ShadowVal.AutoSize = true;
            this.ShadowVal.Location = new System.Drawing.Point(112, 149);
            this.ShadowVal.Name = "ShadowVal";
            this.ShadowVal.Size = new System.Drawing.Size(33, 13);
            this.ShadowVal.TabIndex = 10;
            this.ShadowVal.Text = "value";
            // 
            // HightlightShadows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShadowVal);
            this.Controls.Add(this.HighlightVal);
            this.Controls.Add(this.GammaVal);
            this.Controls.Add(this.ShadowBar);
            this.Controls.Add(this.HighlightBar);
            this.Controls.Add(this.GammaBar);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.label1);
            this.Name = "HightlightShadows";
            this.Size = new System.Drawing.Size(264, 214);
            this.Load += new System.EventHandler(this.HightlightShadows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighlightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Gamma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.TrackBar HighlightBar;
        private System.Windows.Forms.TrackBar ShadowBar;
        private System.Windows.Forms.Label GammaVal;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label HighlightVal;
        private System.Windows.Forms.Label ShadowVal;
    }
}
