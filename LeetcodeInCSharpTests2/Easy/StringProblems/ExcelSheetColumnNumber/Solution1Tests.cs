using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {
            Solution1 test = new Solution1();
            Assert.AreEqual(test.TitleToNumber("A"), 1);
        }
    }
}