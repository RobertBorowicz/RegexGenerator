namespace RegexGenerator
{
    partial class TestWindow
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
            this.InputTextbox = new System.Windows.Forms.RichTextBox();
            this.MatchesTextbox = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegexTextbox
            // 
            this.RegexTextbox.Location = new System.Drawing.Point(13, 13);
            this.RegexTextbox.Name = "RegexTextbox";
            this.RegexTextbox.Size = new System.Drawing.Size(259, 20);
            this.RegexTextbox.TabIndex = 0;
            this.RegexTextbox.TextChanged += new System.EventHandler(this.RegexTextbox_TextChanged);
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(13, 59);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(259, 190);
            this.InputTextbox.TabIndex = 1;
            this.InputTextbox.Text = "";
            // 
            // MatchesTextbox
            // 
            this.MatchesTextbox.Location = new System.Drawing.Point(278, 59);
            this.MatchesTextbox.Name = "MatchesTextbox";
            this.MatchesTextbox.ReadOnly = true;
            this.MatchesTextbox.Size = new System.Drawing.Size(259, 190);
            this.MatchesTextbox.TabIndex = 2;
            this.MatchesTextbox.Text = "";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(278, 11);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run Test";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(462, 255);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 285);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.MatchesTextbox);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.RegexTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.Load += new System.EventHandler(this.TestWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegexTextbox;
        private System.Windows.Forms.RichTextBox InputTextbox;
        private System.Windows.Forms.RichTextBox MatchesTextbox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button CancelButton;
    }
}