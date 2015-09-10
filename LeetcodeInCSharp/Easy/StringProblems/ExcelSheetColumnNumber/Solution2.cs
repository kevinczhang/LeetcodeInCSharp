using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber
{
    public class Solution2
    {
        public int TitleToNumber(string s)
        {
            if (s.Length == 0) return 0;
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                num = num*26 + s[i]-'A'+1;
            }
            return num;
        }
    }
}
