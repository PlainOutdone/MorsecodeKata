using Morsecode.Domain.CodeReader;
using Morsecode.Domain.CodeSplitter;
using Morsecode.Domain.Translator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Morsecode.UnitTests
{
    public class DefaultCodeReaderTests
    {
        [Fact]
        public static void WhenGivenAnEmptyMessageReturnNothing()
        {
            ICodeReader reader = new DefaultCodeReader(new DefaultSplitter(), new DefaultTranslator());
            var input = "";
            var expected = "";

            var actual = reader.DecryptMessage(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void WhenGivenAValidCodedMessageReturnTheDecryptedVersion()
        {
            ICodeReader reader = new DefaultCodeReader(new DefaultSplitter(), new DefaultTranslator());
            var input = ".- -... -.-. -..";
            var expected = "ABCD";

            var actual = reader.DecryptMessage(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void WhenGivenAValidCodedMessageWithSpacesReturnTheDecryptedVersion()
        {
            ICodeReader reader = new DefaultCodeReader(new DefaultSplitter(), new DefaultTranslator());
            var input = ".... . .-.. .-.. ---  .-- --- .-. .-.. -..";
            var expected = "HELLO WORLD";

            var actual = reader.DecryptMessage(input);

            Assert.Equal(expected, actual);
        }
    }
}
