using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexGenerator.MenuSettings
{
    static class Global
    {

        private static readonly Dictionary<string, string> PythonDictionary = new Dictionary<string, string>
        {
            { "whiteSpace", @"\s" },
            { "nonWhiteSpace", @"\S" },
            { "tab", @"\t" },
            { "carriageReturn", @"\r" },
            { "verticalTab", @"\v" },
            { "newLine", @"\n" },
            { "upperAlpha", @"[A-Z]" },
            { "lowerAlpha", @"[a-z]" },
            { "fullAlphabet", @"[A-Za-z]" },
            { "word", @"\w" },
            { "nonWord", @"\W" },
            { "digit", @"[0-9]" },
            { "nonDigit", @"\D" },
            { "zeroOrMore", @"*" },
            { "oneOrMore", @"+" },
            { "zeroOrOne", @"?" },
            { "nonGreedyQuant", @"?" },
            { "bellCharacter", @"\a" },
            { "backspace", @"\b" },
            { "formFeed", @"\f" },
            { "escape", @"\e" },
            { "hexidecimal", @"\x" },
            { "unicode", @"\u" },
            { "unicodeCategory", @"\p" },
            { "nonUnicodeCategory", @"\P" },
            { "beginningAnchor", @"^" },
            { "endingAnchor", @"$" },
            { "startAnchor", @"\A" },
            { "endBeforeNewLineAnchor", @"\Z" },
            { "endStringAnchor", @"\z" },
            { "previousMatchEnd", @"\G" },
            { "boundary", @"\b" },
            { "nonBoundary", @"\B" },
            { "anyCharacter", @"." },
            { "fullStop", @"\." },
        };

        private static readonly Dictionary<string, string> CSharpDictionary = new Dictionary<string, string>
        {
            { "whiteSpace", @"\s" },
            { "nonWhiteSpace", @"\S" },
            { "tab", @"\t" },
            { "carriageReturn", @"\r" },
            { "verticalTab", @"\v" },
            { "newLine", @"\n" },
            { "upperAlpha", @"[A-Z]" },
            { "lowerAlpha", @"[a-z]" },
            { "fullAlphabet", @"[A-Za-z]" },
            { "word", @"\w" },
            { "nonWord", @"\W" },
            { "digit", @"[0-9]" },
            { "nonDigit", @"\D" },
            { "zeroOrMore", @"*" },
            { "oneOrMore", @"+" },
            { "zeroOrOne", @"?" },
            { "nonGreedyQuant", @"?" },
            { "bellCharacter", @"\a" },
            { "backspace", @"\b" },
            { "formFeed", @"\f" },
            { "escape", @"\e" },
            { "hexidecimal", @"\x" },
            { "unicode", @"\u" },
            { "unicodeCategory", @"\p" },
            { "nonUnicodeCategory", @"\P" },
            { "beginningAnchor", @"^" },
            { "endingAnchor", @"$" },
            { "startAnchor", @"\A" },
            { "endBeforeNewLineAnchor", @"\Z" },
            { "endStringAnchor", @"\z" },
            { "previousMatchEnd", @"\G" },
            { "boundary", @"\b" },
            { "nonBoundary", @"\B" },
            { "anyCharacter", @"." },
            { "fullStop", @"\." },
        };

        private static string _language = "C#";
        private static Dictionary<string, string> _languageDictionary = CSharpDictionary;

        public static string Language
        {
            get { return _language; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _language = value;

                if (value == "C#")
                {
                    LanguageDictionary = CSharpDictionary;
                }
                else if (value == "Python")
                {
                    LanguageDictionary = PythonDictionary;
                }
            }
        }

        public static Dictionary<string, string> LanguageDictionary
        {
            get { return _languageDictionary; }
            private set { _languageDictionary = value; }
        }
    }
}
