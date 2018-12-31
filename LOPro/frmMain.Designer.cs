namespace LOPro {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpGeneration = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuInteraction = new System.Windows.Forms.MenuItem();
            this.mnuClickMode = new System.Windows.Forms.MenuItem();
            this.sepRnd = new System.Windows.Forms.MenuItem();
            this.mnuRandomGrid = new System.Windows.Forms.MenuItem();
            this.sepFill = new System.Windows.Forms.MenuItem();
            this.mnuFillGrid = new System.Windows.Forms.MenuItem();
            this.mnuClearGrid = new System.Windows.Forms.MenuItem();
            this.mnuChase = new System.Windows.Forms.MenuItem();
            this.mnuChaseOne = new System.Windows.Forms.MenuItem();
            this.mnuChaseAll = new System.Windows.Forms.MenuItem();
            this.mnuSolve = new System.Windows.Forms.MenuItem();
            this.mnuSolveText = new System.Windows.Forms.MenuItem();
            this.mnuSolveSteps = new System.Windows.Forms.MenuItem();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.btnCloseSteps = new System.Windows.Forms.Button();
            this.grpGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.grpOutput.SuspendLayout();
            this.grpSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneration
            // 
            this.grpGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneration.Controls.Add(this.nudHeight);
            this.grpGeneration.Controls.Add(this.nudWidth);
            this.grpGeneration.Controls.Add(this.btnGenerate);
            this.grpGeneration.Location = new System.Drawing.Point(13, 11);
            this.grpGeneration.Name = "grpGeneration";
            this.grpGeneration.Size = new System.Drawing.Size(403, 78);
            this.grpGeneration.TabIndex = 1;
            this.grpGeneration.TabStop = false;
            this.grpGeneration.Text = "Grid Generation";
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHeight.Location = new System.Drawing.Point(204, 21);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(73, 22);
            this.nudHeight.TabIndex = 9;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudWidth
            // 
            this.nudWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudWidth.Location = new System.Drawing.Point(125, 21);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(73, 22);
            this.nudWidth.TabIndex = 8;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWidth.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(125, 44);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrid.Location = new System.Drawing.Point(13, 95);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(403, 236);
            this.grpGrid.TabIndex = 2;
            this.grpGrid.TabStop = false;
            this.grpGrid.Text = "Interactive Grid";
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(13, 337);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(403, 102);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Location = new System.Drawing.Point(9, 17);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(384, 74);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "This is the output box. Refer to this for solutions and information.";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuInteraction,
            this.mnuChase,
            this.mnuSolve});
            // 
            // mnuInteraction
            // 
            this.mnuInteraction.Enabled = false;
            this.mnuInteraction.Index = 0;
            this.mnuInteraction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuClickMode,
            this.sepRnd,
            this.mnuRandomGrid,
            this.sepFill,
            this.mnuFillGrid,
            this.mnuClearGrid});
            this.mnuInteraction.Text = "Interaction";
            // 
            // mnuClickMode
            // 
            this.mnuClickMode.Index = 0;
            this.mnuClickMode.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuClickMode.Text = "Click mode: one";
            this.mnuClickMode.Click += new System.EventHandler(this.mnuClickMode_Click);
            // 
            // sepRnd
            // 
            this.sepRnd.Index = 1;
            this.sepRnd.Text = "-";
            // 
            // mnuRandomGrid
            // 
            this.mnuRandomGrid.Index = 2;
            this.mnuRandomGrid.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuRandomGrid.Text = "Random grid";
            this.mnuRandomGrid.Click += new System.EventHandler(this.mnuRandomGrid_Click);
            // 
            // sepFill
            // 
            this.sepFill.Index = 3;
            this.sepFill.Text = "-";
            // 
            // mnuFillGrid
            // 
            this.mnuFillGrid.Index = 4;
            this.mnuFillGrid.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.mnuFillGrid.Text = "Fill grid";
            // 
            // mnuClearGrid
            // 
            this.mnuClearGrid.Index = 5;
            this.mnuClearGrid.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuClearGrid.Text = "Clear grid";
            // 
            // mnuChase
            // 
            this.mnuChase.Enabled = false;
            this.mnuChase.Index = 1;
            this.mnuChase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuChaseOne,
            this.mnuChaseAll});
            this.mnuChase.Text = "Chasing";
            // 
            // mnuChaseOne
            // 
            this.mnuChaseOne.Index = 0;
            this.mnuChaseOne.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
            this.mnuChaseOne.Text = "Chase one row";
            // 
            // mnuChaseAll
            // 
            this.mnuChaseAll.Index = 1;
            this.mnuChaseAll.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.mnuChaseAll.Text = "Chase all rows";
            this.mnuChaseAll.Click += new System.EventHandler(this.mnuChaseAll_Click);
            // 
            // mnuSolve
            // 
            this.mnuSolve.Enabled = false;
            this.mnuSolve.Index = 2;
            this.mnuSolve.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSolveText,
            this.mnuSolveSteps});
            this.mnuSolve.Text = "Solving";
            // 
            // mnuSolveText
            // 
            this.mnuSolveText.Index = 0;
            this.mnuSolveText.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSolveText.Text = "Text solve";
            this.mnuSolveText.Click += new System.EventHandler(this.mnuSolveText_Click);
            // 
            // mnuSolveSteps
            // 
            this.mnuSolveSteps.Index = 1;
            this.mnuSolveSteps.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mnuSolveSteps.Text = "Show steps";
            this.mnuSolveSteps.Click += new System.EventHandler(this.mnuSolveSteps_Click);
            // 
            // grpSteps
            // 
            this.grpSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSteps.Controls.Add(this.btnCloseSteps);
            this.grpSteps.Location = new System.Drawing.Point(13, 95);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Size = new System.Drawing.Size(403, 236);
            this.grpSteps.TabIndex = 3;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Solution - What to click (steps)";
            this.grpSteps.Visible = false;
            // 
            // btnCloseSteps
            // 
            this.btnCloseSteps.Location = new System.Drawing.Point(299, 17);
            this.btnCloseSteps.Name = "btnCloseSteps";
            this.btnCloseSteps.Size = new System.Drawing.Size(94, 23);
            this.btnCloseSteps.TabIndex = 0;
            this.btnCloseSteps.Text = "Close Steps (X)";
            this.btnCloseSteps.UseVisualStyleBackColor = true;
            this.btnCloseSteps.Click += new System.EventHandler(this.btnCloseSteps_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 451);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpGeneration);
            this.Controls.Add(this.grpSteps);
            this.Controls.Add(this.grpGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "LOPro - Lights Out Solution Finder";
            this.grpGeneration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpGeneration;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuInteraction;
        private System.Windows.Forms.MenuItem mnuChase;
        private System.Windows.Forms.MenuItem mnuSolve;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.MenuItem mnuSolveText;
        private System.Windows.Forms.MenuItem mnuSolveSteps;
        private System.Windows.Forms.MenuItem mnuClickMode;
        private System.Windows.Forms.MenuItem sepRnd;
        private System.Windows.Forms.MenuItem mnuRandomGrid;
        private System.Windows.Forms.MenuItem sepFill;
        private System.Windows.Forms.MenuItem mnuFillGrid;
        private System.Windows.Forms.MenuItem mnuClearGrid;
        private System.Windows.Forms.MenuItem mnuChaseOne;
        private System.Windows.Forms.MenuItem mnuChaseAll;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.Button btnCloseSteps;
    }
}

