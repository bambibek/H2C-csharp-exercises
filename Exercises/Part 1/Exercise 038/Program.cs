using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
            int count = 0;
            while (true)
            {
                Console.WriteLine("Give a number:  , 0 quits");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if(inputNum == 0)
                {
                    break;
                }
                else if(inputNum < 0)
                {
                    count = count + 1;
                }
                else
                {

                }

            }
            Console.WriteLine("Total amount of negative numbers: " + count);

    }
  }
}
