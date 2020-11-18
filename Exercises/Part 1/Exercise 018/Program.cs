using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give your firsr integer!");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give your second integer!");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give your third integer!");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum is: " + (first + second + third));


    }
  }
}
