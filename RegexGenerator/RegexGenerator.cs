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
    public partial class RegexGenerator : Form
    {
        public RegexGenerator()
        {
            InitializeComponent();
        }

        private void RegexGenerator_Load(object sender, EventArgs e)
        {

        }

        private void AlphaCharButton_Click(object sender, EventArgs e)
        {
            //UpdateRegexText("[A-Za-z]");
            using (BasicPopup popup = new BasicPopup())
            {
                popup.ShowDialog(this);
            }
        }

        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.RegexTextbox.Text);
        }

        public void UpdateRegexText(string newText)
        {
            //Kind of a bad way to do this, but it's very simple text, so shouldn't cause issues
            this.RegexTextbox.Text = ModifyQuotes() + newText + "\"";
        }

        private string ModifyQuotes()
        {
            string currentText = this.RegexTextbox.Text;

            if (currentText == String.Empty)
            {
                //Insert the preceding quote
                return "\"";
            } else
            {
                //Remove the trailing quote mark
                return currentText.Substring(0, currentText.Length - 1);
            }
        }
    }
}
