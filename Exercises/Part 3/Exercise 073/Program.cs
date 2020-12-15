using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
    int input = Convert.ToInt32(Console.ReadLine());
    List<int> list = new List<int>();
      while (input != -1)
      {
        list.Add(input);
        input = Convert.ToInt32(Console.ReadLine());
      }

            //using teh Linq (one way of getting the sum)
            /*
                  int index = list.IndexOf(input);

                  int sum = list.Sum();

                  Console.WriteLine("Sum: " + sum);
                  */

            //using foreacha loop (another way of getting the sum)
            int sum = 0;
            foreach (int values in list)  // getting all values in the list
                                          //Console.WriteLine(values); //prints the values

                sum += values; // also written as sum = sum+value;
            Console.WriteLine("Sum: " + sum);






        }
    }
}
