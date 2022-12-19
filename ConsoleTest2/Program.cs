using System;
using ConsoleTest2ServiceProvider;

namespace ConsoleTest2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello, World from {MyConsoleProvider.GetProvidingString()}!");
        }
    }
}