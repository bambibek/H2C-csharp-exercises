using System;
using System.Collections.Generic;
using System.Linq;
namespace exercise_71
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

            Console.WriteLine("Search For?");
            int search = Convert.ToInt32(Console.ReadLine());
            int index = list.IndexOf(search);
            
                for (int i = 0; i < list.Count; i++)
                {
                    int num = list[i];
                    if(search==num)
                    {
                        Console.WriteLine(search + "is at index " + i);
                    }
                }

        }
    }
}
