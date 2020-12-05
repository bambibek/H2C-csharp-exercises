using System;

namespace exercise_61
{
  class Program
  {
       
    public static void Main(String[] args)
    {
            Console.WriteLine("Height of triangle: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //printspace
            //PrintSpaces(userInput);

            //Print Star
            //PrintStars(userInput);

            //Print right triangle
             //PrintRightTriangle(userInput);

            //Christmas tree
            ChristmasTree(userInput);

        }

        public static void PrintStars(int number)
    {
            for (int stars = 0; stars < number; stars++)
            {
                Console.Write("*");
            }
            //Console.WriteLine("");

        }

    public static void PrintSpaces(int number)
    {
            for(int i = 0; i<number; i++)
            {
                Console.Write(" ");
            }
           // Console.WriteLine("");
        }

    public static void PrintRightTriangle(int size)
    {
            int countSize=size;

            for(int i=1; i <= size; i++)
            {
                PrintSpaces(--countSize);
                PrintStars(i);

                Console.WriteLine("");

            }
            

        }

    public static void ChristmasTree(int height)
    {
            int countHeight = height;
            int val = 1;

            for(int i =1; i<=height; i++)
            {
                PrintSpaces(--countHeight);
                PrintStars(val);
                PrintSpaces(countHeight);

                Console.WriteLine("");

                val = val + 2;

                
            }

            int tempSpace = (val - 5)/2;
            

            for(int i=0; i<2;i++)
            {
                PrintSpaces(tempSpace);
                PrintStars(3);
                PrintSpaces(tempSpace);

                Console.WriteLine("");
            }
        }
  }
}
