using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Strings.LengthofLastWord
{
    public class Solution1
    {
        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0) return 0;
            int i = s.Length - 1, wordCount = 0;

            // Clean " " in the end
            while (i >= 0 && s[i--] == ' ') ;
            i++;
            while (i >= 0 && s[i--] != ' ') wordCount++;            
            return wordCount;
        }
    }
}
