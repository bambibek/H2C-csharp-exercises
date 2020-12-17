using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {

  public static void Main(string[] args)
    {
            // Example method calls for testing your method.
       
      List<int> numbers = new List<int>();
      numbers.Add(5);
      numbers.Add(4);
      numbers.Add(3);
      numbers.Add(-1);
      numbers.Add(7);
      numbers.Add(9);
      numbers.Add(2);
      numbers.Add(6);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);

    }
   public static void PrintNumbersInRange(List<int> bibek, int lowerLimit, int upperLimit)
     {
          foreach (int values in bibek)
            {
                if(values >= lowerLimit && values <= upperLimit)
                {
                    Console.WriteLine(values);
                }
            }
          
      }

    }
}

