using Xunit;
using arrayShift;
using static arrayShift.Program;

namespace ArrayShiftUnitTests
{
    public class Class1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5 }, 3)]
        [InlineData(new int[] { 10, 12, 15, 20, 77, 88 }, new int[] { 10, 12, 15, 77, 88 }, 20)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, new int[] { 4, 8, 15, 23, 42 }, 16)]
        public void CanInsertValue(int[] expected, int[] input, int val)
        {
            // 3 parts of a unit test:
            // arrange
            // act
            // assert

            Assert.Equal(expected, ArrayShift(input, val));
        }
    }
}
