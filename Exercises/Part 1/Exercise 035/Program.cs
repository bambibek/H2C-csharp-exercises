﻿using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                Console.WriteLine("Give a number, 42 quits");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num == 42)
                {
                    break;
                }
            }

    }
  }
}
