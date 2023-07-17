using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, r1;
            double x, y;
            bool ok, r2, r3;
            string buf;
            #region ввод исходных данных
            do
            {
                Console.WriteLine("Введите целое число n");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Не верно введены данные");
            } while (!ok);
            do
            {
                Console.WriteLine("Введите целое число m");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (!ok) Console.WriteLine("Не верно введены данные");
            } while (!ok);
            #endregion
            #region вычисления
            r1 = --m - n++;
            Console.WriteLine($"--m - n++ = {r1} n = {n} m = {m}");
            r2 = m * m < n++;
            Console.WriteLine($" m * m < n++ = {r2} n = {n} m = {m}");
            r3 = n-- > ++m;
            Console.WriteLine($"n-->++m = {r3} n = {n} m = {m}");
            #endregion
            #region выражение 4
            do
            {
                Console.WriteLine("Введите вещественное число x");
                buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (!ok) Console.WriteLine("Не верно введены данные");
            } while (!ok);
            if (x % 180 != 0 && x % 90 == 0 ) Console.WriteLine("Нельзя вычислить выражение!");
            else
            {
                y = Math.Tan(x * Math.PI / 180) - Math.Pow(5 - x, 4);
                Console.WriteLine($"x={x},y={y}");
            }
            #endregion
        }
    }
}

