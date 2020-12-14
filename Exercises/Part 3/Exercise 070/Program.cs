using System;
using System.Collections.Generic;

namespace exercise_70
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();

      int input = Convert.ToInt32(Console.ReadLine());

       while (input != -1)
      {
        
        list.Add(input);
        input = Convert.ToInt32(Console.ReadLine());

       }
            // int temp = input;
            int greatest = 0;
            foreach (int value in list)
            {
                if (greatest <= value)
                {
                    greatest = value;
                }

            }
                Console.WriteLine("The greatest number is: " + greatest);

    }
  }
}
