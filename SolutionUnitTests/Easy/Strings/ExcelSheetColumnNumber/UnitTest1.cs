using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionUnitTests.Easy.Strings.ExcelSheetColumnNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Solution1 test = 
                new LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Solution1();
            Assert.AreEqual(test.TitleToNumber("A"), 1);
        }
    }
}
