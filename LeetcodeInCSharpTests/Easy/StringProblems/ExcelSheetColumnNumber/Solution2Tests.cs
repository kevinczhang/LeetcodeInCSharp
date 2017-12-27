using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Tests
{
    [TestClass()]
    public class Solution2Tests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {
            Solution2 test = new Solution2();
            Assert.AreEqual(test.TitleToNumber("A"), 1);
        }
    }
}