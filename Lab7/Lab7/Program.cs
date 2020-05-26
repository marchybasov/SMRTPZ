using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            System.Diagnostics.Stopwatch sw = new Stopwatch();

            sw.Start();
            Calculate(1);
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.ReadLine();


        }


        public static void Calculate(int amountOfThread)
        {
            double circle_Radius = 1;
            int totalPointsCount = 10000000;
            int circlePointsCount = 0;
            //Random rnd = new Random();
            Parallel.For(1, totalPointsCount, new ParallelOptions { MaxDegreeOfParallelism = amountOfThread }, i =>
            {
                double x = RandomProvider.GetVal();
                double y = RandomProvider.GetVal();
                //Console.WriteLine($"x= {x}, y={y}");
                //Thread.Sleep(1);
                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= circle_Radius)
                {
                    circlePointsCount++;
                }

            });

            Console.WriteLine(4d * circlePointsCount / totalPointsCount);
        }

        public static class RandomProvider
        {
            private static int seed = Environment.TickCount;

            private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
                new Random(Interlocked.Increment(ref seed))
            );

            //public static Random GetThreadRandom()
            //{
            //    return randomWrapper.Value;
            //}
            public static double GetVal()
            {
                return randomWrapper.Value.NextDouble();
            }
        }
    }
}