using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

            // Write your code here:
            Console.WriteLine("Give a string");
            string inputString = Console.ReadLine();
            Console.WriteLine("Give an integer");
            string inputInteger = Console.ReadLine();
            int intValue = Convert.ToInt32(inputInteger);
            Console.WriteLine("Give a double");
            string inputDouble = Console.ReadLine();
            double doubleValue = Convert.ToDouble(inputDouble);
            Console.WriteLine("Give a boolean");
            string inputBoolean = Console.ReadLine();
            bool booleanValue = Convert.ToBoolean(inputBoolean);
            Console.WriteLine("Your String: " + inputString);
            Console.WriteLine("Your Integer: " + inputInteger);
            Console.WriteLine("Your Double: " + inputDouble);
            Console.WriteLine("Your Boolean: " + inputBoolean);


        }
    }
}
