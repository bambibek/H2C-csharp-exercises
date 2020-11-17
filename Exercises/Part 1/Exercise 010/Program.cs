using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
          

           Console.WriteLine("I will tell you a story, but i need some information.");
            Console.WriteLine("Give the name for main character: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Give the character a profession");
            string userProfession = Console.ReadLine();
            Console.WriteLine("Here is your story:");
            Console.WriteLine("Once upon a time there was a " + userProfession + " called " + userName);
            Console.WriteLine("On her way to work, " + userName + " often pondered what being " + userProfession + " meant to them.");
            Console.WriteLine("When you work as s " + userProfession + " you meet interesting people.");
            Console.WriteLine(userName + " enjoys their work as " + userProfession + ", The End.");


        }
    }
}
