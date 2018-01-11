using Morsecode.Domain;
using Morsecode.Domain.CodeReader;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.Extensions.DependencyInjection;

namespace Morsecode.IntegrationTests
{
    public class DefaultCodeReaderTests
    {
        [Fact]
        public static void WhenGivenNoMessageReturnAnEmptyString()
        {
            ICodeReader reader = IoC.Container.GetService<ICodeReader>();
            var expected = "";
            var actual = reader.DecryptMessage("");

            Assert.Equal(expected, actual);
        }


        [Fact]
        public static void WhenGivenSomeValidMorseCodeReturnTheMessage()
        {
            ICodeReader reader = IoC.Container.GetService<ICodeReader>();
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "HEY JUDE";

            var actual = reader.DecryptMessage(input);

            Assert.Equal(expected, actual);
        }
    }
}
