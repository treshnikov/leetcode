using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public static class MergeTwoSortedArrays
    {
        /// <summary>
        /// Merges two given sorted arrays.
        /// The idea is to move over array elements using pointers. 
        /// When all elements of one of the arrays are marked, the procedure just adds remained elements from another array.
        /// Example: a = [1, 3, 7, 9], b = [2, 8, 12, 15], res = [1, 2, 3, 7, 8, 12, 15]
        /// </summary>
        public static int[] Merge(int[] a, int[] b)
        {
            var res = new List<int>();

            if (a.Length == 0 && b.Length == 0)
            {
                return System.Array.Empty<int>();
            }

            if (a.Length == 0)
            {
                return b.ToArray();
            }

            if (b.Length == 0)
            {
                return b.ToArray();
            }

            int i = 0;
            int j = 0;
            var cnt = a.Length;

            while (true)
            {
                if (i == cnt)
                {
                    res.AddRange(b.Skip(j));
                    break;
                }

                if (j == cnt)
                {
                    res.AddRange(a.Skip(i));
                    break;
                }

                if (a[i] < b[j])
                {
                    res.Add(a[i]);
                    i++;
                }
                else if (a[i] > b[j])
                {
                    res.Add(b[j]);
                    j++;
                }
                else 
                {
                    res.Add(a[i]);
                    res.Add(b[j]);
                    i++;
                    j++;
                }
            }

            return res.ToArray();
        }
    }
}
