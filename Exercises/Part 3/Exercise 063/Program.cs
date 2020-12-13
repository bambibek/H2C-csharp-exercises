using System;
using System.Collections.Generic;


namespace exercise_63
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            //1st way
            /* 
            while (true)
             {
                 int input = Convert.ToInt32(Console.ReadLine());
                 if (input == 0)
                 {
                     break;
                 }

                 list.Add(input);

             }*/
            
            //2nd way
            int input = Convert.ToInt32(Console.ReadLine());
           while(input!=0)
            {
                list.Add(input);
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(list[1] + list[2]);

        }
    }
}