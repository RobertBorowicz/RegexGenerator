using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class BasicPopup : Form
    {
        public BasicPopup()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddToRegexButton_Click(object sender, EventArgs e)
        {
            RegexGenerator parent = (RegexGenerator)this.Owner;
            if (this.ZeroOneButton.Checked)
            {
                parent.UpdateRegexText("?");
            } else if (this.ZeroMoreButton.Checked)
            {
                parent.UpdateRegexText("*");
            } else if (this.ExactlyButton.Checked)
            {

            } else if (this.RangeButton.Checked)
            {

            } else if (this.OneMoreButton.Checked)
            {
                parent.UpdateRegexText("+");
            }
            this.Close();
        }

        private void ExactlyButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ExactlyTextBox.Enabled = !this.ExactlyTextBox.Enabled;
        }

        private void 
    }
}
