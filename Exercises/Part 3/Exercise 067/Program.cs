using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_67
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
            var lastValue = list.LastOrDefault();
            Console.WriteLine(list[0]);
            Console.WriteLine(lastValue);
    }
  }
}
