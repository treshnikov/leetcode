using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/fizz-buzz-multithreaded
    public class FizzBuzz
    {
        private readonly int n;
        private int i;
        private readonly Semaphore numberSemaphore;
        private readonly Semaphore fizzSemaphore;
        private readonly Semaphore buzzSemaphore;
        private readonly Semaphore fizzBuzzSemaphore;

        public FizzBuzz(int n)
        {
            this.n = n;
            i = 1;
            numberSemaphore = new Semaphore(1, 1);
            fizzSemaphore = new Semaphore(0, 1);
            buzzSemaphore = new Semaphore(0, 1);
            fizzBuzzSemaphore = new Semaphore(0, 1);
        }

        public void Fizz(Action printFizz)
        {
            while (i <= n)
            {
                fizzSemaphore.WaitOne();

                if (i > n)
                    return;

                if (i % 3 == 0)
                {
                    printFizz();
                    i++;
                }
                ReleaseSemaphore(i);
            }
        }

        public void Buzz(Action printBuzz)
        {
            while (i <= n)
            {
                buzzSemaphore.WaitOne();

                if (i > n)
                    return;

                if (i % 5 == 0)
                {
                    printBuzz();
                    i++;
                }
                ReleaseSemaphore(i);
            }
        }

        public void Fizzbuzz(Action printFizzBuzz)
        {
            while (i <= n)
            {
                fizzBuzzSemaphore.WaitOne();

                if (i > n)
                    return;

                if (i % 15 == 0)
                {
                    printFizzBuzz();
                    i++;
                }

                ReleaseSemaphore(i);
            }
        }

        public void Number(Action<int> printNumber)
        {
            while (i <= n)
            {
                numberSemaphore.WaitOne();

                if (i > n)
                    return;

                if (i % 3 != 0 && i % 5 != 0)
                {
                    printNumber(i);
                    i++;
                }

                ReleaseSemaphore(i);
            }
        }

        private void ReleaseSemaphore(int i)
        {
            if (i > n)
            {
                numberSemaphore.Release();
                fizzSemaphore.Release();
                buzzSemaphore.Release();
                fizzBuzzSemaphore.Release();
                return;
            }

            if (i % 15 == 0)
            {
                fizzBuzzSemaphore.Release();
            }
            else if (i % 3 == 0)
            {
                fizzSemaphore.Release();
            }
            else if (i % 5 == 0)
            {
                buzzSemaphore.Release();
            }
            else
            {
                numberSemaphore.Release();
            }
        }
    }
}
