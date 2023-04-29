using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть натуральне число k: ");
        int k = int.Parse(Console.ReadLine());

        int lastTwoDigits = k % 100;
        Console.WriteLine("Дві останні цифри числа k: {0}", lastTwoDigits);
    }
}