﻿using LeetCode.Problems;
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

            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(""));
            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(" "));
            Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("dvdf"));
        }
    }
}
