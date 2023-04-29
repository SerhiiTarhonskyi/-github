using System;

namespace FunctionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -5; // початкове значення x
            double b = 5; // кінцеве значення x
            double h = 0.2; // крок
            int n = (int)Math.Ceiling((b - a) / h) + 1; // кількість точок
            double[] x = new double[n]; // масив значень x
            double[] y = new double[n]; // масив значень функції

            // обчислення значень функції та заповнення масивів x та y
            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h;
                y[i] = 12.4 * Math.Sin(Math.Abs(x[i] / 2 / 1)) + 9.1 * Math.Cos(x[i] - 1);
            }

            // виведення результатів у вигляді таблиці
            Console.WriteLine("x\tf(x)");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{x[i]:f2}\t{y[i]:f6}");
            }

            // обчислення кількості від'ємних та додатніх значень функції
            int negativeCount = 0;
            int positiveCount = 0;
            foreach (double value in y)
            {
                if (value < 0)
                {
                    negativeCount++;
                }
                else if (value > 0)
                {
                    positiveCount++;
                }
            }

            // виведення кількості від'ємних та додатніх значень функції
            Console.WriteLine($"Кількість від'ємних значень: {negativeCount}");
            Console.WriteLine($"Кількість додатніх значень: {positiveCount}");

            // побудова графіка
            Console.WriteLine("Графік функції:");
            for (double yValue = 4; yValue >= -4; yValue--)
            {
                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(y[i] - yValue) < h / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" " + new string('-', n));
            Console.Write(" ");
            for (int i = 0; i < n; i += 10)
            {
                Console.Write($"{x[i]:f0} ");
            }
            Console.WriteLine();
        }
    }
}