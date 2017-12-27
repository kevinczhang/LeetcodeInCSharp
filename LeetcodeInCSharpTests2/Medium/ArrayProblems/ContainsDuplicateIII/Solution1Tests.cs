using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Medium.ArrayProblems.ContainsDuplicateIII.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void ContainsNearbyAlmostDuplicateTest()
        {
            Solution1 test = new Solution1();
            Assert.IsFalse(test.ContainsNearbyAlmostDuplicate(new int[] { -3, 3 }, 2, 4));
        }
    }
}