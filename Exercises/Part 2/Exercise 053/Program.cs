using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
            
            int num1 = 23;
            int num2 = 4;
            Division(num1, num2);

    }
    public static void Division(int num, int den)
    {
            double div = Convert.ToDouble(num)/den;
            Console.WriteLine(div);
    }

  }
}
