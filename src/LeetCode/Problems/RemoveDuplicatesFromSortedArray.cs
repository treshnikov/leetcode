using System.Collections.Generic;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var dict = new HashSet<int>();
            var res = new int[nums.Length];
            var idx = 0;

            for (int i = 0;i < nums.Length;i++)
            {
                if (dict.Contains(nums[i]))
                {
                    continue;
                }

                dict.Add(nums[i]);
                res[idx] = nums[i];
                idx++;
            }

            for (int i = 0; i < idx; i++)
            {
                nums[i] = res[i];
            }

            return idx;
        }
    }
}
