using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Split the string into words using spaces as the delimiter
        string[] words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Count the number of words
        int wordCount = words.Length;

        Console.WriteLine($"Total number of words: {wordCount}");
        Console.ReadLine();
    }
    
}
