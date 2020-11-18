using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a number!");
            int speed = Convert.ToInt32(Console.ReadLine());
            if(speed>=125)
            {
                Console.WriteLine("Your speed: " + speed );
                Console.WriteLine("Speeding!");
            }
            else
            {
                Console.WriteLine("Your Speed: " + speed);
            }
      
    }
  }
}
