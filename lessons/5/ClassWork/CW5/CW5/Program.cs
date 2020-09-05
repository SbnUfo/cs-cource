using System;

namespace CW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");



            try
            {
                Console.WriteLine();
                for (; ; )
                {
                    try
                    {
                        Console.WriteLine
                    }

                }
            }
            catch (ArgumentException) { Console.WriteLine("Error"); }
           
            catch (FormatException excepton) {Console.WriteLine(excepton.StackTrace); }
        }
        static double rnwe (string caption)
            { for (; ; )
                {
                    int number;
                    var c = int.TryParse(Console.ReadLine(), out number);
                    if (c)
                    {
                        return number;
                    }
            }
        }
        
    }
}
