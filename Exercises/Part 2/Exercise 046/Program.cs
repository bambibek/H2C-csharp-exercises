using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number below 100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput <= 100)
            {
                Console.WriteLine(userInput);
                userInput = userInput + 1;
            }

    }
  }
}
