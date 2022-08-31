using System.Collections.Generic;
using System.Linq;

public class ClimbStairsSolution
{
    // https://leetcode.com/problems/climbing-stairs/submissions/
    public int ClimbStairs(int n)
    {
        var res = new List<int> { 1, 1 };
        for (int i = 2; i <= n; i++)
        {
            res.Add(res[i - 1] + res[i - 2]);
        }

        return res.Last();
    }
}
