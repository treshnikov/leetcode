using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public static class ThreeSum
    {
        public static IList<IList<int>> Main(int[] nums)
        {
            var res = new List<List<int>>();
            var dict = new Dictionary<int, int>();
            var visited = new HashSet<ValueTuple<int, int, int>>();

            for (int firstNumIdx = 0; firstNumIdx < nums.Length; firstNumIdx++)
            {
                var target = -1 * nums[firstNumIdx];
                dict.Clear();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == firstNumIdx)
                    {
                        continue;
                    }

                    var delta = target - nums[i];

                    if (dict.ContainsKey(delta))
                    {
                        var v1 = nums[firstNumIdx];
                        var v2 = nums[i];
                        var v3 = nums[dict[delta]];

                        var key = new ValueTuple<int, int, int>(v1, v2, v3);

                        if (!visited.Contains(key))
                        {
                            res.Add(new List<int> { v1, v2, v3 });

                            visited.Add(key);
                            visited.Add(new ValueTuple<int, int, int>(v1, v3, v2));
                            visited.Add(new ValueTuple<int, int, int>(v2, v1, v3));
                            visited.Add(new ValueTuple<int, int, int>(v2, v3, v1));
                            visited.Add(new ValueTuple<int, int, int>(v3, v1, v2));
                            visited.Add(new ValueTuple<int, int, int>(v3, v2, v1));
                        }
                    }

                    dict[nums[i]] = i;
                }
            }

            return res.ToArray();
        }
    }
}