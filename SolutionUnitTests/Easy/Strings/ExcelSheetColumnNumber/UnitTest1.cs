using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionUnitTests.Easy.Strings.ExcelSheetColumnNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExcelSheetColumnNumber()
        {
            LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Solution2 test = 
                new LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Solution2();
            Assert.AreEqual(test.TitleToNumber("A"), 1);
        }
    }
}
