using System;

namespace task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a = 100, b = 0.001f;
                double c = Math.Pow(a - b, 3);
                double d = a * a * a;
                double e = 3 * a * a * b;
                double f = 3 * a * b * b;
                double g = b * b * b;
                double h = (c - (d - e)) / (f - g);
                Console.WriteLine($"double: {h}");
            }

            {
                float a = 100, b = 0.001f;
                float c = (float)Math.Pow(a - b, 3);
                float d = a * a * a;
                float e = 3 * a * a * b;
                float f = 3 * a * b * b;
                float g = b * b * b;
                float h = (c - (d - e)) / (f - g);
                Console.WriteLine($"double: {h}");
            }
        }
    }
}
