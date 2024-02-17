using System;

using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter something:");

    string input;
    do
    {
      input = Console.ReadLine();
      Console.WriteLine($"You entered: {input}");
    } while (input != "exit");

    Console.WriteLine("Closing program...");
  }
}