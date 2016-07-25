using System;
using System.Windows.Forms;
using RegexGenerator.MenuSettings;

namespace RegexGenerator
{
    public partial class QuantifierWindow : Form
    {
        private readonly string _baseString;
        public QuantifierWindow(string baseString)
        {
            this._baseString = baseString;
            InitializeComponent();
            this.Text = "Quantifier";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddToRegexButton_Click(object sender, EventArgs e)
        {
            RegexGenerator parent = (RegexGenerator)this.Owner;

            string regexAddition = "";

            if (ZeroOneButton.Checked)
            {
                regexAddition = _baseString + Global.LanguageDictionary["zeroOrOne"];
            } else if (ZeroMoreButton.Checked)
            {
                regexAddition = _baseString + Global.LanguageDictionary["zeroOrMore"];
            } else if (ExactlyButton.Checked)
            {
                string val = ExactlyTextBox.Text;
                if (!string.IsNullOrEmpty(val))
                {
                    regexAddition = _baseString + string.Format("{{{0}}}", val);
                }
            } else if (RangeButton.Checked)
            {
                string fromVal = FromTextbox.Text;
                if (!string.IsNullOrEmpty(fromVal))
                {
                    regexAddition = _baseString + string.Format("{{{0},{1}}}", fromVal, ToTextBox.Text);
                }
            } else if (OneMoreButton.Checked)
            {
                regexAddition = _baseString + Global.LanguageDictionary["oneOrMore"];
            }
            else
            {
                regexAddition = _baseString;
            }

            if (!GreedyCheck.Checked && !ExactlyButton.Checked && !SingleRadioButton.Checked) regexAddition += Global.LanguageDictionary["nonGreedyQuant"];
            parent.UpdateRegexText(regexAddition);
            this.Close();
        }

        private void ExactlyButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ExactlyTextBox.Enabled = !this.ExactlyTextBox.Enabled;
            this.GreedyCheck.Enabled = !this.GreedyCheck.Enabled;
        }

        private void RangeButton_CheckedChanged(object sender, EventArgs e)
        {
            this.FromTextbox.Enabled = !FromTextbox.Enabled;
            this.ToTextBox.Enabled = !ToTextBox.Enabled;
        }

        private void ValidateDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void SingleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.GreedyCheck.Enabled = !this.GreedyCheck.Enabled;
        }
    }
}
