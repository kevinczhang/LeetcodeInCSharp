using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Medium.GraphProblems.CourseSchedule.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void CanFinishTest()
        {
            Solution1 test = new Solution1();
            int[,] inputs = { { 1, 0 }, { 2, 1 } };
            test.CanFinish(3, inputs);
        }
    }
}