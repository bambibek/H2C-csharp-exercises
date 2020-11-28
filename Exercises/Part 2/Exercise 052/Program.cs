using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
            // Call your method here:
            int userInput = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(userInput);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int num)
        {
           for(int count= num; count >= 1; count--)
            {
                Console.WriteLine(count);
            }

        }

  }
}
