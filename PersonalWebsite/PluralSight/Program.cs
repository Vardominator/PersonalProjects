using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string something = Console.ReadLine();

            Console.WriteLine($"Hello {something}!");
            Console.WriteLine("We all hate apple products.");
        }
    }
}
