using System;
using System.Threading;

namespace LeetCode.Problems.PrintInOrder
{
    // https://leetcode.com/problems/print-in-order/
    public class Foo
    {
        ManualResetEventSlim firstEvent = new ManualResetEventSlim(false);
        ManualResetEventSlim secondEvent = new ManualResetEventSlim(false);

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
