using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.ArrayProblems.TwoSum
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    res[0] = map[nums[i]];
                    res[1] = i;
                    return res;
                }
                if(!map.ContainsKey(target - nums[i]))
                    map.Add(target - nums[i], i);
            }
            return res;
        }
    }
}
