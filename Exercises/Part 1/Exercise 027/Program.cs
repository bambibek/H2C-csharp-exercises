﻿using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("It is positive");
                
            }
            else
            {
                Console.WriteLine("It is negative");
            }

        }
  }
}
