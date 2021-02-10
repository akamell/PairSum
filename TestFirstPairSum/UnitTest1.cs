using NUnit.Framework;
using FirstPairSum;

namespace TestFirstPairSum
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var numbers = new int[] { 0, 0, 0, 3, 2, 1, 3, 6 };
            int[] expected = new int[] { 0, 7 };
            int[] result = Pair.Get(6, numbers);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            var numbers = new int[] { 0, 3, 2, 1, 3, 7 };
            int[] expected = new int[] { 1, 4 };
            int[] result = Pair.Get(6, numbers);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            var numbers = new int[] { 0, 1, 5 };
            int[] expected = new int[] { 1, 2 };
            int[] result = Pair.Get(6, numbers);
            Assert.AreEqual(expected, result);
        }
    }
}