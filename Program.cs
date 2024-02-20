using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");

        // Reading user-input numbers
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Finding the sum of numbers
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }

        // Finding the maximum and minimum
        double max = numbers[0];
        double min = numbers[0];
        foreach (double number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        // Finding the product of numbers
        double product = 1;
        foreach (double number in numbers)
        {
            product *= number;
        }

        // Outputting the results
        Console.WriteLine($"Sum of numbers: {sum}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Product of numbers: {product}");
    }
}
