using System;
using Xunit;
using Hashtables;

namespace HashtableTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test adding key-value pairs to the hashtable object.
        /// </summary>
        /// <param name="key">Lookup key</param>
        /// <param name="value">Value to be stored</param>
        /// <param name="expected">Expected return value depending on successful insertion</param>
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

        /// <summary>
        /// Test whether added key-value pairs are contained in the hashtable through the Find(string value) method.
        /// </summary>
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

        /// <summary>
        /// First test for collision should prove that the next Node's Key property in the Bucket's LinkedList is the key of the first added key-value pair. 
        /// </summary>
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

        /// <summary>
        /// Second test for collision should prove that the next Node's Key property in the Bucket's LinkedList is the key of the second added key-value pair. 
        /// </summary>
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
