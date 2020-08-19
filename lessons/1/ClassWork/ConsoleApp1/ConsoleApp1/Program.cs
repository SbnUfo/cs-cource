using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Hello, " + name);
            Thread.Sleep(5000);
            Console.WriteLine("Bye, " + name);
            Console.ReadLine();
        }
    }
}
