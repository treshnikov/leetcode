using System.Collections.Generic;

namespace LeetCode.Problems
{
    public static class TwoSum
    {
        public static int[] Main(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var delta = target - nums[i];
                if (dict.ContainsKey(delta))
                {
                    res.Add(dict[delta]);
                    res.Add(i);
                }

                dict[nums[i]] = i;
            }

            return res.ToArray();
        }

    } 
}