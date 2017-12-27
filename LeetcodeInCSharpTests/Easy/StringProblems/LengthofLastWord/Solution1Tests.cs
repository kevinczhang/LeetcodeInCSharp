using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeInCSharp.Easy.Strings.LengthofLastWord.Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            Solution1 test = new Solution1();
            Assert.AreEqual(test.LengthOfLastWord("Hello World"), 5);
        }
    }
}