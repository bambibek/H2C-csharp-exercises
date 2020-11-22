using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("Give 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //getting squareroot of teh two numbers
            double squareRoot1 = Math.Sqrt(num1);
            double squareRoot2 = Math.Sqrt(num2);

            Console.WriteLine("The sum of the square root of the numbers is: " + (squareRoot1 + squareRoot2));

        }
  }
}
