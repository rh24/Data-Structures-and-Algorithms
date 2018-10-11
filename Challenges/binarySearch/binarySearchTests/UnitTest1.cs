using System;
using Xunit;
using static binarySearch.Program;

namespace ArrayBinarySearchTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 6, 7 }, 3, 1)]
        [InlineData(new int[] { 1, 3, 6, 7, 8, 9 }, 9, 5)]
        [InlineData(new int[] { 2 }, 2, 0)]
        [InlineData(new int[] { 2 }, 5, -1)]
        [InlineData(new int[] { 0, 0, 0 }, 2, -1)]
        public void Test1(int[] input, int target, int expected)
        {
            Assert.Equal(expected, BinarySearch(input, target));
        }
    }
}
