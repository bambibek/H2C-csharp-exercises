using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int count = 0;
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Give a numbers: / -1 to exit");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != -1)
            {
                sum = sum + userInput; //sum += userInput
                count++;

                if(userInput % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

          
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers:" + count);
            Console.WriteLine("Average: " + (double)sum/count );
            Console.WriteLine("Even: " + evenCount);
            Console.WriteLine("Odd: " + oddCount);

        }
  }
}
