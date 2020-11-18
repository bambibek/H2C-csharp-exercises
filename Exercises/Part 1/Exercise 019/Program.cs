using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first Number!");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second Number!");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first + " + " + second + " = s" + (first+second) );

        }
  }
}
