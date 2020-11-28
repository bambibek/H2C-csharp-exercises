using System;

namespace exercise_51
{
  class Program
  {
    
    public static void Main(String[] args)
    {
            // Call your method here:
            int userInput = Convert.ToInt32(Console.ReadLine());
            PrintUnitNumber(userInput);


    }

     // Write your method here:
    public static void PrintUnitNumber(int num)
    {
            for (int count = 1; count <= num; count++)
            {
                Console.WriteLine(count);
            }

    }
  }
}
