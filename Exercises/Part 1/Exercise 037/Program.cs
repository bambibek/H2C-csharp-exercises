using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int count = 0;
            while (true)
            {
                Console.WriteLine("Give a number: , 0 quits");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == 0)
                {
                    break;
                }
                else
                {
                    count = count + 1;
                }
               
            }
            Console.WriteLine("Total amount of numbers: " + count);

        }
  }
}
