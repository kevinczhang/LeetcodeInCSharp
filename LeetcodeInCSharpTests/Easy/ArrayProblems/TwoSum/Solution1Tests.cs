using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeInCSharp.Easy.ArrayProblems.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.ArrayProblems.TwoSum.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            Solution1 test = new Solution1();
            int[] nums = { 2, 7, 11, 15 };
            int[] res = test.TwoSum(nums, 9);
            Assert.AreEqual(2, nums[0]);
            Assert.AreEqual(7, nums[1]);
        }
    }
}