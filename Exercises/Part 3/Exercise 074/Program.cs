using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      string input = Console.ReadLine();
      while (input!="")
      {
        list.Add(input);
        input = Console.ReadLine();
      }

            Console.WriteLine("Search For?");
            string search =Console.ReadLine();
            
            foreach(string value in list)
            {
                
                if (search == value)
                {
                    Console.WriteLine(value + " was found!");
                    break;
                }
                else
                    Console.WriteLine(search + " was not found!");
                break;
            }
            
      
    }
  }
}

