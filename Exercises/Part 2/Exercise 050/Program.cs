using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine(" print how many times?");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            // Call your method here:
            while(count < inputUser)
            {
                PrintPhrase();
                count = count + 1;
            }
            
        }

    // Write your method here:
    public static void PrintPhrase()
    {
            Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
