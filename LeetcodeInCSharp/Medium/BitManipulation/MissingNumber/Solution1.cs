using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Medium.BitManipulation.MissingNumber
{
    public class Solution1
    {
        public int MissingNumber(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
                res ^= (i + 1) ^ nums[i];
            return res;
        }
    }
}
