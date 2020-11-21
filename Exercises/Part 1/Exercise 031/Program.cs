using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            if (inputNum% 2 == 0)
            {
                Console.WriteLine("It is Even.");
            }
            else
            {
                Console.WriteLine("It is Odd.");
            }

    }
  }
}
