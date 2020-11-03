using System;
using System.Threading;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/building-h2o/
    public class H2O
    {
        private System.Threading.SemaphoreSlim semaphoreHydrogen = new System.Threading.SemaphoreSlim(2, 2);
        private System.Threading.AutoResetEvent twoHydrogenHasReceived = new System.Threading.AutoResetEvent(false);
        private System.Threading.AutoResetEvent oneOxygenHasReceived = new System.Threading.AutoResetEvent(false);
        private object lockObject1 = new object();
        private object lockObject2 = new object();
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
