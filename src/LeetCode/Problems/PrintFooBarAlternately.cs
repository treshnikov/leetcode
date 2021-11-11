using System;
namespace LeetCode.Problems.PrintFooBarAlternately
{
    // https://leetcode.com/problems/print-foobar-alternately/
    public class FooBar
    {
        private readonly int n;
        private readonly System.Threading.AutoResetEvent fooEvent = new(false);
        private static readonly System.Threading.AutoResetEvent autoResetEvent = new(false);
        private readonly System.Threading.AutoResetEvent barEvent = autoResetEvent;

        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {
                printFoo();
                fooEvent.Set();

                if (i != n - 1)
                {
                    barEvent.WaitOne();
                }
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                fooEvent.WaitOne();

                printBar();
                barEvent.Set();
            }
        }
    }
}
