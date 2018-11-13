using System;
using Xunit;
using Hashtables;

namespace HashtableTests
{
    public class UnitTest1
    {
        //Insertion
        //Contains
        //2 tests for collisions
        [Theory]
        [InlineData("wen", "turtle", true)]
        [InlineData(null, null, false)]
        [InlineData("hello", "goodbye", true)]
        public void TestInsertion(object key, object value, bool expected)
        {
            Hashtable ht = new Hashtable();
            bool successfullyAdded = ht.Add((string)key, value);
            Assert.Equal(expected, successfullyAdded);
        }

        [Fact]
        public void TestContains()
        {
            // Act
            Hashtable ht = new Hashtable();

            // Arrange
            ht.Add("wen", "turtle");
            ht.Add("cardamom", "twist");
            ht.Add("screen", "mom");

            // Assert
            Assert.Equal("turtle", ht.Find("wen"));
            Assert.Equal("twist", ht.Find("cardamom"));
            Assert.Equal("mom", ht.Find("screen"));
        }

        [Fact]
        public void TestCollision1()
        {
            // Act
            Hashtable ht = new Hashtable();

            // Arrange
            ht.Add("brainy", "pinky");
            ht.Add("binary", "tree");
            LinkedList LL = ht.HT[ht.GetHash("brainy")];

            // Assert
            Assert.Equal("brainy", LL.Head.Next.Key);
        }

        [Fact]
        public void TestCollision2()
        {
            // Act
            Hashtable ht = new Hashtable();

            // Arrange
            ht.Add("brainy", "pinky");
            ht.Add("binary", "tree");
            ht.Add("inarby", "mumble");
            LinkedList LL = ht.HT[ht.GetHash("brainy")];

            // Assert
            Assert.Equal("binary", LL.Head.Next.Key);
        }
    }
}
