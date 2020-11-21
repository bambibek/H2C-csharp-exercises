using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first string:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Give the second string:"); 
            string secondWord = Console.ReadLine();
            if(firstWord == secondWord)
            {
                Console.WriteLine("Echo!");

            }
            else
            {
                Console.WriteLine("Nope!");
            }

        }
  }
}
