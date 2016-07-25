namespace RegexGenerator
{
    partial class QuantifierWindow
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
            this.ZeroOneButton = new System.Windows.Forms.RadioButton();
            this.OneMoreButton = new System.Windows.Forms.RadioButton();
            this.ExactlyButton = new System.Windows.Forms.RadioButton();
            this.RangeButton = new System.Windows.Forms.RadioButton();
            this.AddToRegexButton = new System.Windows.Forms.Button();
            this.ZeroMoreButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExactlyTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.FromTextbox = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.QuantifyGroupBox = new System.Windows.Forms.GroupBox();
            this.SingleRadioButton = new System.Windows.Forms.RadioButton();
            this.GreedyCheck = new System.Windows.Forms.CheckBox();
            this.QuantifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZeroOneButton
            // 
            this.ZeroOneButton.AutoSize = true;
            this.ZeroOneButton.Location = new System.Drawing.Point(10, 84);
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
            this.OneMoreButton.Location = new System.Drawing.Point(117, 48);
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
            this.ExactlyButton.Location = new System.Drawing.Point(117, 84);
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
            this.RangeButton.Location = new System.Drawing.Point(117, 119);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(66, 17);
            this.RangeButton.TabIndex = 4;
            this.RangeButton.TabStop = true;
            this.RangeButton.Text = "Range...";
            this.RangeButton.UseVisualStyleBackColor = true;
            this.RangeButton.CheckedChanged += new System.EventHandler(this.RangeButton_CheckedChanged);
            // 
            // AddToRegexButton
            // 
            this.AddToRegexButton.Location = new System.Drawing.Point(77, 174);
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
            this.ZeroMoreButton.Location = new System.Drawing.Point(10, 119);
            this.ZeroMoreButton.Name = "ZeroMoreButton";
            this.ZeroMoreButton.Size = new System.Drawing.Size(86, 17);
            this.ZeroMoreButton.TabIndex = 6;
            this.ZeroMoreButton.TabStop = true;
            this.ZeroMoreButton.Text = "Zero or More";
            this.ZeroMoreButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(158, 174);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExactlyTextBox
            // 
            this.ExactlyTextBox.Enabled = false;
            this.ExactlyTextBox.Location = new System.Drawing.Point(191, 83);
            this.ExactlyTextBox.MaxLength = 3;
            this.ExactlyTextBox.Name = "ExactlyTextBox";
            this.ExactlyTextBox.Size = new System.Drawing.Size(30, 20);
            this.ExactlyTextBox.TabIndex = 8;
            this.ExactlyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDigitKeyPress);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(184, 121);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(30, 13);
            this.FromLabel.TabIndex = 9;
            this.FromLabel.Text = "From";
            // 
            // FromTextbox
            // 
            this.FromTextbox.Enabled = false;
            this.FromTextbox.Location = new System.Drawing.Point(220, 116);
            this.FromTextbox.MaxLength = 2;
            this.FromTextbox.Name = "FromTextbox";
            this.FromTextbox.Size = new System.Drawing.Size(22, 20);
            this.FromTextbox.TabIndex = 10;
            this.FromTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FromTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDigitKeyPress);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(248, 121);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(16, 13);
            this.ToLabel.TabIndex = 11;
            this.ToLabel.Text = "to";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Enabled = false;
            this.ToTextBox.Location = new System.Drawing.Point(270, 116);
            this.ToTextBox.MaxLength = 2;
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(22, 20);
            this.ToTextBox.TabIndex = 12;
            this.ToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDigitKeyPress);
            // 
            // QuantifyGroupBox
            // 
            this.QuantifyGroupBox.Controls.Add(this.SingleRadioButton);
            this.QuantifyGroupBox.Controls.Add(this.GreedyCheck);
            this.QuantifyGroupBox.Controls.Add(this.ZeroOneButton);
            this.QuantifyGroupBox.Controls.Add(this.ToLabel);
            this.QuantifyGroupBox.Controls.Add(this.ToTextBox);
            this.QuantifyGroupBox.Controls.Add(this.FromLabel);
            this.QuantifyGroupBox.Controls.Add(this.ZeroMoreButton);
            this.QuantifyGroupBox.Controls.Add(this.OneMoreButton);
            this.QuantifyGroupBox.Controls.Add(this.FromTextbox);
            this.QuantifyGroupBox.Controls.Add(this.ExactlyButton);
            this.QuantifyGroupBox.Controls.Add(this.RangeButton);
            this.QuantifyGroupBox.Controls.Add(this.ExactlyTextBox);
            this.QuantifyGroupBox.Location = new System.Drawing.Point(12, 13);
            this.QuantifyGroupBox.Name = "QuantifyGroupBox";
            this.QuantifyGroupBox.Size = new System.Drawing.Size(297, 155);
            this.QuantifyGroupBox.TabIndex = 13;
            this.QuantifyGroupBox.TabStop = false;
            this.QuantifyGroupBox.Text = "Quantifiers";
            // 
            // SingleRadioButton
            // 
            this.SingleRadioButton.AutoSize = true;
            this.SingleRadioButton.Checked = true;
            this.SingleRadioButton.Location = new System.Drawing.Point(10, 48);
            this.SingleRadioButton.Name = "SingleRadioButton";
            this.SingleRadioButton.Size = new System.Drawing.Size(82, 17);
            this.SingleRadioButton.TabIndex = 14;
            this.SingleRadioButton.TabStop = true;
            this.SingleRadioButton.Text = "Exactly One";
            this.SingleRadioButton.UseVisualStyleBackColor = true;
            this.SingleRadioButton.CheckedChanged += new System.EventHandler(this.SingleRadioButton_CheckedChanged);
            // 
            // GreedyCheck
            // 
            this.GreedyCheck.AutoSize = true;
            this.GreedyCheck.Checked = true;
            this.GreedyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GreedyCheck.Enabled = false;
            this.GreedyCheck.Location = new System.Drawing.Point(187, 10);
            this.GreedyCheck.Name = "GreedyCheck";
            this.GreedyCheck.Size = new System.Drawing.Size(108, 17);
            this.GreedyCheck.TabIndex = 13;
            this.GreedyCheck.Text = "Greedy Quantifier";
            this.GreedyCheck.UseVisualStyleBackColor = true;
            // 
            // Quantifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 202);
            this.Controls.Add(this.QuantifyGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddToRegexButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quantifier";
            this.Text = "Quantifiers";
            this.QuantifyGroupBox.ResumeLayout(false);
            this.QuantifyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton ZeroOneButton;
        private System.Windows.Forms.RadioButton OneMoreButton;
        private System.Windows.Forms.RadioButton ExactlyButton;
        private System.Windows.Forms.RadioButton RangeButton;
        private System.Windows.Forms.Button AddToRegexButton;
        private System.Windows.Forms.RadioButton ZeroMoreButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ExactlyTextBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.TextBox FromTextbox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.GroupBox QuantifyGroupBox;
        private System.Windows.Forms.CheckBox GreedyCheck;
        private System.Windows.Forms.RadioButton SingleRadioButton;
    }
}