using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegexGenerator.MenuSettings;

namespace RegexGenerator
{
    public partial class TestWindow : Form
    {
        private string _testRegex = "";
        public TestWindow(string regex)
        {
            _testRegex = regex; 
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestWindow_Load(object sender, EventArgs e)
        {
            this.RegexTextbox.Text = _testRegex;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string rawText = this.InputTextbox.Text;

            StringBuilder outputText = new StringBuilder();

            MatchCollection allMatches = Regex.Matches(rawText, _testRegex);
            foreach (Match match in allMatches)
            {
                outputText.Append(string.Format("Match Found: {0}\n", match.Value));
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    outputText.Append(string.Format("Group {0}: {1}\n", i, match.Groups[i].Value));
                }
                outputText.Append("\n");
            }

            this.MatchesTextbox.Text = allMatches.Count != 0 ? outputText.ToString() : _testRegex;
        }

        private void RegexTextbox_TextChanged(object sender, EventArgs e)
        {
            _testRegex = RegexTextbox.Text;
        }
    }
}
