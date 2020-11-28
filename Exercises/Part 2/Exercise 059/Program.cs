using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int n1, int n2, int n3)
    {
        if(n1>n2 && n1 > n3)
            {
                return n1;
            }
        else if(n2>n1 && n2> n3)
            {
                return n2;
            }
            return n3;
    }
  }
}
