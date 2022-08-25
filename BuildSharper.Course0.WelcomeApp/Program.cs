using System;

namespace BuildSharper.Course0.WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome to BuildSharper.com, {name}!");
        }
    }
}
