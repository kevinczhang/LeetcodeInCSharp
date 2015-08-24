using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Strings.ExcelSheetColumnNumber
{
    public class Solution1
    {
        public int TitleToNumber(string s)
        {
            if (s.Length == 0) return 0;
            int num = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                num += (int)((s[i] - 'A' + 1) * System.Math.Pow(26, s.Length - 1 - i));
            }
            return num;
        }
    }
}
