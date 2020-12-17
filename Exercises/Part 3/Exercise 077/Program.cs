using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
            // You can try your method here if you want
            List<string> names = new List<string>();
            names.Add("First");
            names.Add("Second");
            names.Add("Third");

            //Console.WriteLine( names.ElementAt(2));
            names.ForEach(Console.WriteLine);

            RemoveLast(names);
            RemoveLast(names);

            names.ForEach(Console.WriteLine);
        }

        public static void RemoveLast(List<string> nameList)
        {
            int size = nameList.Count();

            int lastElementIndex = size - 1;

            nameList.RemoveAt(lastElementIndex);
            
        }
  }
}


