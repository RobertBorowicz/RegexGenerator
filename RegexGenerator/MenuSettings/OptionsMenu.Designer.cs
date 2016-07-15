namespace RegexGenerator
{
    partial class OptionsMenu
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
            this.OptionsBox = new System.Windows.Forms.GroupBox();
            this.LangOptionLabel = new System.Windows.Forms.Label();
            this.LanguageCombo = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.OptionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBox
            // 
            this.OptionsBox.Controls.Add(this.OKButton);
            this.OptionsBox.Controls.Add(this.LanguageCombo);
            this.OptionsBox.Controls.Add(this.LangOptionLabel);
            this.OptionsBox.Location = new System.Drawing.Point(13, 13);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(259, 236);
            this.OptionsBox.TabIndex = 0;
            this.OptionsBox.TabStop = false;
            this.OptionsBox.Text = "Options";
            // 
            // LangOptionLabel
            // 
            this.LangOptionLabel.AutoSize = true;
            this.LangOptionLabel.Location = new System.Drawing.Point(7, 34);
            this.LangOptionLabel.Name = "LangOptionLabel";
            this.LangOptionLabel.Size = new System.Drawing.Size(58, 13);
            this.LangOptionLabel.TabIndex = 0;
            this.LangOptionLabel.Text = "Language:";
            // 
            // LanguageCombo
            // 
            this.LanguageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageCombo.FormattingEnabled = true;
            this.LanguageCombo.Items.AddRange(new object[] {
            "C#",
            "Python"});
            this.LanguageCombo.Location = new System.Drawing.Point(71, 31);
            this.LanguageCombo.Name = "LanguageCombo";
            this.LanguageCombo.Size = new System.Drawing.Size(121, 21);
            this.LanguageCombo.TabIndex = 1;
            this.LanguageCombo.SelectedIndexChanged += new System.EventHandler(this.LanguageCombo_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(93, 207);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OptionsBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsMenu";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsMenu_Load);
            this.OptionsBox.ResumeLayout(false);
            this.OptionsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OptionsBox;
        private System.Windows.Forms.ComboBox LanguageCombo;
        private System.Windows.Forms.Label LangOptionLabel;
        private System.Windows.Forms.Button OKButton;
    }
}