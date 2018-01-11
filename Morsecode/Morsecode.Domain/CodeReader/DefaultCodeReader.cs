using Morsecode.Domain.CodeSplitter;
using Morsecode.Domain.Translator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Morsecode.Domain.CodeReader
{
    public class DefaultCodeReader : ICodeReader
    {

        private ISplitter _splitter;
        private ITranslator _translator;
        public DefaultCodeReader(ISplitter splitter, ITranslator translator)
        {
            _splitter = splitter;
            _translator = translator;
        }

        public string DecryptMessage(string message)
        {
            List<string> letters = _splitter.SplitMessage(message);
            List<string> decodedLetters = new List<string>();
            foreach (string letter in letters)
            {
                decodedLetters.Add(_translator.Decrypt(letter));
            }

            var output = "";
            foreach (string letter in decodedLetters)
            {
                output = output + letter;
            }

            return output;
        }
    }
}
