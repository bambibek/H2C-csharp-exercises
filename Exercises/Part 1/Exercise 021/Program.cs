using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give first number!");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second number!");
            int second = Convert.ToInt32(Console.ReadLine());

            double average = (first + second) / 2.0;
            Console.WriteLine("The Average is: " + average);
            

        }
  }
}
