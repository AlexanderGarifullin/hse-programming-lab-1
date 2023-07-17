using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 100, b = 0.001f;
            float h = ((Math.Pow(a - b, 3) - (a * a * a - 3 * a * a * b)) / (3 * a * b * b - b * b * b));
            Console.WriteLine(h);
        }
    }
}
