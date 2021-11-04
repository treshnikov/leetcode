using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public static class ThreeSumClosets
    {
        public static int Do(int[] nums, int target)
        {
            Array.Sort(nums);
            var closeSum = nums[0] + nums[1] + nums[2];
            var closest = Math.Abs(closeSum - target);

            for (int i = 0; i < nums.Length; i++)
            {
                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = nums[left] + nums[right] + nums[i];
                    if (Math.Abs(target - sum) < closest)
                    {
                        closest = Math.Abs(target - sum);
                        closeSum = sum;
                    }

                    if (target - sum < 0)
                    {
                        right -= 1;
                    }
                    else if (target - sum > 0)
                    {
                        left += 1;
                    }
                    else
                    {
                        return sum;
                    }
                }

            }

            return closeSum;
        }
    }
}
