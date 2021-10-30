using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/median-of-two-sorted-arrays/
    public static class FindMedianSortedArrays
    {
        public static double Main(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            var res = new List<int>();

            if (nums1.Length == 0)
            {
                res.AddRange(nums2);
                j = nums2.Length;
            }
            else if (nums2.Length == 0)
            {
                res.AddRange(nums1);
                i = nums1.Length;
            }
            else
            {
                while (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] == nums2[j])
                    {
                        res.Add(nums1[i]);
                        res.Add(nums2[j]);
                        i++;
                        j++;
                    }
                    else if (nums1[i] < nums2[j])
                    {
                        if (i == nums1.Length - 1)
                        {
                            res.Add(nums1[i]);
                            res.Add(nums2[j]);
                            i++;
                            j++;
                        }
                        else if (nums1[i + 1] > nums2[j])
                        {
                            res.Add(nums1[i]);
                            res.Add(nums2[j]);
                            i++;
                            j++;
                        }
                        else
                        {
                            res.Add(nums1[i]);
                            i++;
                        }
                    }
                    else 
                    {
                        if (j == nums2.Length - 1)
                        {
                            res.Add(nums2[j]);
                            res.Add(nums1[i]);
                            i++;
                            j++;
                        }
                        else if (nums2[j + 1] > nums1[i])
                        {
                            res.Add(nums2[j]);
                            res.Add(nums1[i]);
                            i++;
                            j++;
                        }
                        else
                        {
                            res.Add(nums2[j]);
                            j++;
                        }
                    }
                }
            }

            if (i < nums1.Length)
            {
                res.AddRange(nums1.Skip(i).ToArray());
            }

            if (j < nums2.Length)
            {
                res.AddRange(nums2.Skip(j).ToArray());
            }

            if (res.Count % 2 == 0)
            {
                return (res[-1 + res.Count / 2] + res[res.Count / 2]) / 2.0;
            }
            else 
            {
                return res[(int)res.Count / 2];
            }
        }
    }
}
