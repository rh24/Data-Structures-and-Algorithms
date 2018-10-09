using Xunit;
using arrayShift;

namespace ArrayShiftUnitTests
{
    public class Class1
    {
        public void CanInsertValue()
        {
            // 3 parts of a unit test:
            // arrange
            // act
            // assert

            Assert.Equal(new int[] {1, 2, 3, 4, 5}, Program.ArrayShift(new int[] {1, 2, 4, 5}, 3));
        }
    }
}
