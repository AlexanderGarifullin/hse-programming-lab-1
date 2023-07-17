using System;

namespace task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool isBelong;
            bool isCorrect;
            do
            {
                Console.WriteLine("Введите первую координату точки");
                isCorrect = double.TryParse(Console.ReadLine(), out x);
                if (!isCorrect)
                    Console.WriteLine("Не верно ввели вещественное число");
            } while (!isCorrect);

            do
            {
                Console.WriteLine("Введите вторую координату точки");
                isCorrect = double.TryParse(Console.ReadLine(), out y);
                if (!isCorrect)
                    Console.WriteLine("Не верно ввели вещественное число");
            } while (!isCorrect);

            isBelong = x*x+y*y <= 1 && x >= 0;
            Console.WriteLine($"Точка принадлежит заштрихованной области: {isBelong}");
        }
    }
}
