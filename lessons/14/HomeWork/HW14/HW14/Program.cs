using System;
using System.Collections.Generic;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(new FibonacciNumber(10));
            Print(new FibonacciYiend(15));
        }

        static void Print(IEnumerable<int> enumerable)
        {
            Console.Write("{");
            foreach (var e in enumerable)
            {
                Console.Write($" {e} ");
            }
            Console.WriteLine("}");
        }
    }
}
