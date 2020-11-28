using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
            Console.WriteLine("how many stars: ");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintStars(input);

            //for square 
            Console.WriteLine("Size of stars: ");
            int inputSize = Convert.ToInt32(Console.ReadLine());
            PrintSquare(inputSize);

            //for rectangle
            Console.WriteLine("Width of Rectangle: ");
            int inputWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height of Rectangle: ");
            int inputHeight = Convert.ToInt32(Console.ReadLine());
            PrintRectangle(inputWidth, inputHeight);

            //for triangle
            Console.WriteLine("Size of Triangle: ");
            int inputTri = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(inputTri);

        }


    public static void PrintStars(int number)
    {
            for (int stars = 0; stars < number; stars++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
        for( int i =0; i<size; i++)
            {
                PrintStars(size);
            }
    }

    public static void PrintRectangle(int width, int height)
    {
            for(int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
    }

    public static void PrintTriangle(int size)
    {
        for(int i = 1; i<= size; i++)
            {
                PrintStars(i);
            }
    }
  }
}
