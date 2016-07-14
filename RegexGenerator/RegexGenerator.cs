using System;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class RegexGenerator : Form
    {
        public RegexGenerator()
        {
            InitializeComponent();
        }

        private void AlphaCharButton_Click(object sender, EventArgs e)
        {
            //UpdateRegexText("[A-Za-z]");
            using (Quantifier popup = new Quantifier("[A-Za-z]"))
            {
                popup.ShowDialog(this);
            }
        }

        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.RegexTextbox.Text))
            {
                Clipboard.SetText(this.RegexTextbox.Text);
            }
        }

        public void UpdateRegexText(string newText)
        {
            //Kind of a bad way to do this, but it's very simple text, so shouldn't cause issues
            RegexTextbox.Text = ModifyQuotes() + newText + "\"";
        }

        private string ModifyQuotes()
        {
            string currentText = RegexTextbox.Text;

            if (currentText == string.Empty)
            {
                //Insert the preceding quote
                return "\"";
            } else
            {
                //Remove the trailing quote mark
                return currentText.Substring(0, currentText.Length - 1);
            }
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            using (Quantifier popup = new Quantifier("[0-9]"))
            {
                popup.ShowDialog(this);
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            using (TestWindow tWindow = new TestWindow())
            {
                tWindow.ShowDialog(this);
            }
        }
    }
}
