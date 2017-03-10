namespace Image_Processing_Studio_1._0
{
    partial class SharpeningControl
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
            this.tbSigma = new System.Windows.Forms.TrackBar();
            this.lbSigma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "radius = ";
            // 
            // tbSigma
            // 
            this.tbSigma.Location = new System.Drawing.Point(72, 62);
            this.tbSigma.Maximum = 100;
            this.tbSigma.Name = "tbSigma";
            this.tbSigma.Size = new System.Drawing.Size(155, 45);
            this.tbSigma.TabIndex = 1;
            this.tbSigma.Scroll += new System.EventHandler(this.tbSigma_Scroll);
            // 
            // lbSigma
            // 
            this.lbSigma.AutoSize = true;
            this.lbSigma.Location = new System.Drawing.Point(233, 72);
            this.lbSigma.Name = "lbSigma";
            this.lbSigma.Size = new System.Drawing.Size(35, 13);
            this.lbSigma.TabIndex = 2;
            this.lbSigma.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sharpening";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(233, 135);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(35, 13);
            this.lbAmount.TabIndex = 6;
            this.lbAmount.Text = "label2";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(72, 125);
            this.tbAmount.Maximum = 100;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(155, 45);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.Scroll += new System.EventHandler(this.tbAmount_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "amount = ";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(205, 176);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 40);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(124, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SharpeningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSigma);
            this.Controls.Add(this.tbSigma);
            this.Controls.Add(this.label1);
            this.Name = "SharpeningControl";
            this.Size = new System.Drawing.Size(291, 226);
            this.Load += new System.EventHandler(this.SharpeningControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSigma;
        private System.Windows.Forms.Label lbSigma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TrackBar tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReset;
    }
}
