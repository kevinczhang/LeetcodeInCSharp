// <copyright file="Solution1Test.cs">Copyright ©  2015</copyright>
using System;
using LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Tests
{
    /// <summary>This class contains parameterized unit tests for Solution1</summary>
    [PexClass(typeof(Solution1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Solution1Test
    {
        /// <summary>Test stub for TitleToNumber(String)</summary>
        [PexMethod]
        public int TitleToNumberTest([PexAssumeUnderTest]Solution1 target, string s)
        {
            int result = target.TitleToNumber(s);
            return result;
            // TODO: add assertions to method Solution1Test.TitleToNumberTest(Solution1, String)
        }
    }
}
