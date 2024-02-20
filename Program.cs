using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of B (greater than A): ");
        int B = Convert.ToInt32(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            // Repeat the current number i times
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
