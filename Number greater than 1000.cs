using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numeric integer: ");

        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 1000)
            {
                throw new Exception("The number must be between 0 and 1000.");
            }

            Console.WriteLine($"You entered: {number}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.ReadLine();
    }
}
