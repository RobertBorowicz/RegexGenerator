using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexGenerator.MenuSettings
{
    static class Global
    {
        private static string _language = "C#";

        public static string Language
        {
            get { return _language; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _language = value;
            }
        }
    }
}
