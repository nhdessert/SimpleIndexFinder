using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindIndexProblem.Test
{
    [TestClass]
    public class IndexFinderTest
    {
        int[] testArray = new int[] { 34, 45, 55, 67, 78, 89, 4, 12, 17 };

        [TestMethod]
        public void FindIndex_XIs44_ReturnsNegative1()
        {
            int sortedIndex = IndexFinder.FindIndex(44, testArray);
            Assert.AreEqual(-1, sortedIndex);
        }

        [TestMethod]
        public void FindIndex_XIs34_Returns0()
        {
            int index = IndexFinder.FindIndex(34, testArray);
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void FindIndex_XIs67_Returns3()
        {
            int index = IndexFinder.FindIndex(67, testArray);

            Assert.AreEqual(3, index);
        }

        [TestMethod]
        public void FindIndex_XIs89_Returns5()
        {
            int index = IndexFinder.FindIndex(89, testArray);

            Assert.AreEqual(5, index);
        }

        [TestMethod]
        public void FindIndex_XIs4_Returns6()
        {
            int index = IndexFinder.FindIndex(4, testArray);

            Assert.AreEqual(6, index);
        }

        [TestMethod]
        public void FindIndex_XIs17_Returns8()
        {
            int index = IndexFinder.FindIndex(17, testArray);

            Assert.AreEqual(8, index);
        }
    }
}
