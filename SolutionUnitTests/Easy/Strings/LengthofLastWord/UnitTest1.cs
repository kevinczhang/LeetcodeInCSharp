using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionUnitTests.Easy.Strings.LengthofLastWord
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLengthofLastWord()
        {
            LeetcodeInCSharp.Easy.Strings.LengthofLastWord.Solution1 test =
                new LeetcodeInCSharp.Easy.Strings.LengthofLastWord.Solution1();
            Assert.AreEqual(test.LengthOfLastWord("Hello World"), 5);
        }
    }
}
