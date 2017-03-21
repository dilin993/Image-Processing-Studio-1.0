namespace Image_Processing_Studio_1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.operationTab = new System.Windows.Forms.SplitContainer();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnDenoise = new System.Windows.Forms.Button();
            this.EXIF = new System.Windows.Forms.Button();
            this.btnSaturation = new System.Windows.Forms.Button();
            this.btnColorAdjust = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnVignette = new System.Windows.Forms.Button();
            this.btnColorTemp = new System.Windows.Forms.Button();
            this.btnCorrection = new System.Windows.Forms.Button();
            this.btnExposure = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationTab)).BeginInit();
            this.operationTab.Panel1.SuspendLayout();
            this.operationTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 538);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.operationTab);
            this.splitContainer2.Size = new System.Drawing.Size(1033, 457);
            this.splitContainer2.SplitterDistance = 723;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer3.Size = new System.Drawing.Size(721, 455);
            this.splitContainer3.SplitterDistance = 404;
            this.splitContainer3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnPrev);
            this.flowLayoutPanel2.Controls.Add(this.btnNext);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(371, 47);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 40);
            this.btnPrev.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPrev, "Previous");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(49, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnInfo);
            this.flowLayoutPanel3.Controls.Add(this.btnUndo);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(521, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 47);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(111, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUndo.Size = new System.Drawing.Size(40, 40);
            this.btnUndo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnUndo, "Undo");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // operationTab
            // 
            this.operationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationTab.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.operationTab.IsSplitterFixed = true;
            this.operationTab.Location = new System.Drawing.Point(0, 0);
            this.operationTab.Name = "operationTab";
            this.operationTab.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // operationTab.Panel1
            // 
            this.operationTab.Panel1.Controls.Add(this.zedGraphControl1);
            // 
            // operationTab.Panel2
            // 
            this.operationTab.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationTab.Size = new System.Drawing.Size(304, 455);
            this.operationTab.SplitterDistance = 195;
            this.operationTab.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(302, 190);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOpen);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnSharpen);
            this.flowLayoutPanel1.Controls.Add(this.btnDenoise);
            this.flowLayoutPanel1.Controls.Add(this.EXIF);
            this.flowLayoutPanel1.Controls.Add(this.btnSaturation);
            this.flowLayoutPanel1.Controls.Add(this.btnColorAdjust);
            this.flowLayoutPanel1.Controls.Add(this.btnCrop);
            this.flowLayoutPanel1.Controls.Add(this.btnVignette);
            this.flowLayoutPanel1.Controls.Add(this.btnColorTemp);
            this.flowLayoutPanel1.Controls.Add(this.btnCorrection);
            this.flowLayoutPanel1.Controls.Add(this.btnExposure);
            this.flowLayoutPanel1.Controls.Add(this.btnContrast);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 75);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.Location = new System.Drawing.Point(3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(70, 70);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Import";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(79, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Export";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSharpen
            // 
            this.btnSharpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSharpen.Image = ((System.Drawing.Image)(resources.GetObject("btnSharpen.Image")));
            this.btnSharpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSharpen.Location = new System.Drawing.Point(155, 3);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(70, 70);
            this.btnSharpen.TabIndex = 2;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnDenoise
            // 
            this.btnDenoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenoise.Image = ((System.Drawing.Image)(resources.GetObject("btnDenoise.Image")));
            this.btnDenoise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDenoise.Location = new System.Drawing.Point(231, 3);
            this.btnDenoise.Name = "btnDenoise";
            this.btnDenoise.Size = new System.Drawing.Size(70, 70);
            this.btnDenoise.TabIndex = 3;
            this.btnDenoise.Text = "Denoise";
            this.btnDenoise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDenoise.UseVisualStyleBackColor = true;
            this.btnDenoise.Click += new System.EventHandler(this.btnDenoise_Click);
            // 
            // EXIF
            // 
            this.EXIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIF.Image = ((System.Drawing.Image)(resources.GetObject("EXIF.Image")));
            this.EXIF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EXIF.Location = new System.Drawing.Point(307, 3);
            this.EXIF.Name = "EXIF";
            this.EXIF.Size = new System.Drawing.Size(77, 69);
            this.EXIF.TabIndex = 4;
            this.EXIF.Text = "EXIF";
            this.EXIF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EXIF.UseVisualStyleBackColor = true;
            this.EXIF.Click += new System.EventHandler(this.EXIF_Click);
            // 
            // btnSaturation
            // 
            this.btnSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturation.Image = ((System.Drawing.Image)(resources.GetObject("btnSaturation.Image")));
            this.btnSaturation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaturation.Location = new System.Drawing.Point(390, 3);
            this.btnSaturation.Name = "btnSaturation";
            this.btnSaturation.Size = new System.Drawing.Size(77, 69);
            this.btnSaturation.TabIndex = 5;
            this.btnSaturation.Text = "Saturation";
            this.btnSaturation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaturation.UseVisualStyleBackColor = true;
            this.btnSaturation.Click += new System.EventHandler(this.btnSaturation_Click);
            // 
            // btnColorAdjust
            // 
            this.btnColorAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorAdjust.Image = ((System.Drawing.Image)(resources.GetObject("btnColorAdjust.Image")));
            this.btnColorAdjust.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColorAdjust.Location = new System.Drawing.Point(473, 3);
            this.btnColorAdjust.Name = "btnColorAdjust";
            this.btnColorAdjust.Size = new System.Drawing.Size(75, 69);
            this.btnColorAdjust.TabIndex = 6;
            this.btnColorAdjust.Text = "Color";
            this.btnColorAdjust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColorAdjust.UseVisualStyleBackColor = true;
            this.btnColorAdjust.Click += new System.EventHandler(this.btnColorAdjust_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrop.Image = ((System.Drawing.Image)(resources.GetObject("btnCrop.Image")));
            this.btnCrop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrop.Location = new System.Drawing.Point(554, 3);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(70, 70);
            this.btnCrop.TabIndex = 4;
            this.btnCrop.Text = "Crop";
            this.btnCrop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnVignette
            // 
            this.btnVignette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVignette.Image = ((System.Drawing.Image)(resources.GetObject("btnVignette.Image")));
            this.btnVignette.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVignette.Location = new System.Drawing.Point(630, 3);
            this.btnVignette.Name = "btnVignette";
            this.btnVignette.Size = new System.Drawing.Size(72, 69);
            this.btnVignette.TabIndex = 7;
            this.btnVignette.Text = "Vignette";
            this.btnVignette.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVignette.UseVisualStyleBackColor = true;
            this.btnVignette.Click += new System.EventHandler(this.VignetteButton_Click);
            // 
            // btnColorTemp
            // 
            this.btnColorTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnColorTemp.Image")));
            this.btnColorTemp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColorTemp.Location = new System.Drawing.Point(708, 3);
            this.btnColorTemp.Name = "btnColorTemp";
            this.btnColorTemp.Size = new System.Drawing.Size(70, 69);
            this.btnColorTemp.TabIndex = 8;
            this.btnColorTemp.Text = "Temp";
            this.btnColorTemp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColorTemp.UseVisualStyleBackColor = true;
            this.btnColorTemp.Click += new System.EventHandler(this.btnColorTemp_Click);
            // 
            // btnCorrection
            // 
            this.btnCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrection.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrection.Image")));
            this.btnCorrection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorrection.Location = new System.Drawing.Point(784, 3);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(75, 69);
            this.btnCorrection.TabIndex = 9;
            this.btnCorrection.Text = "Hightlights\r\nShadows";
            this.btnCorrection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorrection.UseVisualStyleBackColor = true;
            this.btnCorrection.Click += new System.EventHandler(this.btnCorrection_Click);
            // 
            // btnExposure
            // 
            this.btnExposure.AccessibleName = "btnExposure";
            this.btnExposure.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExposure.Image = ((System.Drawing.Image)(resources.GetObject("btnExposure.Image")));
            this.btnExposure.Location = new System.Drawing.Point(865, 3);
            this.btnExposure.Name = "btnExposure";
            this.btnExposure.Size = new System.Drawing.Size(75, 69);
            this.btnExposure.TabIndex = 9;
            this.btnExposure.Text = "Exposure";
            this.btnExposure.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExposure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExposure.UseVisualStyleBackColor = false;
            this.btnExposure.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrast.Image = ((System.Drawing.Image)(resources.GetObject("btnContrast.Image")));
            this.btnContrast.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContrast.Location = new System.Drawing.Point(946, 3);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(71, 68);
            this.btnContrast.TabIndex = 10;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Import image(s)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Export Image";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(157, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnInfo, "Undo");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 538);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1049, 577);
            this.Name = "Form1";
            this.Text = "Image Processing Studio 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.form1_resized);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.operationTab.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationTab)).EndInit();
            this.operationTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer operationTab;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnDenoise;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button EXIF;
        private System.Windows.Forms.Button btnSaturation;
        private System.Windows.Forms.Button btnColorAdjust;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnVignette;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnColorTemp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCorrection;
        private System.Windows.Forms.Button btnExposure;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnInfo;
    }
}

