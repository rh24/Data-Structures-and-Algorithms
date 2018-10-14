using System;
using Xunit;
using static Fibonacci.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        public void Test1(int n, int expected)
        {
            Assert.Equal(expected, IterativeFibonacci(n));
        }
    }
}
