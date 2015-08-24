using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Math.UglyNumber
{
    public class Solution1
    {
        public bool IsUgly(int num)
        {
            if (num <= 0) return false;
            if (num < 7) return true;
            while (num % 5 == 0) num /= 5;
            while (num % 3 == 0) num /= 3;
            while (num % 2 == 0) num /= 2;
            return num == 1;
        }
    }
}
