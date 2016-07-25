namespace RegexGenerator
{
    partial class CustomRangeWindow
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
            this.CustomGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // CustomGroupBox
            // 
            this.CustomGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CustomGroupBox.Name = "CustomGroupBox";
            this.CustomGroupBox.Size = new System.Drawing.Size(329, 171);
            this.CustomGroupBox.TabIndex = 0;
            this.CustomGroupBox.TabStop = false;
            this.CustomGroupBox.Text = "Custom Characters";
            // 
            // CustomRangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 196);
            this.Controls.Add(this.CustomGroupBox);
            this.Name = "CustomRangeWindow";
            this.Text = "Custom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomGroupBox;
    }
}