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
                {"A",".-" },
                {"B","-..." },
                {"C","-.-." },
                {"D","-.." }
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
