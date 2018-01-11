using Morsecode.Domain.Translator;
using System;
using Xunit;

namespace Morsecode.UnitTests
{
    public class DefaultTranslatorTests
    {
        [Fact]
        public void WhenIDecryptValuesExpectCorrectResponse()
        {
            ITranslator translator = new DefaultTranslator();

            Assert.Equal(".-", translator.Decrypt("A"));
            Assert.Equal("-..", translator.Decrypt("D"));
        }

    }
}
