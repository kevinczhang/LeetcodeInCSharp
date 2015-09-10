using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeInCSharp.Easy.Arrays.ContainsDuplicateII
{
    class Solution1
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length <= 1) return false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {                
                if (dic.ContainsKey(nums[i])) // if dic contains the element value
                    if (i - dic[nums[i]] <= k) return true; // if indexes diff is less than k return true
                dic[nums[i]] = i; // add or update nums in the dictionary
            }
            return false;
        }
    }
}
