namespace IDADiff
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
            this.inputDiffLabel = new System.Windows.Forms.Label();
            this.diffTextBox = new System.Windows.Forms.TextBox();
            this.browseDiffButton = new System.Windows.Forms.Button();
            this.browseFileButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.patchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDiffLabel
            // 
            this.inputDiffLabel.AutoSize = true;
            this.inputDiffLabel.Location = new System.Drawing.Point(13, 13);
            this.inputDiffLabel.Name = "inputDiffLabel";
            this.inputDiffLabel.Size = new System.Drawing.Size(53, 13);
            this.inputDiffLabel.TabIndex = 0;
            this.inputDiffLabel.Text = "Input Diff:";
            // 
            // diffTextBox
            // 
            this.diffTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diffTextBox.Location = new System.Drawing.Point(80, 13);
            this.diffTextBox.Name = "diffTextBox";
            this.diffTextBox.Size = new System.Drawing.Size(257, 20);
            this.diffTextBox.TabIndex = 2;
            // 
            // browseDiffButton
            // 
            this.browseDiffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDiffButton.Location = new System.Drawing.Point(343, 10);
            this.browseDiffButton.Name = "browseDiffButton";
            this.browseDiffButton.Size = new System.Drawing.Size(75, 23);
            this.browseDiffButton.TabIndex = 3;
            this.browseDiffButton.Text = "Browse...";
            this.browseDiffButton.UseVisualStyleBackColor = true;
            this.browseDiffButton.Click += new System.EventHandler(this.browseDiffButton_Click);
            // 
            // browseFileButton
            // 
            this.browseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFileButton.Location = new System.Drawing.Point(343, 36);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(75, 23);
            this.browseFileButton.TabIndex = 6;
            this.browseFileButton.Text = "Browse...";
            this.browseFileButton.UseVisualStyleBackColor = true;
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(80, 39);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(257, 20);
            this.inputTextBox.TabIndex = 5;
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(13, 39);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(53, 13);
            this.inputFileLabel.TabIndex = 4;
            this.inputFileLabel.Text = "Input File:";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(16, 120);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(399, 159);
            this.logTextBox.TabIndex = 7;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputButton.Location = new System.Drawing.Point(343, 62);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(75, 23);
            this.browseOutputButton.TabIndex = 10;
            this.browseOutputButton.Text = "Browse...";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(80, 65);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(257, 20);
            this.outputTextBox.TabIndex = 9;
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(13, 65);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(61, 13);
            this.outputFileLabel.TabIndex = 8;
            this.outputFileLabel.Text = "Output File:";
            // 
            // patchButton
            // 
            this.patchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patchButton.Location = new System.Drawing.Point(178, 91);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 23);
            this.patchButton.TabIndex = 11;
            this.patchButton.Text = "Patch!";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 291);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.browseFileButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.browseDiffButton);
            this.Controls.Add(this.diffTextBox);
            this.Controls.Add(this.inputDiffLabel);
            this.Name = "MainForm";
            this.Text = "IdaDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputDiffLabel;
        private System.Windows.Forms.TextBox diffTextBox;
        private System.Windows.Forms.Button browseDiffButton;
        private System.Windows.Forms.Button browseFileButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Button patchButton;
    }
}

