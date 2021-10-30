using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.ZeroEvenOdd
{
    public class ZeroEvenOdd
    {
        private int n;
        private System.Threading.AutoResetEvent zeroEvent = new System.Threading.AutoResetEvent(false);
        private System.Threading.AutoResetEvent evenEvent = new System.Threading.AutoResetEvent(false);
        private System.Threading.AutoResetEvent oddEvent = new System.Threading.AutoResetEvent(false);


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
