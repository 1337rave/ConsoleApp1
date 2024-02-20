using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the range for Fibonacci numbers:");
        Console.Write("From: ");
        int from = Convert.ToInt32(Console.ReadLine());
        Console.Write("To: ");
        int to = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci numbers within the specified range:");
        DisplayFibonacciInRange(from, to);
    }

    static void DisplayFibonacciInRange(int from, int to)
    {
        int a = 0, b = 1, c = 0;
        while (c <= to)
        {
            if (c >= from)
            {
                Console.Write($"{c} ");
            }
            c = a + b;
            a = b;
            b = c;
        }
    }
}
