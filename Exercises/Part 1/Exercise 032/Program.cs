﻿using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
           Console.WriteLine("Speak, friend, and enter!");
           string pass = Console.ReadLine();
           if(pass == "Mellon")
            {
                Console.WriteLine("Welcome, friend.");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }

    }
  }
}
