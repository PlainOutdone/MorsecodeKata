using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morsecode.Domain.CodeSplitter
{
    public class DefaultSplitter : ISplitter
    {
        public List<string> SplitMessage(string message)
        {
            if (String.IsNullOrEmpty(message)) { return new List<string>(); }

            message = message.Replace("  ", " "); //Avoiding any triple spaces to avoid duplicate entries on split

            return message.Split(" ").ToList();
        }
    }

}
