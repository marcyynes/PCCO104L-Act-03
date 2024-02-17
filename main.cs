using System;

class Program
{
    static void Main()
    {
        string userInput = "";
        string output = "";

        Console.WriteLine("Enter something:");

        while ((userInput = Console.ReadLine()) != "exit")
        {
            output += userInput + " ";
            Console.WriteLine(output.Trim());
            Console.WriteLine("Enter something:");
        }

        Console.WriteLine("\nClosing program...");
    }
}