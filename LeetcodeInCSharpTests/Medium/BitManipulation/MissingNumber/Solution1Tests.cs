using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Medium.BitManipulation.MissingNumber.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void MissingNumberTest()
        {
            Solution1 test = new Solution1();
            Assert.AreEqual(test.MissingNumber(new int[] { 0 }), 1);
        }
    }
}