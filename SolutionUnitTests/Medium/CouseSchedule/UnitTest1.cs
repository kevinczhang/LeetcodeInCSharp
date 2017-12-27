using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeInCSharp.Medium.GraphProblems.CourseSchedule;

namespace SolutionUnitTests.Medium.CouseSchedule
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution1 test = new Solution1();
            int[,] inputs = { { 1, 0}, { 2, 1 } };
            test.CanFinish(3, inputs);
        }
    }
}
