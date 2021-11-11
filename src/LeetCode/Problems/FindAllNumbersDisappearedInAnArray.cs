using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    /// </summary>
    public class FindAllNumbersDisappearedInAnArray
    {
        public static List<int> FindDisappearedNumbers(int[] nums)
        {
            var i = 0;

            while (i < nums.Length)
            {
                var pos = nums[i] - 1;
                if (nums[pos] != nums[i])
                {
                    var temp = nums[pos];
                    nums[pos] = nums[i];
                    nums[i] = temp;
                }
                else
                {
                    i++;
                }

            }

            var list = new List<int>();
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }
    }
}