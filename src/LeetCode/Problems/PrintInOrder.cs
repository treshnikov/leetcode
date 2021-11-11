using System;
using System.Threading;

namespace LeetCode.Problems.PrintInOrder
{
    // https://leetcode.com/problems/print-in-order/
    public class Foo
    {
        readonly ManualResetEventSlim firstEvent = new(false);
        readonly ManualResetEventSlim secondEvent = new(false);

        public void First(Action printFirst)
        {
            printFirst();
            firstEvent.Set();
        }

        public void Second(Action printSecond)
        {
            firstEvent.Wait();
            
            printSecond();
            secondEvent.Set();
        }

        public void Third(Action printThird)
        {
            secondEvent.Wait();

            printThird();
        }
    }
}
