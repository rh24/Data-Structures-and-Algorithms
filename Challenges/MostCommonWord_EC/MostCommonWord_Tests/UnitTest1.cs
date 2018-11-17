using Xunit;
using static MostCommonWord_EC.Program;

namespace MostCommonWord_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("CATS CATS CATS CATS CATS, and they are all fat.", "CATS")]
        [InlineData("what do we return if nothing is most common?", "")]
        [InlineData("doges doges turtles turtles", "doges")]
        public void TestMostCommonWord(string input, string expectedOutput)
        {
            string returnVal = MostCommonWord(input);
            Assert.Equal(expectedOutput, returnVal);
        }
    }
}
