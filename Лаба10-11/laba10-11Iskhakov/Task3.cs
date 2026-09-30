using System;

namespace laba10_11Iskhakov
{
    internal class Task3
    {
        static void Main()
        {
            double N = 15.0;
            double t = 3.5;
            double ops = N * Math.Pow(10, 9) / t;
            double gops = ops / Math.Pow(10, 9);

            Console.WriteLine($"OPS = {ops}");
            Console.WriteLine($"GOPS = {gops}");
        }
    }
}