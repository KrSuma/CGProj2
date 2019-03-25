namespace SimplePaletteQuantizer
{
    partial class MainForm
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
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitterMain = new System.Windows.Forms.Splitter();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureSource = new System.Windows.Forms.PictureBox();
            this.panelDirectory = new System.Windows.Forms.Panel();
            this.panelFilename = new System.Windows.Forms.Panel();
            this.panelSourceInfo = new System.Windows.Forms.Panel();
            this.editSourceInfo = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureTarget = new System.Windows.Forms.PictureBox();
            this.panelDithering = new System.Windows.Forms.Panel();
            this.listDitherer = new System.Windows.Forms.ComboBox();
            this.labelParallelTasks = new System.Windows.Forms.Label();
            this.listParallel = new System.Windows.Forms.ComboBox();
            this.labelDitherer = new System.Windows.Forms.Label();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.listMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listColors = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.panelTargetInfo = new System.Windows.Forms.Panel();
            this.editTargetInfo = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).BeginInit();
            this.panelSourceInfo.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarget)).BeginInit();
            this.panelDithering.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.panelTargetInfo.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.Filter = "Supported images|*.png;*.jpg;*.gif;*.jpeg;*.bmp;*.tiff";
            // 
            // panelStatistics
            // 
            this.panelStatistics.AutoSize = true;
            this.panelStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatistics.Location = new System.Drawing.Point(5, 520);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(674, 0);
            this.panelStatistics.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitterMain);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(5, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelMain.Size = new System.Drawing.Size(674, 515);
            this.panelMain.TabIndex = 5;
            // 
            // splitterMain
            // 
            this.splitterMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitterMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterMain.Location = new System.Drawing.Point(332, 0);
            this.splitterMain.Name = "splitterMain";
            this.splitterMain.Size = new System.Drawing.Size(5, 510);
            this.splitterMain.TabIndex = 2;
            this.splitterMain.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureSource);
            this.panelLeft.Controls.Add(this.panelDirectory);
            this.panelLeft.Controls.Add(this.panelFilename);
            this.panelLeft.Controls.Add(this.panelSourceInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(337, 510);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureSource
            // 
            this.pictureSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureSource.Location = new System.Drawing.Point(0, 75);
            this.pictureSource.Name = "pictureSource";
            this.pictureSource.Size = new System.Drawing.Size(337, 435);
            this.pictureSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSource.TabIndex = 13;
            this.pictureSource.TabStop = false;
            // 
            // panelDirectory
            // 
            this.panelDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectory.Location = new System.Drawing.Point(0, 50);
            this.panelDirectory.Name = "panelDirectory";
            this.panelDirectory.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.panelDirectory.Size = new System.Drawing.Size(337, 25);
            this.panelDirectory.TabIndex = 14;
            // 
            // panelFilename
            // 
            this.panelFilename.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilename.Location = new System.Drawing.Point(0, 25);
            this.panelFilename.Name = "panelFilename";
            this.panelFilename.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.panelFilename.Size = new System.Drawing.Size(337, 25);
            this.panelFilename.TabIndex = 10;
            // 
            // panelSourceInfo
            // 
            this.panelSourceInfo.Controls.Add(this.editSourceInfo);
            this.panelSourceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourceInfo.Location = new System.Drawing.Point(0, 0);
            this.panelSourceInfo.Name = "panelSourceInfo";
            this.panelSourceInfo.Padding = new System.Windows.Forms.Padding(0, 0, 8, 5);
            this.panelSourceInfo.Size = new System.Drawing.Size(337, 25);
            this.panelSourceInfo.TabIndex = 7;
            // 
            // editSourceInfo
            // 
            this.editSourceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSourceInfo.Location = new System.Drawing.Point(0, 0);
            this.editSourceInfo.Name = "editSourceInfo";
            this.editSourceInfo.ReadOnly = true;
            this.editSourceInfo.Size = new System.Drawing.Size(329, 20);
            this.editSourceInfo.TabIndex = 8;
            this.editSourceInfo.TabStop = false;
            this.editSourceInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.pictureTarget);
            this.panelRight.Controls.Add(this.panelDithering);
            this.panelRight.Controls.Add(this.panelMethod);
            this.panelRight.Controls.Add(this.panelTargetInfo);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(337, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(337, 510);
            this.panelRight.TabIndex = 1;
            // 
            // pictureTarget
            // 
            this.pictureTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureTarget.Location = new System.Drawing.Point(0, 75);
            this.pictureTarget.Name = "pictureTarget";
            this.pictureTarget.Size = new System.Drawing.Size(337, 435);
            this.pictureTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTarget.TabIndex = 12;
            this.pictureTarget.TabStop = false;
            // 
            // panelDithering
            // 
            this.panelDithering.Controls.Add(this.listDitherer);
            this.panelDithering.Controls.Add(this.labelParallelTasks);
            this.panelDithering.Controls.Add(this.listParallel);
            this.panelDithering.Controls.Add(this.labelDitherer);
            this.panelDithering.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDithering.Location = new System.Drawing.Point(0, 50);
            this.panelDithering.Name = "panelDithering";
            this.panelDithering.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelDithering.Size = new System.Drawing.Size(337, 25);
            this.panelDithering.TabIndex = 13;
            // 
            // listDitherer
            // 
            this.listDitherer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDitherer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDitherer.FormattingEnabled = true;
            this.listDitherer.Items.AddRange(new object[] {
            "No Dithering",
            "Average Dithering"});
            this.listDitherer.Location = new System.Drawing.Point(52, 0);
            this.listDitherer.Name = "listDitherer";
            this.listDitherer.Size = new System.Drawing.Size(194, 21);
            this.listDitherer.TabIndex = 6;
            this.listDitherer.SelectedIndexChanged += new System.EventHandler(this.ListDithererSelectedIndexChanged);
            // 
            // labelParallelTasks
            // 
            this.labelParallelTasks.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelParallelTasks.Location = new System.Drawing.Point(246, 0);
            this.labelParallelTasks.Name = "labelParallelTasks";
            this.labelParallelTasks.Size = new System.Drawing.Size(41, 20);
            this.labelParallelTasks.TabIndex = 5;
            this.labelParallelTasks.Text = "Grey";
            this.labelParallelTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listParallel
            // 
            this.listParallel.Dock = System.Windows.Forms.DockStyle.Right;
            this.listParallel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listParallel.FormattingEnabled = true;
            this.listParallel.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16"});
            this.listParallel.Location = new System.Drawing.Point(287, 0);
            this.listParallel.MinimumSize = new System.Drawing.Size(45, 0);
            this.listParallel.Name = "listParallel";
            this.listParallel.Size = new System.Drawing.Size(45, 21);
            this.listParallel.TabIndex = 7;
            this.listParallel.SelectedIndexChanged += new System.EventHandler(this.ListParallelSelectedIndexChanged);
            // 
            // labelDitherer
            // 
            this.labelDitherer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDitherer.Location = new System.Drawing.Point(5, 0);
            this.labelDitherer.Name = "labelDitherer";
            this.labelDitherer.Size = new System.Drawing.Size(47, 20);
            this.labelDitherer.TabIndex = 0;
            this.labelDitherer.Text = "Ditherer:";
            this.labelDitherer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMethod
            // 
            this.panelMethod.Controls.Add(this.listMethod);
            this.panelMethod.Controls.Add(this.label1);
            this.panelMethod.Controls.Add(this.listColors);
            this.panelMethod.Controls.Add(this.labelMethod);
            this.panelMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod.Location = new System.Drawing.Point(0, 25);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelMethod.Size = new System.Drawing.Size(337, 25);
            this.panelMethod.TabIndex = 10;
            // 
            // listMethod
            // 
            this.listMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMethod.FormattingEnabled = true;
            this.listMethod.Items.AddRange(new object[] {
            "Median cut algorithm"});
            this.listMethod.Location = new System.Drawing.Point(52, 0);
            this.listMethod.Name = "listMethod";
            this.listMethod.Size = new System.Drawing.Size(193, 21);
            this.listMethod.TabIndex = 2;
            this.listMethod.SelectedIndexChanged += new System.EventHandler(this.ListMethodSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = " Colors:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listColors
            // 
            this.listColors.Dock = System.Windows.Forms.DockStyle.Right;
            this.listColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listColors.FormattingEnabled = true;
            this.listColors.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.listColors.Location = new System.Drawing.Point(287, 0);
            this.listColors.MinimumSize = new System.Drawing.Size(45, 0);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(45, 21);
            this.listColors.TabIndex = 3;
            this.listColors.SelectedIndexChanged += new System.EventHandler(this.ListColorsSelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMethod.Location = new System.Drawing.Point(5, 0);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(47, 20);
            this.labelMethod.TabIndex = 8;
            this.labelMethod.Text = "Method:";
            this.labelMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTargetInfo
            // 
            this.panelTargetInfo.Controls.Add(this.editTargetInfo);
            this.panelTargetInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTargetInfo.Location = new System.Drawing.Point(0, 0);
            this.panelTargetInfo.Name = "panelTargetInfo";
            this.panelTargetInfo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 5);
            this.panelTargetInfo.Size = new System.Drawing.Size(337, 25);
            this.panelTargetInfo.TabIndex = 6;
            // 
            // editTargetInfo
            // 
            this.editTargetInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.editTargetInfo.Location = new System.Drawing.Point(4, 0);
            this.editTargetInfo.Name = "editTargetInfo";
            this.editTargetInfo.ReadOnly = true;
            this.editTargetInfo.Size = new System.Drawing.Size(333, 20);
            this.editTargetInfo.TabIndex = 4;
            this.editTargetInfo.TabStop = false;
            this.editTargetInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonUpdate);
            this.panelControls.Controls.Add(this.buttonBrowse);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(5, 520);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(674, 39);
            this.panelControls.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(534, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 32);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Refresh";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(531, 32);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Load";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.panelControls);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGProj2";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).EndInit();
            this.panelSourceInfo.ResumeLayout(false);
            this.panelSourceInfo.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarget)).EndInit();
            this.panelDithering.ResumeLayout(false);
            this.panelMethod.ResumeLayout(false);
            this.panelTargetInfo.ResumeLayout(false);
            this.panelTargetInfo.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.Panel panelStatistics;
        //private System.Windows.Forms.SplitContainer splitContainerPngSizes;
        //private System.Windows.Forms.SplitContainer splitContainerGifSizes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Splitter splitterMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelSourceInfo;
        private System.Windows.Forms.Panel panelTargetInfo;
        private System.Windows.Forms.TextBox editTargetInfo;
        private System.Windows.Forms.TextBox editSourceInfo;
        private System.Windows.Forms.Panel panelMethod;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox listMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listColors;
        private System.Windows.Forms.Panel panelFilename;
        private System.Windows.Forms.PictureBox pictureTarget;
        private System.Windows.Forms.PictureBox pictureSource;
        private System.Windows.Forms.Panel panelDirectory;
        private System.Windows.Forms.Panel panelDithering;
        private System.Windows.Forms.ComboBox listDitherer;
        private System.Windows.Forms.Label labelParallelTasks;
        private System.Windows.Forms.ComboBox listParallel;
        private System.Windows.Forms.Label labelDitherer;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBrowse;
    }
}

