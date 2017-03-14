namespace Image_Processing_Studio_1._0
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBoxROI = new Emgu.CV.UI.ImageBox();
            this.imageBoxOutputROI = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxROI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOutputROI)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageBoxROI);
            this.splitContainer1.Panel2.Controls.Add(this.imageBoxOutputROI);
            this.splitContainer1.Size = new System.Drawing.Size(884, 519);
            this.splitContainer1.SplitterDistance = 601;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // imageBoxROI
            // 
            this.imageBoxROI.Location = new System.Drawing.Point(19, 190);
            this.imageBoxROI.Name = "imageBoxROI";
            this.imageBoxROI.Size = new System.Drawing.Size(248, 190);
            this.imageBoxROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxROI.TabIndex = 2;
            this.imageBoxROI.TabStop = false;
            // 
            // imageBoxOutputROI
            // 
            this.imageBoxOutputROI.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxOutputROI.Location = new System.Drawing.Point(19, 12);
            this.imageBoxOutputROI.Name = "imageBoxOutputROI";
            this.imageBoxOutputROI.Size = new System.Drawing.Size(248, 172);
            this.imageBoxOutputROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxOutputROI.TabIndex = 2;
            this.imageBoxOutputROI.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "CROP";
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxROI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOutputROI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Emgu.CV.UI.ImageBox imageBoxOutputROI;
        private Emgu.CV.UI.ImageBox imageBoxROI;
        private Emgu.CV.UI.ImageBox pictureBox1;
    }
}