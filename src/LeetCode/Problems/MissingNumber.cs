using System.Linq;

namespace LeetCode.Problems
{
    public class MissingNumber
    {
        public int Do(int[] nums)
        {
            var n = nums.Length;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }
}