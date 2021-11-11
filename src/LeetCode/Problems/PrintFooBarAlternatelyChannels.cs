using System;

namespace LeetCode.Problems.PrintFooBarAlternatelyChannels
{
    // https://leetcode.com/problems/print-foobar-alternately/
    public class FooBar
    {
        private readonly int n;
        private readonly System.Threading.Channels.Channel<int> chanell = System.Threading.Channels.Channel.CreateBounded<int>(
            new System.Threading.Channels.BoundedChannelOptions(1000)
            {
                FullMode = System.Threading.Channels.BoundedChannelFullMode.DropOldest
            });

        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {
                printFoo();
                chanell.Writer.WriteAsync(1);
                chanell.Reader.TryRead(out int res);
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                chanell.Reader.TryRead(out int res);
                printBar();
                chanell.Writer.TryWrite(1);
            }
        }
    }
}
