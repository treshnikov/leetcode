namespace LeetCode.Problems
{
    // https://leetcode.com/problems/sqrtx
    public static class MySqrtSolution
    {
        public static int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            if (x == 1)
            {
                return 1;
            }

            var start = 0;
            var end = x;
            var ans = 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (mid == x / mid)
                {
                    return mid;
                }

                if (mid <= x / mid)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ans;

        }
    }
}
