using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Arrays.ContainsDuplicate
{
    class Solution1
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1) return false;
            HashSet<int> hash = new HashSet<int>();
            foreach(int num in nums)
            {
                if (hash.Contains(num))
                    return true;
                hash.Add(num);
            }
            return false;
        }
    }
}
