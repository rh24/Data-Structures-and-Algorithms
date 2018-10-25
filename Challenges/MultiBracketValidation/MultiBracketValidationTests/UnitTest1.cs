using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that MultiBracketValidation in Program.cs works.
        /// </summary>
        [Theory]
        [InlineData(true, "[](){}")]
        [InlineData(false, "][)")]
        [InlineData(true, "ae[o]{|}")]
        public void Test1(bool expected, string input)
        {
            Assert.Equal(expected, MultibracketValidation(input));
        }
    }
}
