using Xunit;
using static Insertion_Sort.Program;
namespace InsertionSort_Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that InsertionSort returns an array sorted in ascending order.
        /// </summary>
        /// <param name="unsortedArr">Unsorted input array</param>
        /// <param name="sortedArr">Expected, sorted output array</param>
        [Theory]
        [InlineData(new int[] { 2, 8, 5, 3, 1 }, new int[] { 1, 2, 3, 5, 8 })]
        [InlineData(new int[] { 21, 400, 0, 33, 10 }, new int[] { 0, 10, 21, 33, 400 })]
        [InlineData(new int[] { 5, 0, 0, 10, 1 }, new int[] { 0, 0, 1, 5, 10 })]
        public void Test1(int[] unsortedArr, int[] sortedArr)
        {
            int[] result = InsertionSort(unsortedArr);
            Assert.Equal(sortedArr, result);
        }
    }
}
