using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            //1st way of doing
            // Console.WriteLine(number * number);

            //2nd way of getting same result
            double square = Math.Pow(number,2.0);
            Console.WriteLine(square);
      
    }
  }
}
