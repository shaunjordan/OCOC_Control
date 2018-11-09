namespace OneCustomer_UI
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
            this.components = new System.ComponentModel.Container();
            this.thresholdValue = new System.Windows.Forms.TrackBar();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.rowStartLabel = new System.Windows.Forms.Label();
            this.rowStartInput = new System.Windows.Forms.TextBox();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.selectSavePathLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.columnStartLabel = new System.Windows.Forms.Label();
            this.columnStartInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).BeginInit();
            this.configGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // thresholdValue
            // 
            this.thresholdValue.Location = new System.Drawing.Point(37, 91);
            this.thresholdValue.Maximum = 100;
            this.thresholdValue.Minimum = 50;
            this.thresholdValue.Name = "thresholdValue";
            this.thresholdValue.Size = new System.Drawing.Size(312, 90);
            this.thresholdValue.TabIndex = 0;
            this.thresholdValue.Value = 50;
            this.thresholdValue.Scroll += new System.EventHandler(this.thresholdValue_Scroll);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(46, 63);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(240, 25);
            this.thresholdLabel.TabIndex = 1;
            this.thresholdLabel.Text = "Set Matching Threshold";
            // 
            // configGroup
            // 
            this.configGroup.Controls.Add(this.columnStartInput);
            this.configGroup.Controls.Add(this.columnStartLabel);
            this.configGroup.Controls.Add(this.rowStartInput);
            this.configGroup.Controls.Add(this.rowStartLabel);
            this.configGroup.Controls.Add(this.thresholdLabel);
            this.configGroup.Controls.Add(this.thresholdValue);
            this.configGroup.Location = new System.Drawing.Point(22, 140);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(480, 281);
            this.configGroup.TabIndex = 3;
            this.configGroup.TabStop = false;
            this.configGroup.Text = "Configuration";
            // 
            // rowStartLabel
            // 
            this.rowStartLabel.AutoSize = true;
            this.rowStartLabel.Location = new System.Drawing.Point(46, 184);
            this.rowStartLabel.Name = "rowStartLabel";
            this.rowStartLabel.Size = new System.Drawing.Size(123, 25);
            this.rowStartLabel.TabIndex = 2;
            this.rowStartLabel.Text = "Row Start #";
            // 
            // rowStartInput
            // 
            this.rowStartInput.Location = new System.Drawing.Point(51, 222);
            this.rowStartInput.Name = "rowStartInput";
            this.rowStartInput.Size = new System.Drawing.Size(100, 31);
            this.rowStartInput.TabIndex = 3;
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Location = new System.Drawing.Point(17, 476);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(145, 25);
            this.selectFileLabel.TabIndex = 4;
            this.selectFileLabel.Text = "File to review:";
            // 
            // selectSavePathLabel
            // 
            this.selectSavePathLabel.AutoSize = true;
            this.selectSavePathLabel.Location = new System.Drawing.Point(246, 476);
            this.selectSavePathLabel.Name = "selectSavePathLabel";
            this.selectSavePathLabel.Size = new System.Drawing.Size(125, 25);
            this.selectSavePathLabel.TabIndex = 5;
            this.selectSavePathLabel.Text = "Save file to:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(282, 625);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 41);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(402, 625);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 41);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Quit";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // columnStartLabel
            // 
            this.columnStartLabel.AutoSize = true;
            this.columnStartLabel.Location = new System.Drawing.Point(239, 184);
            this.columnStartLabel.Name = "columnStartLabel";
            this.columnStartLabel.Size = new System.Drawing.Size(154, 25);
            this.columnStartLabel.TabIndex = 4;
            this.columnStartLabel.Text = "Column Start #";
            // 
            // columnStartInput
            // 
            this.columnStartInput.Location = new System.Drawing.Point(244, 222);
            this.columnStartInput.Name = "columnStartInput";
            this.columnStartInput.Size = new System.Drawing.Size(100, 31);
            this.columnStartInput.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectSavePathLabel);
            this.Controls.Add(this.selectFileLabel);
            this.Controls.Add(this.configGroup);
            this.Name = "MainForm";
            this.Text = "OCOC Control";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).EndInit();
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar thresholdValue;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.TextBox columnStartInput;
        private System.Windows.Forms.Label columnStartLabel;
        private System.Windows.Forms.TextBox rowStartInput;
        private System.Windows.Forms.Label rowStartLabel;
        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.Label selectSavePathLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
    }
}

