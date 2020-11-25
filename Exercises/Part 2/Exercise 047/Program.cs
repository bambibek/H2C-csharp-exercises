using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            //Section 1
           /* 
            int count = 0;
            Console.WriteLine("Where to?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while(userInput>=count)
            {
                Console.WriteLine(count);
                count = count + 1;
            }
           */
            
            
            //Section 2
            Console.WriteLine("Where to?");
            int endCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int beginCount = Convert.ToInt32(Console.ReadLine());

            while(beginCount<= endCount)
            {
                Console.WriteLine(beginCount);

                beginCount = beginCount + 1;
            }
            
      
    }
  }
}
