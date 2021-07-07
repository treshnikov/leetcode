using LeetCode.Problems;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var res = TwoSum.Main(new int[] { 2, 7, 11, 15 }, 9);
            // res = TwoSum.Main(new int[] { 3, 2, 4 }, 6);
            // res = TwoSum.Main(new int[] { 3, 3 }, 6);

            //var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            //var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            //var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            //var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            //var res = AddTwoNumbers.Main(l1, l2);

            //Problems.PrintInOrder.Foo foo = new Problems.PrintInOrder.Foo();
            //var t1 = new Thread(() => { foo.First(() => { Console.WriteLine(1); }); });
            //var t2 = new Thread(() => { foo.Second(() => { Console.WriteLine(2); }); });
            //var t3 = new Thread(() => { foo.Third(() => { Console.WriteLine(3); }); });
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //var fooBar = new Problems.PrintFooBarAlternatelyChannels.FooBar(3);
            //var t1 = new Thread(() => { fooBar.Bar(() => { Console.Write("bar"); }); });
            //var t2 = new Thread(() => { fooBar.Foo(() => { Console.Write("foo"); }); });
            //t2.Start();
            //t1.Start();

            //var h20 = new H2O();
            //var t1 = new Thread(() => { h20.Hydrogen(() => { Console.Write("H"); }); });
            //var t2 = new Thread(() => { h20.Oxygen(() => { Console.Write("O"); }); });
            //var t3 = new Thread(() => { h20.Hydrogen(() => { Console.Write("H"); }); });
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb"));
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("bbbbb"));
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew"));
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(""));
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(" "));
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("dvdf"));

            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 1, 3 }, new int[] { 2 }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 1, 2 }, new int[] { 3, 4 }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 0, 0 }, new int[] { 0, 0 }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { }, new int[] { 1 }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 2 }, new int[] { }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 3 }, new int[] { -2, -1 }));
            //Console.WriteLine(FindMedianSortedArrays.Main(new int[] { 4,5,6,8,9 }, new int[] { }));

            //Console.WriteLine(LongestPalindromicSubstring.Main(""));
            //Console.WriteLine(LongestPalindromicSubstring.Main("babad"));
            //Console.WriteLine(LongestPalindromicSubstring.Main("cbbd"));
            //Console.WriteLine(LongestPalindromicSubstring.Main("a"));
            //Console.WriteLine(LongestPalindromicSubstring.Main("ac"));
            //Console.WriteLine(LongestPalindromicSubstring.Main(""));

            //var obj = new FizzBuzz(15);
            //var a = new Thread(() => { obj.Fizz(() => { Console.WriteLine("fiz"); }); });
            //var b = new Thread(() => { obj.Buzz(() => { Console.WriteLine("buzz"); }); });
            //var c = new Thread(() => { obj.Fizzbuzz(() => { Console.WriteLine("fizbuzz"); }); });
            //var d = new Thread(() => { obj.Number(i => { Console.WriteLine(i); }); });
            //b.Start();
            //a.Start();
            //c.Start();
            //d.Start();

            //Console.WriteLine(ReverseInteger.Main(-123));

            //Console.WriteLine(ZigZagConversion.Convert("PAYPALISHIRING", 3));
            //Console.WriteLine(ZigZagConversion.Convert("PAYPALISHIRING", 4));
            //Console.WriteLine(ZigZagConversion.Convert("A", 1));
            //Console.WriteLine(ZigZagConversion.Convert("AB", 1));
            //Console.WriteLine(ZigZagConversion.Convert("ABC", 1));

            //Console.WriteLine(MyAtoi.Main("-91283472332"));         
            //Console.WriteLine(MyAtoi.Main("20000000000000000000"));
            //Console.WriteLine(MyAtoi.Main("   +0 123"));
            //Console.WriteLine(MyAtoi.Main("00000-42a1234"));
            //Console.WriteLine(MyAtoi.Main("+-12"));
            //Console.WriteLine(MyAtoi.Main("-"));
            //Console.WriteLine(MyAtoi.Main("   -42"));
            //Console.WriteLine(MyAtoi.Main("4193 with words"));
            //Console.WriteLine(MyAtoi.Main("words and 987"));
            //Console.WriteLine(MyAtoi.Main("-91283472332"));

            //Console.WriteLine(IntPalindrome.IsPalindrome(10));

            //Console.WriteLine(IntegerToRoman.IntToRoman(3));

            //Console.WriteLine(RomanToInteger.RomanToInt("MCMXCIV"));

            var res = MergeTwoSortedArrays.Merge(new int[] { 0, 1, 2, 7, 9 }, new int[] { 3, 8, 12, 15 });
        }
    }
}
