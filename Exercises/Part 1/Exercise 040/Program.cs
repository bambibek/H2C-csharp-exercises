using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

            int count = 0;
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
                    count = count + 1;
                    sum = numInput + sum;
                }
            }
            Console.WriteLine("Total summ of numbers : " + sum);
            Console.WriteLine("Total amount of numbers: " + count);
    }
  }
}
