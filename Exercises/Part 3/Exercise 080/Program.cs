﻿using System;
using System.Collections.Generic;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

    }
    
    public static int SumOfNumbersInArray(int[] numbers)
    {
            int arraySum = 0;
            for(int i =0; i< numbers.Length; i++)
            {
                arraySum += numbers[i];
            }
      return arraySum;
    }

  }
}


