using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

            int count = 0;

            Console.WriteLine("Give a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while(count <= userInput)
            {
                Console.WriteLine(count);
                count = count + 1;
            }

    }
  }
}
