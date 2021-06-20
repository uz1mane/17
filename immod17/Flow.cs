using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immod17
{
    class Flow
    {
        Random rnd = new Random();
        public int lambda { get; set; }
        public int[] currentFlow { get; set; } = new int[20];

        public Flow()
        {
        }
        public void CreateCurrentFlow(double T)
        {
            int val = 0;
            for (double currentTime = SetTime(); currentTime <= T; currentTime += SetTime())
            {
                val++;
            }

            if (currentFlow.Length - 1 < val)
            {
                int[] newFlow = new int[val + 3];

                for (int i = 0; i < currentFlow.Length; i++)
                {
                    newFlow[i] = currentFlow[i];
                }
                currentFlow = newFlow;
            }
            currentFlow[val]++;
        }
        private double SetTime()
        {
            double a;
            a = rnd.NextDouble();
            while (a == 0)
            {
                a = rnd.NextDouble();
            }
            return -Math.Log(a) / lambda;
        }
    }

    class DoubleFlow
    {
        Random rnd = new Random();
        public int[] lambda { get; set; } = new int[2];
        public int[] curSumFlow { get; set; } = new int[20];

        public DoubleFlow()
        {
        }
        public void CreateCurrentFlow(double T)
        {
            int val = 0;
            for (double currentTime = -SetTime(1); currentTime <= T; currentTime -= SetTime(1))
            {
                val++;
            }
            for (double currentTime = -SetTime(0); currentTime <= T; currentTime -= SetTime(0))
            {
                val++;
            }

            if (curSumFlow.Length - 1 < val)
            {
                int[] newSumFlow = new int[val + 3];

                for (int i = 0; i < curSumFlow.Length; i++)
                {
                    newSumFlow[i] = curSumFlow[i];
                }
                curSumFlow = newSumFlow;
            }
            curSumFlow[val]++;
        }
        private double SetTime(int i)
        {
            double a;
            a = rnd.NextDouble();
            while (a == 0)
            {
                a = rnd.NextDouble();
            }
            return Math.Log(a) / lambda[i];
        }
    }
}
