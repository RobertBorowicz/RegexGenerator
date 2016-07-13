namespace RegexGenerator
{
    partial class RegexGenerator
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
            this.RegexTextbox = new System.Windows.Forms.TextBox();
            this.RegexLabel = new System.Windows.Forms.Label();
            this.AlphaCharButton = new System.Windows.Forms.Button();
            this.DigitButton = new System.Windows.Forms.Button();
            this.CharRangeButton = new System.Windows.Forms.Button();
            this.CharGroupButton = new System.Windows.Forms.Button();
            this.WhiteSpaceButton = new System.Windows.Forms.Button();
            this.AnyCharButton = new System.Windows.Forms.Button();
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.VerbatimCheckbox = new System.Windows.Forms.CheckBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegexTextbox
            // 
            this.RegexTextbox.Location = new System.Drawing.Point(12, 41);
            this.RegexTextbox.Name = "RegexTextbox";
            this.RegexTextbox.Size = new System.Drawing.Size(326, 20);
            this.RegexTextbox.TabIndex = 0;
            // 
            // RegexLabel
            // 
            this.RegexLabel.AutoSize = true;
            this.RegexLabel.Location = new System.Drawing.Point(9, 25);
            this.RegexLabel.Name = "RegexLabel";
            this.RegexLabel.Size = new System.Drawing.Size(76, 13);
            this.RegexLabel.TabIndex = 1;
            this.RegexLabel.Text = "Regex Output:";
            // 
            // AlphaCharButton
            // 
            this.AlphaCharButton.Location = new System.Drawing.Point(12, 106);
            this.AlphaCharButton.Name = "AlphaCharButton";
            this.AlphaCharButton.Size = new System.Drawing.Size(86, 23);
            this.AlphaCharButton.TabIndex = 2;
            this.AlphaCharButton.Text = "Alpha Char";
            this.AlphaCharButton.UseVisualStyleBackColor = true;
            this.AlphaCharButton.Click += new System.EventHandler(this.AlphaCharButton_Click);
            // 
            // DigitButton
            // 
            this.DigitButton.Location = new System.Drawing.Point(12, 136);
            this.DigitButton.Name = "DigitButton";
            this.DigitButton.Size = new System.Drawing.Size(86, 23);
            this.DigitButton.TabIndex = 3;
            this.DigitButton.Text = "Digit (0-9)";
            this.DigitButton.UseVisualStyleBackColor = true;
            // 
            // CharRangeButton
            // 
            this.CharRangeButton.Location = new System.Drawing.Point(12, 166);
            this.CharRangeButton.Name = "CharRangeButton";
            this.CharRangeButton.Size = new System.Drawing.Size(86, 23);
            this.CharRangeButton.TabIndex = 4;
            this.CharRangeButton.Text = "Char Range";
            this.CharRangeButton.UseVisualStyleBackColor = true;
            // 
            // CharGroupButton
            // 
            this.CharGroupButton.Location = new System.Drawing.Point(12, 195);
            this.CharGroupButton.Name = "CharGroupButton";
            this.CharGroupButton.Size = new System.Drawing.Size(86, 23);
            this.CharGroupButton.TabIndex = 5;
            this.CharGroupButton.Text = "Char Group";
            this.CharGroupButton.UseVisualStyleBackColor = true;
            // 
            // WhiteSpaceButton
            // 
            this.WhiteSpaceButton.Location = new System.Drawing.Point(132, 136);
            this.WhiteSpaceButton.Name = "WhiteSpaceButton";
            this.WhiteSpaceButton.Size = new System.Drawing.Size(86, 23);
            this.WhiteSpaceButton.TabIndex = 6;
            this.WhiteSpaceButton.Text = "White Space";
            this.WhiteSpaceButton.UseVisualStyleBackColor = true;
            // 
            // AnyCharButton
            // 
            this.AnyCharButton.Location = new System.Drawing.Point(132, 106);
            this.AnyCharButton.Name = "AnyCharButton";
            this.AnyCharButton.Size = new System.Drawing.Size(86, 23);
            this.AnyCharButton.TabIndex = 7;
            this.AnyCharButton.Text = "Any Char";
            this.AnyCharButton.UseVisualStyleBackColor = true;
            // 
            // CopyTextButton
            // 
            this.CopyTextButton.Location = new System.Drawing.Point(263, 67);
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.Size = new System.Drawing.Size(75, 23);
            this.CopyTextButton.TabIndex = 8;
            this.CopyTextButton.Text = "Copy Text";
            this.CopyTextButton.UseVisualStyleBackColor = true;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // VerbatimCheckbox
            // 
            this.VerbatimCheckbox.AutoSize = true;
            this.VerbatimCheckbox.Location = new System.Drawing.Point(12, 296);
            this.VerbatimCheckbox.Name = "VerbatimCheckbox";
            this.VerbatimCheckbox.Size = new System.Drawing.Size(67, 17);
            this.VerbatimCheckbox.TabIndex = 9;
            this.VerbatimCheckbox.Text = "Verbatim";
            this.VerbatimCheckbox.UseVisualStyleBackColor = true;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(263, 290);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 10;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // RegexGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 325);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.VerbatimCheckbox);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.AnyCharButton);
            this.Controls.Add(this.WhiteSpaceButton);
            this.Controls.Add(this.CharGroupButton);
            this.Controls.Add(this.CharRangeButton);
            this.Controls.Add(this.DigitButton);
            this.Controls.Add(this.AlphaCharButton);
            this.Controls.Add(this.RegexLabel);
            this.Controls.Add(this.RegexTextbox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RegexGenerator";
            this.Text = "Basic Regex Generator";
            this.Load += new System.EventHandler(this.RegexGenerator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegexTextbox;
        private System.Windows.Forms.Label RegexLabel;
        private System.Windows.Forms.Button AlphaCharButton;
        private System.Windows.Forms.Button DigitButton;
        private System.Windows.Forms.Button CharRangeButton;
        private System.Windows.Forms.Button CharGroupButton;
        private System.Windows.Forms.Button WhiteSpaceButton;
        private System.Windows.Forms.Button AnyCharButton;
        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.CheckBox VerbatimCheckbox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    }
}

