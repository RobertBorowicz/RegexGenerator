using System;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class RegexGenerator : Form
    {
        private string _currentRegex;

        public RegexGenerator()
        {
            InitializeComponent();
            InitializeClicks();
        }

        private void InitializeClicks()
        {
            //Add clicking functions
            this.NewlineButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\n"); };
            this.SpaceButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\s"); };
            this.TabButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\t"); };
            this.AlphaCharButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"[A-Za-z]"); };
            this.DigitButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\d"); };
            this.CarriageButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\r"); };
            this.VertTabButton.Click += (sender, eventArgs) => { OpenQuantifier_Click(sender, eventArgs, @"\v"); };
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
            RegexTextbox.Text += newText;
        }

        private string ModifyQuotes()
        {
            string currentText = RegexTextbox.Text;

            return currentText == string.Empty ? "\"" : currentText.Substring(0, currentText.Length - 1);
        }

        private void OpenQuantifier_Click(object sender, EventArgs e, string buttonText)
        {
            using (QuantifierWindow popup = new QuantifierWindow(buttonText))
            {
                popup.ShowDialog(this);
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentRegex))
            {
                using (TestWindow tWindow = new TestWindow(_currentRegex))
                {
                    tWindow.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Null Regex String");
            }
        }

        private void GroupselectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set all visible to false and then set focus to correct group
            this.AlphaNumGroup.Visible = false;
            this.SpecialCharGroup.Visible = false;
            this.UnicodeGroup.Visible = false;
            this.SpacingBox.Visible = false;

            switch (GroupselectCombo.SelectedIndex)
            {
                case 0:
                    this.AlphaNumGroup.Visible = true;
                    //this.AlphaNumGroup.BringToFront();
                    break;
                case 1:
                    this.SpecialCharGroup.Visible = true;
                    //this.SpecialCharGroup.BringToFront();
                    break;
                case 2:
                    this.UnicodeGroup.Visible = true;
                    //this.UnicodeGroup.BringToFront();
                    break;
                case 3:
                    this.SpacingBox.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsMenu options = new OptionsMenu())
            {
                options.ShowDialog(this);
            }
        }

        private void RegexTextbox_TextChanged(object sender, EventArgs e)
        {
            _currentRegex = RegexTextbox.Text;
        }
    }
}
