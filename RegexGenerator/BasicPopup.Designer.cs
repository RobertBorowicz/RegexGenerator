namespace RegexGenerator
{
    partial class BasicPopup
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
            this.MatchesLabel = new System.Windows.Forms.Label();
            this.ZeroOneButton = new System.Windows.Forms.RadioButton();
            this.OneMoreButton = new System.Windows.Forms.RadioButton();
            this.ExactlyButton = new System.Windows.Forms.RadioButton();
            this.RangeButton = new System.Windows.Forms.RadioButton();
            this.AddToRegexButton = new System.Windows.Forms.Button();
            this.ZeroMoreButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExactlyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MatchesLabel
            // 
            this.MatchesLabel.AutoSize = true;
            this.MatchesLabel.Location = new System.Drawing.Point(13, 13);
            this.MatchesLabel.Name = "MatchesLabel";
            this.MatchesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MatchesLabel.Size = new System.Drawing.Size(57, 13);
            this.MatchesLabel.TabIndex = 0;
            this.MatchesLabel.Text = "Matches...";
            // 
            // ZeroOneButton
            // 
            this.ZeroOneButton.AutoSize = true;
            this.ZeroOneButton.Location = new System.Drawing.Point(16, 74);
            this.ZeroOneButton.Name = "ZeroOneButton";
            this.ZeroOneButton.Size = new System.Drawing.Size(82, 17);
            this.ZeroOneButton.TabIndex = 1;
            this.ZeroOneButton.TabStop = true;
            this.ZeroOneButton.Text = "Zero or One";
            this.ZeroOneButton.UseVisualStyleBackColor = true;
            // 
            // OneMoreButton
            // 
            this.OneMoreButton.AutoSize = true;
            this.OneMoreButton.Location = new System.Drawing.Point(16, 107);
            this.OneMoreButton.Name = "OneMoreButton";
            this.OneMoreButton.Size = new System.Drawing.Size(84, 17);
            this.OneMoreButton.TabIndex = 2;
            this.OneMoreButton.TabStop = true;
            this.OneMoreButton.Text = "One or More";
            this.OneMoreButton.UseVisualStyleBackColor = true;
            // 
            // ExactlyButton
            // 
            this.ExactlyButton.AutoSize = true;
            this.ExactlyButton.Location = new System.Drawing.Point(16, 142);
            this.ExactlyButton.Name = "ExactlyButton";
            this.ExactlyButton.Size = new System.Drawing.Size(68, 17);
            this.ExactlyButton.TabIndex = 3;
            this.ExactlyButton.TabStop = true;
            this.ExactlyButton.Text = "Exactly...";
            this.ExactlyButton.UseVisualStyleBackColor = true;
            this.ExactlyButton.CheckedChanged += new System.EventHandler(this.ExactlyButton_CheckedChanged);
            // 
            // RangeButton
            // 
            this.RangeButton.AutoSize = true;
            this.RangeButton.Location = new System.Drawing.Point(16, 174);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(66, 17);
            this.RangeButton.TabIndex = 4;
            this.RangeButton.TabStop = true;
            this.RangeButton.Text = "Range...";
            this.RangeButton.UseVisualStyleBackColor = true;
            // 
            // AddToRegexButton
            // 
            this.AddToRegexButton.Location = new System.Drawing.Point(72, 213);
            this.AddToRegexButton.Name = "AddToRegexButton";
            this.AddToRegexButton.Size = new System.Drawing.Size(75, 23);
            this.AddToRegexButton.TabIndex = 5;
            this.AddToRegexButton.Text = "Add";
            this.AddToRegexButton.UseVisualStyleBackColor = true;
            this.AddToRegexButton.Click += new System.EventHandler(this.AddToRegexButton_Click);
            // 
            // ZeroMoreButton
            // 
            this.ZeroMoreButton.AutoSize = true;
            this.ZeroMoreButton.Location = new System.Drawing.Point(16, 41);
            this.ZeroMoreButton.Name = "ZeroMoreButton";
            this.ZeroMoreButton.Size = new System.Drawing.Size(86, 17);
            this.ZeroMoreButton.TabIndex = 6;
            this.ZeroMoreButton.TabStop = true;
            this.ZeroMoreButton.Text = "Zero or More";
            this.ZeroMoreButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(153, 213);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExactlyTextBox
            // 
            this.ExactlyTextBox.Location = new System.Drawing.Point(90, 139);
            this.ExactlyTextBox.MaxLength = 3;
            this.ExactlyTextBox.Name = "ExactlyTextBox";
            this.ExactlyTextBox.Size = new System.Drawing.Size(30, 20);
            this.ExactlyTextBox.TabIndex = 8;
            // 
            // BasicPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 248);
            this.Controls.Add(this.ExactlyTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ZeroMoreButton);
            this.Controls.Add(this.AddToRegexButton);
            this.Controls.Add(this.RangeButton);
            this.Controls.Add(this.ExactlyButton);
            this.Controls.Add(this.OneMoreButton);
            this.Controls.Add(this.ZeroOneButton);
            this.Controls.Add(this.MatchesLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasicPopup";
            this.Text = "BasicPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MatchesLabel;
        private System.Windows.Forms.RadioButton ZeroOneButton;
        private System.Windows.Forms.RadioButton OneMoreButton;
        private System.Windows.Forms.RadioButton ExactlyButton;
        private System.Windows.Forms.RadioButton RangeButton;
        private System.Windows.Forms.Button AddToRegexButton;
        private System.Windows.Forms.RadioButton ZeroMoreButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ExactlyTextBox;
    }
}