using System;
namespace LeetCode.Problems
{
    public static class SearchInsertProblem
    {
        // https://leetcode.com/problems/search-insert-position/
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

            return Math.Max(start, end);

        }
    }
}
