using Xunit;
using arrayShift;
using static arrayShift.Program;

namespace ArrayShiftUnitTests
{
    public class Class1
    {
        [Theory]
        [InlineData(new int[] {1, 2, 4, 5}, 3)]
        public void CanInsertValue()
        {
            // 3 parts of a unit test:
            // arrange
            // act
            // assert

            Assert.Equal(new int[] {1, 2, 3, 4, 5}, ArrayShift(input, val));
        }
    }
}
