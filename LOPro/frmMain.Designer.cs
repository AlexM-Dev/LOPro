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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnChaseRows = new System.Windows.Forms.Button();
            this.btnSolutions = new System.Windows.Forms.Button();
            this.btnToggleX = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpControls.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpControls.Controls.Add(this.btnGenerate);
            this.grpControls.Controls.Add(this.txtHeight);
            this.grpControls.Controls.Add(this.lblX);
            this.grpControls.Controls.Add(this.txtWidth);
            this.grpControls.Controls.Add(this.lblSize);
            this.grpControls.Controls.Add(this.btnChaseRows);
            this.grpControls.Controls.Add(this.btnSolutions);
            this.grpControls.Controls.Add(this.btnToggleX);
            this.grpControls.Location = new System.Drawing.Point(13, 11);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(501, 95);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnChaseRows
            // 
            this.btnChaseRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChaseRows.Enabled = false;
            this.btnChaseRows.Location = new System.Drawing.Point(193, 52);
            this.btnChaseRows.Name = "btnChaseRows";
            this.btnChaseRows.Size = new System.Drawing.Size(118, 23);
            this.btnChaseRows.TabIndex = 2;
            this.btnChaseRows.Text = "Chase the rows";
            this.btnChaseRows.UseVisualStyleBackColor = true;
            this.btnChaseRows.Click += new System.EventHandler(this.btnChaseRows_Click);
            // 
            // btnSolutions
            // 
            this.btnSolutions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolutions.Enabled = false;
            this.btnSolutions.Location = new System.Drawing.Point(317, 52);
            this.btnSolutions.Name = "btnSolutions";
            this.btnSolutions.Size = new System.Drawing.Size(118, 23);
            this.btnSolutions.TabIndex = 1;
            this.btnSolutions.Text = "Find a solution";
            this.btnSolutions.UseVisualStyleBackColor = true;
            this.btnSolutions.Click += new System.EventHandler(this.btnSolutions_Click);
            // 
            // btnToggleX
            // 
            this.btnToggleX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleX.Enabled = false;
            this.btnToggleX.Location = new System.Drawing.Point(69, 52);
            this.btnToggleX.Name = "btnToggleX";
            this.btnToggleX.Size = new System.Drawing.Size(118, 23);
            this.btnToggleX.TabIndex = 0;
            this.btnToggleX.Text = "Toggle one";
            this.btnToggleX.UseVisualStyleBackColor = true;
            this.btnToggleX.Click += new System.EventHandler(this.btnToggleX_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrid.Location = new System.Drawing.Point(13, 112);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(501, 219);
            this.grpGrid.TabIndex = 2;
            this.grpGrid.TabStop = false;
            this.grpGrid.Text = "Interactive Grid";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(66, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Location = new System.Drawing.Point(102, 22);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(63, 22);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "7";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(173, 25);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "x";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(193, 22);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(63, 22);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Text = "5";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(317, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(13, 337);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(501, 102);
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
            this.txtOutput.Size = new System.Drawing.Size(482, 74);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "This is the output box. Refer to this for solutions and information.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 451);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpGrid);
            this.Controls.Add(this.grpControls);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "LOPro - Lights Out Solution Finder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnToggleX;
        private System.Windows.Forms.Button btnSolutions;
        private System.Windows.Forms.Button btnChaseRows;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

