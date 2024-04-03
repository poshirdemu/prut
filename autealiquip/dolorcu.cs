using System;

class Program
{
    static void Main()
    {
        // Initialize the string with a value
        string name = "John Doe";

        // Check if the string is empty
        if (String.IsNullOrEmpty(name))
        {
            Console.WriteLine("The name is empty or null.");
        }
        else
        {
            // Print the name to the console
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
