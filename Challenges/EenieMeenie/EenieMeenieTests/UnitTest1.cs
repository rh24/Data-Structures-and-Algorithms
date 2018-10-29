using static EenieMeenie.Program;
using StackAndQueue.Classes;
using Xunit;

namespace EenieMeenieTests
{
    public class UnitTest1
    {
        public static string[] people = { "wen", "rebecca", "cat", "turtle", "jimmy", "jeff", "kimchi", "pepper" };
        // Sample output for every time nth person gets dequeued when n = 2:
        // wen, cat, jimmy, kimchi
        // wen, jimmy
        // wen
        [Theory]
        [InlineData(2, "wen")]
        [InlineData(3, "kimchi")]
        [InlineData(4, "jeff")]
        public void EeneyMeeney(int n, string remainingPerson)
        {
            string[] people = { "wen", "rebecca", "cat", "turtle", "jimmy", "jeff", "kimchi", "pepper" };
            string returnedPerson = EeneyMeeneyMineyMoe(people, n);
            Assert.Equal(remainingPerson, returnedPerson);
        }
    }
}
