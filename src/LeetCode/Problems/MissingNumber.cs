using System.Linq;

namespace LeetCode.Problems
{
    public class MissingNumber
    {
        public static int Do(int[] nums)
        {
            var n = nums.Length;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }
}