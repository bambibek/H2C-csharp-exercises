using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine(" Give numbers: / give 9999 to stop");
            int input = Convert.ToInt32(Console.ReadLine());

            List <int> list = new List<int>();
            while(input != 9999)
            {
                list.Add(input);
                input = Convert.ToInt32(Console.ReadLine());
            }
            int small = list[0];
            foreach(int smallest in list)
            {
                if (small >=smallest)
                    {
                    small = smallest;
                }
            }

            Console.WriteLine(small);

            for(int i =0; i< list.Count; i++)
            {
                int smallestNum = list[i];
                if(small == smallestNum)
                {
                    Console.WriteLine(small + " is at index " + i);
                }
            }
    }
  }
}
