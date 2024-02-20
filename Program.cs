using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the line: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the filling character: ");
        char fillingChar = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the direction of the line (h for horizontal, v for vertical): ");
        char direction = Convert.ToChar(Console.ReadLine());

        if (direction == 'h')
        {
            // Horizontal line
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillingChar);
            }
        }
        else if (direction == 'v')
        {
            // Vertical line
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillingChar);
            }
        }
        else
        {
            Console.WriteLine("Invalid direction input. Please enter 'h' for horizontal or 'v' for vertical.");
        }
    }
}
