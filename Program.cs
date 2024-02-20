using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a six-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Reverse the number
        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        Console.WriteLine($"Reversed number: {reversedNumber}");
    }
}
