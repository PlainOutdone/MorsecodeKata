using Morsecode.Domain.Translator;
using System;
using Xunit;

namespace Morsecode.UnitTests
{
    public class DefaultTranslatorTests
    {
        [Fact]
        public void WhenIProvideTheTranslatorWithASpaceGetASpaceBack()
        {
            ITranslator translator = new DefaultTranslator();

            Assert.Equal(" ", translator.Decrypt(" "));
        }


        [Fact]
        public void WhenIDecryptValuesExpectCorrectResponse()
        {
            ITranslator translator = new DefaultTranslator();

            Assert.Equal("A", translator.Decrypt(".-"));
            Assert.Equal("D", translator.Decrypt("-.."));
        }

    }
}
