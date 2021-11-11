using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.ZeroEvenOdd
{
    public class ZeroEvenOdd
    {
        private readonly int n;
        private readonly System.Threading.AutoResetEvent zeroEvent = new(false);
        private readonly System.Threading.AutoResetEvent evenEvent = new(false);
        private readonly System.Threading.AutoResetEvent oddEvent = new(false);


        public ZeroEvenOdd(int n)
        {
            this.n = n;
        }

        public void Zero(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                printNumber(0);
                if (i % 2 == 0)
                {
                    evenEvent.Set();
                }
                else
                {
                    oddEvent.Set();
                }

                if (i != n)
                {
                    zeroEvent.WaitOne();
                }
            }
        }

        public void Even(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenEvent.WaitOne();
                    printNumber(i);
                    zeroEvent.Set();
                }
            }
        }

        public void Odd(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    oddEvent.WaitOne();
                    printNumber(i);
                    zeroEvent.Set();
                }
            }

        }
    }
}
