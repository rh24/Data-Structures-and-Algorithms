using Xunit;
using static Repeated_Word.Program;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Three tests to ensure RepeatedWord returns the expected value.
        /// </summary>
        /// <param name="longWord">Lengthy string to check for first repeated word</param>
        /// <param name="expected">First repeated word if found</param>
        [Theory]
        [InlineData("acatateanappleandbecameacatapple", null)]
        [InlineData("turtles move slowly. they are turtles", "turtles")]
        [InlineData("an apple ate an apple and became an apple.", "an")]
        public void TestRepeatedWord(string longWord, string expected)
        {
            string repeatedWord = RepeatedWord(longWord);
            Assert.Equal(expected, repeatedWord);
        }

        // Add more tests later:
        // [InlineData(";;;;; ; ;; ;;;", null)]
    }
}
