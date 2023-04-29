using System;

class Program
{
    static void Main(string[] args)
    {
        int A, B;

        Console.Write("Введіть число A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введіть число B: ");
        B = int.Parse(Console.ReadLine());

        int phiA = totient(A);
        int phiB = totient(B);

        int count = phiA * phiB;

        Console.WriteLine("Кількість пар взаємно простих чисел: " + count);
    }

    static int totient(int n)
    {
        int result = n;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                }

                result -= result / i;
            }
        }

        if (n > 1)
        {
            result -= result / n;
        }

        return result;
    }
}