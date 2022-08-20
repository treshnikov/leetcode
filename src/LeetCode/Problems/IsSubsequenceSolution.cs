namespace LeetCode.Problems
{
    // https://leetcode.com/problems/is-subsequence/
    public class IsSubsequenceSolution {
    public bool IsSubsequence(string s, string t) {
        if (s == "")
            return true;
        
        var sIdx = 0;
        foreach(var c in t)
        {
            if (c == s[sIdx])
            {
                sIdx++;
            }
            
            if (sIdx == s.Length) return true;
        }
        
        return false;
    }
}   
}