using System.Runtime.Remoting.Channels;

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
            this.AlphaNumGroup = new System.Windows.Forms.GroupBox();
            this.CaseLabel = new System.Windows.Forms.Label();
            this.BothRadioButton = new System.Windows.Forms.RadioButton();
            this.LowerRadioButton = new System.Windows.Forms.RadioButton();
            this.UpperRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialCharGroup = new System.Windows.Forms.GroupBox();
            this.UnicodeGroup = new System.Windows.Forms.GroupBox();
            this.GroupselectCombo = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.SpacingBox = new System.Windows.Forms.GroupBox();
            this.NewlineButton = new System.Windows.Forms.Button();
            this.TabButton = new System.Windows.Forms.Button();
            this.SpaceButton = new System.Windows.Forms.Button();
            this.CarriageButton = new System.Windows.Forms.Button();
            this.VertTabButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.AlphaNumGroup.SuspendLayout();
            this.SpecialCharGroup.SuspendLayout();
            this.SpacingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegexTextbox
            // 
            this.RegexTextbox.Location = new System.Drawing.Point(12, 41);
            this.RegexTextbox.Name = "RegexTextbox";
            this.RegexTextbox.Size = new System.Drawing.Size(326, 20);
            this.RegexTextbox.TabIndex = 0;
            this.RegexTextbox.TextChanged += new System.EventHandler(this.RegexTextbox_TextChanged);
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
            this.AlphaCharButton.Location = new System.Drawing.Point(6, 19);
            this.AlphaCharButton.Name = "AlphaCharButton";
            this.AlphaCharButton.Size = new System.Drawing.Size(86, 23);
            this.AlphaCharButton.TabIndex = 2;
            this.AlphaCharButton.Text = "Alphabet (A-Z)";
            this.AlphaCharButton.UseVisualStyleBackColor = true;
            // 
            // DigitButton
            // 
            this.DigitButton.Location = new System.Drawing.Point(6, 58);
            this.DigitButton.Name = "DigitButton";
            this.DigitButton.Size = new System.Drawing.Size(86, 23);
            this.DigitButton.TabIndex = 3;
            this.DigitButton.Text = "Digit (0-9)";
            this.DigitButton.UseVisualStyleBackColor = true;
            // 
            // CharRangeButton
            // 
            this.CharRangeButton.Location = new System.Drawing.Point(6, 100);
            this.CharRangeButton.Name = "CharRangeButton";
            this.CharRangeButton.Size = new System.Drawing.Size(86, 23);
            this.CharRangeButton.TabIndex = 4;
            this.CharRangeButton.Text = "Char Range";
            this.CharRangeButton.UseVisualStyleBackColor = true;
            // 
            // CharGroupButton
            // 
            this.CharGroupButton.Location = new System.Drawing.Point(6, 139);
            this.CharGroupButton.Name = "CharGroupButton";
            this.CharGroupButton.Size = new System.Drawing.Size(86, 23);
            this.CharGroupButton.TabIndex = 5;
            this.CharGroupButton.Text = "Custom Group";
            this.CharGroupButton.UseVisualStyleBackColor = true;
            // 
            // WhiteSpaceButton
            // 
            this.WhiteSpaceButton.Location = new System.Drawing.Point(6, 19);
            this.WhiteSpaceButton.Name = "WhiteSpaceButton";
            this.WhiteSpaceButton.Size = new System.Drawing.Size(86, 23);
            this.WhiteSpaceButton.TabIndex = 6;
            this.WhiteSpaceButton.Text = "White Space";
            this.WhiteSpaceButton.UseVisualStyleBackColor = true;
            // 
            // AnyCharButton
            // 
            this.AnyCharButton.Location = new System.Drawing.Point(6, 58);
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
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
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
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
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
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // AlphaNumGroup
            // 
            this.AlphaNumGroup.Controls.Add(this.CaseLabel);
            this.AlphaNumGroup.Controls.Add(this.BothRadioButton);
            this.AlphaNumGroup.Controls.Add(this.LowerRadioButton);
            this.AlphaNumGroup.Controls.Add(this.UpperRadioButton);
            this.AlphaNumGroup.Controls.Add(this.AlphaCharButton);
            this.AlphaNumGroup.Controls.Add(this.DigitButton);
            this.AlphaNumGroup.Controls.Add(this.CharRangeButton);
            this.AlphaNumGroup.Controls.Add(this.CharGroupButton);
            this.AlphaNumGroup.Location = new System.Drawing.Point(361, 173);
            this.AlphaNumGroup.Name = "AlphaNumGroup";
            this.AlphaNumGroup.Size = new System.Drawing.Size(326, 168);
            this.AlphaNumGroup.TabIndex = 13;
            this.AlphaNumGroup.TabStop = false;
            this.AlphaNumGroup.Text = "Alphanumeric";
            // 
            // CaseLabel
            // 
            this.CaseLabel.AutoSize = true;
            this.CaseLabel.Location = new System.Drawing.Point(197, 19);
            this.CaseLabel.Name = "CaseLabel";
            this.CaseLabel.Size = new System.Drawing.Size(34, 13);
            this.CaseLabel.TabIndex = 9;
            this.CaseLabel.Text = "Case:";
            // 
            // BothRadioButton
            // 
            this.BothRadioButton.AutoSize = true;
            this.BothRadioButton.Location = new System.Drawing.Point(197, 84);
            this.BothRadioButton.Name = "BothRadioButton";
            this.BothRadioButton.Size = new System.Drawing.Size(47, 17);
            this.BothRadioButton.TabIndex = 8;
            this.BothRadioButton.TabStop = true;
            this.BothRadioButton.Text = "Both";
            this.BothRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            this.LowerRadioButton.AutoSize = true;
            this.LowerRadioButton.Location = new System.Drawing.Point(197, 61);
            this.LowerRadioButton.Name = "LowerRadioButton";
            this.LowerRadioButton.Size = new System.Drawing.Size(77, 17);
            this.LowerRadioButton.TabIndex = 7;
            this.LowerRadioButton.TabStop = true;
            this.LowerRadioButton.Text = "Lowercase";
            this.LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperRadioButton
            // 
            this.UpperRadioButton.AutoSize = true;
            this.UpperRadioButton.Location = new System.Drawing.Point(197, 38);
            this.UpperRadioButton.Name = "UpperRadioButton";
            this.UpperRadioButton.Size = new System.Drawing.Size(77, 17);
            this.UpperRadioButton.TabIndex = 6;
            this.UpperRadioButton.TabStop = true;
            this.UpperRadioButton.Text = "Uppercase";
            this.UpperRadioButton.UseVisualStyleBackColor = true;
            // 
            // SpecialCharGroup
            // 
            this.SpecialCharGroup.Controls.Add(this.WhiteSpaceButton);
            this.SpecialCharGroup.Controls.Add(this.AnyCharButton);
            this.SpecialCharGroup.Location = new System.Drawing.Point(147, 87);
            this.SpecialCharGroup.Name = "SpecialCharGroup";
            this.SpecialCharGroup.Size = new System.Drawing.Size(200, 98);
            this.SpecialCharGroup.TabIndex = 14;
            this.SpecialCharGroup.TabStop = false;
            this.SpecialCharGroup.Text = "Special Characters";
            // 
            // UnicodeGroup
            // 
            this.UnicodeGroup.Location = new System.Drawing.Point(361, 357);
            this.UnicodeGroup.Name = "UnicodeGroup";
            this.UnicodeGroup.Size = new System.Drawing.Size(200, 100);
            this.UnicodeGroup.TabIndex = 15;
            this.UnicodeGroup.TabStop = false;
            this.UnicodeGroup.Text = "Unicode";
            // 
            // GroupselectCombo
            // 
            this.GroupselectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupselectCombo.FormattingEnabled = true;
            this.GroupselectCombo.Items.AddRange(new object[] {
            "Alphanumeric",
            "Special Characters",
            "Unicode",
            "Spacing",
            "Existing Templates"});
            this.GroupselectCombo.Location = new System.Drawing.Point(12, 68);
            this.GroupselectCombo.Name = "GroupselectCombo";
            this.GroupselectCombo.Size = new System.Drawing.Size(121, 21);
            this.GroupselectCombo.TabIndex = 16;
            this.GroupselectCombo.SelectedIndexChanged += new System.EventHandler(this.GroupselectCombo_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(82, 25);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(21, 13);
            this.LanguageLabel.TabIndex = 17;
            this.LanguageLabel.Text = "C#";
            // 
            // SpacingBox
            // 
            this.SpacingBox.Controls.Add(this.VertTabButton);
            this.SpacingBox.Controls.Add(this.CarriageButton);
            this.SpacingBox.Controls.Add(this.NewlineButton);
            this.SpacingBox.Controls.Add(this.TabButton);
            this.SpacingBox.Controls.Add(this.SpaceButton);
            this.SpacingBox.Location = new System.Drawing.Point(12, 96);
            this.SpacingBox.Name = "SpacingBox";
            this.SpacingBox.Size = new System.Drawing.Size(326, 186);
            this.SpacingBox.TabIndex = 18;
            this.SpacingBox.TabStop = false;
            this.SpacingBox.Text = "Spacing";
            // 
            // NewlineButton
            // 
            this.NewlineButton.Location = new System.Drawing.Point(7, 132);
            this.NewlineButton.Name = "NewlineButton";
            this.NewlineButton.Size = new System.Drawing.Size(75, 23);
            this.NewlineButton.TabIndex = 2;
            this.NewlineButton.Text = "New Line";
            this.NewlineButton.UseVisualStyleBackColor = true;
            // 
            // TabButton
            // 
            this.TabButton.Location = new System.Drawing.Point(7, 77);
            this.TabButton.Name = "TabButton";
            this.TabButton.Size = new System.Drawing.Size(75, 23);
            this.TabButton.TabIndex = 1;
            this.TabButton.Text = "Tab";
            this.TabButton.UseVisualStyleBackColor = true;
            // 
            // SpaceButton
            // 
            this.SpaceButton.Location = new System.Drawing.Point(7, 29);
            this.SpaceButton.Name = "SpaceButton";
            this.SpaceButton.Size = new System.Drawing.Size(75, 23);
            this.SpaceButton.TabIndex = 0;
            this.SpaceButton.Text = "Space";
            this.SpaceButton.UseVisualStyleBackColor = true;
            // 
            // CarriageButton
            // 
            this.CarriageButton.Location = new System.Drawing.Point(135, 29);
            this.CarriageButton.Name = "CarriageButton";
            this.CarriageButton.Size = new System.Drawing.Size(75, 23);
            this.CarriageButton.TabIndex = 3;
            this.CarriageButton.Text = "Carriage Ret";
            this.CarriageButton.UseVisualStyleBackColor = true;
            // 
            // VertTabButton
            // 
            this.VertTabButton.Location = new System.Drawing.Point(135, 77);
            this.VertTabButton.Name = "VertTabButton";
            this.VertTabButton.Size = new System.Drawing.Size(75, 23);
            this.VertTabButton.TabIndex = 4;
            this.VertTabButton.Text = "Vertical Tab";
            this.VertTabButton.UseVisualStyleBackColor = true;
            // 
            // RegexGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 484);
            this.Controls.Add(this.AlphaNumGroup);
            this.Controls.Add(this.SpacingBox);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.GroupselectCombo);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.SpecialCharGroup);
            this.Controls.Add(this.VerbatimCheckbox);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.RegexLabel);
            this.Controls.Add(this.RegexTextbox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UnicodeGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegexGenerator";
            this.Text = "Basic Regex Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AlphaNumGroup.ResumeLayout(false);
            this.AlphaNumGroup.PerformLayout();
            this.SpecialCharGroup.ResumeLayout(false);
            this.SpacingBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox AlphaNumGroup;
        private System.Windows.Forms.GroupBox SpecialCharGroup;
        private System.Windows.Forms.GroupBox UnicodeGroup;
        private System.Windows.Forms.ComboBox GroupselectCombo;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.RadioButton BothRadioButton;
        private System.Windows.Forms.RadioButton LowerRadioButton;
        private System.Windows.Forms.RadioButton UpperRadioButton;
        private System.Windows.Forms.Label CaseLabel;
        private System.Windows.Forms.GroupBox SpacingBox;
        private System.Windows.Forms.Button NewlineButton;
        private System.Windows.Forms.Button TabButton;
        private System.Windows.Forms.Button SpaceButton;
        private System.Windows.Forms.Button VertTabButton;
        private System.Windows.Forms.Button CarriageButton;
    }
}

