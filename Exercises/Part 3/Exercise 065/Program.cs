using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
            int count = 0;
      List<string> list = new List<string>();
            //1st way
            /* while (true)
             {
               string input = Console.ReadLine();
               if (input == "")
               {
                 break;
               }
               list.Add(input);
                       count++;
             } */

            //2nd way
            string input = Console.ReadLine();
     while(input != "")
            {
                list.Add(input);
                count++;
                 input = Console.ReadLine();
            }

            Console.WriteLine(count);
    }
  }
}
