using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine(" print how many times?");
            int inputUser = Convert.ToInt32(Console.ReadLine());

            PrintPhrase(inputUser);
            
            
        }

    // Write your method here:
    public static void PrintPhrase(int times)
    {
            for(int count=0; count<times; count++)
            {
                Console.WriteLine("In a hole in the ground there lived a method.");
            }
            
    }
  }
}
