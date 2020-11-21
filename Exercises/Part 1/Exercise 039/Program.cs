using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int numInput = Convert.ToInt32(Console.ReadLine());

                if(numInput == 0)
                {
                    break;
                }
                else
                {
                    sum = sum + numInput;

                }
            }
            Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
