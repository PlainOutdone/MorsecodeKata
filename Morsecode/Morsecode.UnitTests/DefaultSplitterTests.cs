using Morsecode.Domain.CodeSplitter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Morsecode.UnitTests
{
    public class DefaultSplitterTests
    {
        [Fact]
        public static void WhenGivenNoMessageReturnAnEmptyList()
        {
            ISplitter defaultSplitter = new DefaultSplitter();
            var expected = new List<string>();
            var actual = defaultSplitter.SplitMessage("");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void WhenGivenAMessageEnsureItsSplitOnSpaces()
        {
            ISplitter defaultSplitter = new DefaultSplitter();
            var input = ".- -... -.-. -..";
            var expected = new List<string>()
            {
                {".-" },
                {"-..." },
                {"-.-." },
                {"-.." }
            };
            var actual = defaultSplitter.SplitMessage(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void WhenGivenAMessageWithIncludedSpacesEnsureTheyAreSplitCorrectly()
        {
            ISplitter defaultSplitter = new DefaultSplitter();
            var input = ".- -...   -.-. -..";
            var expected = new List<string>()
            {
                {".-" },
                {"-..." },
                {"" },
                {"-.-." },
                {"-.." }
            };
            var actual = defaultSplitter.SplitMessage(input);

            Assert.Equal(expected, actual);
        }
    }
}
