using System.Collections.Generic;

namespace Morsecode.Domain.CodeSplitter
{
    public interface ISplitter
    {
        List<string> SplitMessage(string message);
    }

}
