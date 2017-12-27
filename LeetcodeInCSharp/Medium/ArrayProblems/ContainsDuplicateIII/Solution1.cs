using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************
 *
 *  Given an array of integers, find out whether there are two distinct indices i and j in the array such that 
 *  the difference between nums[i] and nums[j] is at most t and the difference between i and j is at most k.
 *
 ********************************/

namespace LeetcodeInCSharp.Medium.ArrayProblems.ContainsDuplicateIII
{
    public class Solution1
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums.Length <= 1 || k < 0 || t < 0 || (k == 0 && t > 0)) return false;
            SortedSet<int> tree = new SortedSet<int>();
            for (int i=0; i<nums.Length; i++)
            {
                if(tree.Any(x => ((long)x - nums[i]) >= int.MinValue && ((long)x - nums[i]) <= int.MaxValue && Math.Abs(x - nums[i]) <= k)) return true;                
                tree.Add(nums[i]);
                if (i > k) tree.Remove(nums[i-k]);
            }

            return false;
        }
    }
}
