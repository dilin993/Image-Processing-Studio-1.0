namespace Image_Processing_Studio_1._0
{
    partial class NoiseRemovalControl
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
            this.btnApply = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TrackBar();
            this.lbAmountTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSigma = new System.Windows.Forms.Label();
            this.tbSigma = new System.Windows.Forms.TrackBar();
            this.lbSigmaTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSigma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(200, 204);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 40);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(230, 154);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(35, 13);
            this.lbAmount.TabIndex = 14;
            this.lbAmount.Text = "label2";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(69, 144);
            this.tbAmount.Maximum = 100;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(155, 45);
            this.tbAmount.TabIndex = 13;
            this.tbAmount.Scroll += new System.EventHandler(this.tbAmount_Scroll);
            // 
            // lbAmountTitle
            // 
            this.lbAmountTitle.AutoSize = true;
            this.lbAmountTitle.Location = new System.Drawing.Point(17, 154);
            this.lbAmountTitle.Name = "lbAmountTitle";
            this.lbAmountTitle.Size = new System.Drawing.Size(54, 13);
            this.lbAmountTitle.TabIndex = 12;
            this.lbAmountTitle.Text = "amount = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Noise Removal";
            // 
            // lbSigma
            // 
            this.lbSigma.AutoSize = true;
            this.lbSigma.Location = new System.Drawing.Point(230, 91);
            this.lbSigma.Name = "lbSigma";
            this.lbSigma.Size = new System.Drawing.Size(35, 13);
            this.lbSigma.TabIndex = 10;
            this.lbSigma.Text = "label2";
            this.lbSigma.Click += new System.EventHandler(this.lbSigma_Click);
            // 
            // tbSigma
            // 
            this.tbSigma.Location = new System.Drawing.Point(69, 81);
            this.tbSigma.Maximum = 100;
            this.tbSigma.Name = "tbSigma";
            this.tbSigma.Size = new System.Drawing.Size(155, 45);
            this.tbSigma.TabIndex = 9;
            this.tbSigma.Scroll += new System.EventHandler(this.tbSigma_Scroll);
            // 
            // lbSigmaTitle
            // 
            this.lbSigmaTitle.AutoSize = true;
            this.lbSigmaTitle.Location = new System.Drawing.Point(17, 91);
            this.lbSigmaTitle.Name = "lbSigmaTitle";
            this.lbSigmaTitle.Size = new System.Drawing.Size(47, 13);
            this.lbSigmaTitle.TabIndex = 8;
            this.lbSigmaTitle.Text = "radius = ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gaussian Filtering",
            "Median Filtering",
            "N1 means denoising"});
            this.comboBox1.Location = new System.Drawing.Point(20, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NoiseRemovalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbAmountTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSigma);
            this.Controls.Add(this.tbSigma);
            this.Controls.Add(this.lbSigmaTitle);
            this.Name = "NoiseRemovalControl";
            this.Size = new System.Drawing.Size(291, 260);
            this.Load += new System.EventHandler(this.NoiseRemovalControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TrackBar tbAmount;
        private System.Windows.Forms.Label lbAmountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSigma;
        private System.Windows.Forms.TrackBar tbSigma;
        private System.Windows.Forms.Label lbSigmaTitle;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
