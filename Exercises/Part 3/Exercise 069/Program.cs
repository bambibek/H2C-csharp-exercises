﻿using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

            Console.WriteLine("From Where?");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int end = Convert.ToInt32(Console.ReadLine());

            foreach (int value in list)
            {
                if(value>begin && value < end)
                {
                    Console.WriteLine(value);
                }
            }
              
        }
  }
}
