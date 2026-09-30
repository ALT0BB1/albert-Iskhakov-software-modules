namespace laba10_11Iskhakov
{
    internal class Task2
    {
        static void Main3()
        {
            double v1 = 10.0, v2 = 20.0, v3 = 30.0;
            double a1 = 0.2, a2 = 0.3, a3 = 0.3;

            double y = (a1 * v1) + (a2 * v2) + (a3 * v3);
            double S = a1 + a2 + a3;

            Console.WriteLine($"S = {S}");
            Console.WriteLine($"y = {y}");
        }
    }
}