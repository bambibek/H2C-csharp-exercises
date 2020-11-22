using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number: ");
            int numInput = Convert.ToInt32(Console.ReadLine());
            if (numInput < 0)
            {
                Console.WriteLine(-1 * numInput);
            }
            else
            {
                Console.WriteLine(numInput);
            }
      
    }
  }
}
