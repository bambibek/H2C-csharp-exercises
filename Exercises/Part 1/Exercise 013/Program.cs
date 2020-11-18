using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(userInput);

            Console.WriteLine("You gave " + userInput);

    }
  }
}
