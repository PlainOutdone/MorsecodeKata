using System;
using System.Collections.Generic;
using System.Text;

namespace Morsecode.Domain.Translator
{
    public class DefaultTranslator : ITranslator
    {
        private Dictionary<string, string> _library { get { return GenerateDefaultLibrary(); } }
        private Dictionary<string, string> GenerateDefaultLibrary()
        {
            return new Dictionary<string, string>()
            {

                {" "," " },
                {".-","A" },
                {"-...","B" },
                {"-.-.","C" },
                {"-..","D" },
                {".","E" },
                {"..-.","F" },
                {"--.","G" },
                {"....","H" },
                {"..","I" },
                {".---","J" },
                {"-.-","K" },
                {".-..", "L"},
                {"--","M"},
                {"-.","N"},
                {"---", "O"},
                {".--.", "P"},
                {"--.-","Q"},
                {".-.","R"},
                {"...","S"},
                {"-","T"},
                {"..-","U"},
                {"...-","V"},
                {".--","W"},
                {"-..-","X"},
                {"-.--","Y"},
                {"--..","Z"},
                {"-----","0" },
                {".----","1"},
                {"..---","2"},
                {"...--","3"},
                {"....-","4"},
                {".....","5"},
                {"-....","6"},
                {"--...","7"},
                {"---..","8"},
                {"----.","9"}
            };

        }

        public string Decrypt(string input)
        {
            if (_library.ContainsKey(input))
            {
                return _library[input];
            }
            else
            {
                throw new Exception("Unexpected input");
            }
        }
    }
}
