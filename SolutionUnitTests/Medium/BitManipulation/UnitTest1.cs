using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionUnitTests.Medium.BitManipulation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LeetcodeInCSharp.Medium.BitManipulation.MissingNumber.Solution1 test =
                new LeetcodeInCSharp.Medium.BitManipulation.MissingNumber.Solution1();
            Assert.AreEqual(test.MissingNumber(new int[] { 0 }), 1);
        }
    }
}
