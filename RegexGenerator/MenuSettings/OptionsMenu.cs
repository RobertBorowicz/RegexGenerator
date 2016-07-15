using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegexGenerator.MenuSettings;

namespace RegexGenerator
{
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            LanguageCombo.Text = Global.Language;
        }

        private void LanguageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang = "";
            switch (LanguageCombo.SelectedIndex)
            {
                
                default:
                    lang = "C#";
                    break;
                case 1:
                    lang = "Python";
                    break;
            }
            Global.Language = lang;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
