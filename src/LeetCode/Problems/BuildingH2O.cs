using System;
using System.Threading;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/building-h2o/
    public class H2O
    {
        private readonly System.Threading.SemaphoreSlim semaphoreHydrogen = new(2, 2);
        private readonly System.Threading.AutoResetEvent twoHydrogenHasReceived = new(false);
        private readonly System.Threading.AutoResetEvent oneOxygenHasReceived = new(false);
        private readonly object lockObject1 = new();
        private readonly object lockObject2 = new();
        public H2O()
        {

        }

        public void Hydrogen(Action releaseHydrogen)
        {
            lock (lockObject1)
            {
                semaphoreHydrogen.Wait();
                releaseHydrogen();

                if (semaphoreHydrogen.CurrentCount == 0)
                {
                    semaphoreHydrogen.Release();
                    semaphoreHydrogen.Release();

                    twoHydrogenHasReceived.Set();
                    oneOxygenHasReceived.WaitOne();
                }
            }
        }

        public void Oxygen(Action releaseOxygen)
        {
            lock (lockObject2)
            {
                twoHydrogenHasReceived.WaitOne();
                releaseOxygen();

                oneOxygenHasReceived.Set();
            }
        }
    }
}
