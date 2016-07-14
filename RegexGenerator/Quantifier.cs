﻿using System;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class Quantifier : Form
    {
        private readonly string _baseString;
        public Quantifier(string baseString)
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
                regexAddition = _baseString + "?";
            } else if (ZeroMoreButton.Checked)
            {
                regexAddition = _baseString + "*";
            } else if (ExactlyButton.Checked)
            {

            } else if (RangeButton.Checked)
            {

            } else if (OneMoreButton.Checked)
            {
                regexAddition = _baseString + "+";
            }
            parent.UpdateRegexText(regexAddition);
            this.Close();
        }

        private void ExactlyButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ExactlyTextBox.Enabled = !this.ExactlyTextBox.Enabled;
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
    }
}