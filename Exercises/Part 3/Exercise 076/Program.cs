﻿using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(8);

            int finalSum = Sum(numbers);
            Console.WriteLine(finalSum);
            
        }
    public static int Sum(List <int> numbers)
        {
            int sum = 0;
            foreach(int values in numbers)
            {
                sum += values;
            }
            return sum;
        }

  }
}


