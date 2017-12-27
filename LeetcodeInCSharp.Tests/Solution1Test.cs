// <copyright file="Solution1Test.cs">Copyright ©  2015</copyright>
using System;
using LeetcodeInCSharp.Easy.Arrays.ContainsDuplicate;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Easy.Arrays.ContainsDuplicate.Tests
{
    /// <summary>This class contains parameterized unit tests for Solution1</summary>
    [PexClass(typeof(Solution1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Solution1Test
    {
        /// <summary>Test stub for ContainsDuplicate(Int32[])</summary>
        [PexMethod]
        internal bool ContainsDuplicateTest([PexAssumeUnderTest]Solution1 target, int[] nums)
        {
            bool result = target.ContainsDuplicate(nums);
            return result;
            // TODO: add assertions to method Solution1Test.ContainsDuplicateTest(Solution1, Int32[])
        }
    }
}
