using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
            // Call your method here:
            Console.WriteLine("Give the begining number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the end number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            DivisibleByThreeInRange(input1, input2);
        }

    // Write your method here:
    public static void DivisibleByThreeInRange(int start, int end)
    {
            for(int count =start; count<=end; count++)
            {
                if(count%3 == 0)
                {
                    Console.WriteLine(count);
                }
                
            }
    }

  }
}
